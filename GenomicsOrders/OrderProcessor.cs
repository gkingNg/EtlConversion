using GenomicsData;
using GenomicsData.Models;
using GenomicsOrders.OrderModel;
using GenomicsOrders.Utils;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenomicsOrders
{
    public class OrderProcessor
    {
        private int _labId;
        private int _genomicsUserId;
        private GenomicsRepository _repository;
        private Dictionary<string, int> _orderStatusCodes;

        private readonly ILogger _logger = LogManager.GetLogger("OrderProcessor");
        private IList<IGEN_ORDERSTATUS> _orderStatusRepository;

        public OrderProcessor()
        {

            //_orderStatusRepository = new List<IGEN_ORDERSTATUS>();
            _repository = new GenomicsRepository();

            foreach (IGEN_ORDERSTATUSCODES code in _repository.CurrentContext.Set<IGEN_ORDERSTATUSCODES>())
            {
                _orderStatusCodes.Add(code.STATUS, code.ORDERSTATUSCODES_ID);
            }
        }

        public void Execute(GenomicsOrder order)
        {
            var genomicsCustomer = _repository.Customer.FirstOrDefault(c => c.SHIPTO == order.CustId.SafeToString());
            if (genomicsCustomer == null)
            {
                _logger.Info("SL Customer does not exists. SL Customer number: " + order.CustId);
                throw new Exception("Customer does not exist in Genomics");
            }

            AddGenomicsOrder(order, genomicsCustomer);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderOrigin">Enum designation origin of order</param>
        /// <param name="genomicsCustomer"></param>
        /// <returns></returns>
        public int AddGenomicsOrder(GenomicsOrder order, IGEN_CUSTOMER genomicsCustomer)
        {
            var customerBreedAssocs = genomicsCustomer.IGEN_CUSTOMERBREEDASSOCIATION.ToList();

            var partialSamples = MakePartialGenomicsSamples(order, customerBreedAssocs);

            var igenityorder = new IGEN_IGENITYORDER
            {
                LAB_ID = _labId,
                CUSTOMER_ID = order.CustId,
                USER_ID = _genomicsUserId,
                COMPSALESREP_ID = null,
                DECELERATOR = false,
                CHECKAMOUNT = null,
                CHECKNUMBER = null,
                PRIORITY = 2,
                ORDERTYPE = $"Commercial {order.OrderOrigin.SafeToString()}",
                //MASTERORDERID = order.OrderNumber, gak Trinia says it's only used when coming from Solomon
                PAYMENTTYPE = "No Charge",
                PAYMENTREFERENCE = null,
                COMMENTS = order.Notes,
                REDOORDERID = null,
                EMAILRECEIVED_DATE = null,
                SEASON_ID = null,
            };

            igenityorder.IGEN_CUSTOMER = genomicsCustomer;


            if (!order.OrderDate.HasValue) order.OrderDate = DateTime.Now;

            AddOrderStatus(igenityorder, "Order Received", order.OrderDate.Value);

            foreach (var partialSample in partialSamples)
            {
                AddGenomicsSampleToOrder(igenityorder, partialSample);
            }

            AddOrderStatus(igenityorder, "Order Entered", order.OrderDate.Value);

            _repository.CurrentContext.Set<IGEN_IGENITYORDER>().Add(igenityorder);

            _repository.SaveChanges();

            _logger.Info(
                $"Genomics Order added  Genomics Order Id: {igenityorder.IGENITYORDER_ID}");

            return igenityorder.IGENITYORDER_ID;
        }

        private void AddGenomicsSampleToOrder(IGEN_IGENITYORDER entityOrder, IgenTransientSample partialSample)
        {
            partialSample.Animal.CUSTOMER_ID = entityOrder.CUSTOMER_ID;
            if (partialSample.AnimalBreedAssociation != null)
            {
                _repository.CurrentContext.Set<IGEN_ANIMALBREEDASSOCIATION>().Add(partialSample.AnimalBreedAssociation);
                partialSample.Animal.IGEN_ANIMALBREEDASSOCIATION = new List<IGEN_ANIMALBREEDASSOCIATION>
                    {partialSample.AnimalBreedAssociation};
            }

            _repository.CurrentContext.Set<IGEN_ANIMAL>().Add(partialSample.Animal);

            partialSample.Sample.IGEN_IGENITYORDER = entityOrder;
            partialSample.Sample.IGEN_ANIMAL = partialSample.Animal;

            if (partialSample.Sire != null)
            {
                _repository.CurrentContext.Set<IGEN_POTENTIALSIRE>().Add(partialSample.Sire);
                partialSample.Sample.IGEN_POTENTIALSIRE = new List<IGEN_POTENTIALSIRE> { partialSample.Sire };
            }

            if (partialSample.Dam != null)
            {
                _repository.CurrentContext.Set<IGEN_POTENTIALDAM>().Add(partialSample.Dam);
                partialSample.Sample.IGEN_POTENTIALDAM = new List<IGEN_POTENTIALDAM> { partialSample.Dam };
            }

            var dbSample = _repository.Sample.FirstOrDefault(s => s.BARCODEID == partialSample.Sample.BARCODEID);
            if (dbSample != null)
                partialSample.Sample.REFBARCODEID = dbSample.REFBARCODEID;

            _repository.CurrentContext.Set<IGEN_SAMPLE>().Add(partialSample.Sample);

            foreach (var product in partialSample.Products)
            {
                _repository.CurrentContext.Set<IGEN_SAMPLEPRODUCTMAP>().Add(new IGEN_SAMPLEPRODUCTMAP()
                {
                    dLastDWUpdate = DateTime.Now,
                    IGEN_SAMPLE = partialSample.Sample,
                    IGEN_PRODUCT = product
                });
            }

            //partialSample.Sample.IGEN_SCIENTIFICTEST = partialSample.Tests;
        }

        private void AddOrderStatus(IGEN_IGENITYORDER order, string status, DateTime date)
        {
            order.IGEN_ORDERSTATUS.Add(new IGEN_ORDERSTATUS
            {
                IGEN_IGENITYORDER = order,
                ORDERSTATUSCODES_ID = _orderStatusCodes[status],
                STATUSDATE = date
            });
        }

        private List<IgenTransientSample> MakePartialGenomicsSamples(GenomicsOrder genOrder,
            List<IGEN_CUSTOMERBREEDASSOCIATION> customerBreedAssocs)
        {


            var partialSamples = new Dictionary<string, IgenTransientSample>();
            foreach (var genOrderProduct in genOrder.Products)
            {


                foreach (var genSample in genOrderProduct.Samples)
                {
                    var sample = new IGEN_SAMPLE();
                    sample.ISVALID = true;

                    var sire = new IGEN_POTENTIALSIRE();
                    var dam = new IGEN_POTENTIALDAM();
                    var animal = new IGEN_ANIMAL();
                    //var animalBreedAssoc = new IGEN_ANIMALBREEDASSOCIATION();
                    //var fieldValues = new IGEN_FIELDVALUES();

                    sample.BARCODEID = genSample.BarcodeId;
                    //TODO: ref barcode id logic?
                    sample.REFBARCODEID = genSample.BarcodeId;
                    sample.SUBSTRATE = genSample.Substrate;
                    sample.CASENUM = genSample.CaseNumber;
                    sample.COMMENTS = genSample.Comments;
                    sample.BATCHNUMBER = genSample.BatchNumber.SafeInt();

                    sire.BREED1 = genSample.SireId;
                    sire.BREEDASSOCIATIONID = genSample.SireRegistrationNumber;

                    dam.BREED1 = genSample.DamId;
                    dam.BREEDASSOCIATIONID = genSample.DamRegistrationNumber;

                    animal.ANIMAL_ID = genSample.AnimalId;
                    animal.BREEDASSOCIATIONID = genSample.BreedingAssociationCodeId;

                    var custBreedAssoc = customerBreedAssocs.FirstOrDefault(f =>
                        f.BREEDASSOCIATIONCODE == genSample.BreedingAssociationCode);
                    if (custBreedAssoc != null)
                    {
                        custBreedAssoc.MEMBERNUMBER = custBreedAssoc.MEMBERNUMBER;
                    }

                    animal.ELECTRONICID = genSample.ElectronicId;
                    animal.SEX = genSample.SexofAnimal.FixSexValue();
                    animal.BREED1 = genSample.Breed1;
                    animal.BREED2 = genSample.Breed2;
                    animal.SIREGROUP = genSample.SireGroup;
                    animal.BIRTHDATE = genSample.BirthDate;
                    animal.ANIMALID2 = genSample.AnimalId2;
                    animal.BIRTHSTATUS = GetBirthStatus(genSample);



                }
            }


            return partialSamples.Values.ToList();
        }

        private int? GetBirthStatus(GenomicsSamples genSample)
        {
            var fieldStatus = _repository.FieldStatus.FirstOrDefault(x => x.FIELDVALUE == genSample.BirthStatus);
            return fieldStatus?.ID;
        }

        private class IgenTransientSample
        {
            public IGEN_SAMPLE Sample;
            public IGEN_ANIMAL Animal;
            public IGEN_POTENTIALSIRE Sire;
            public IGEN_POTENTIALDAM Dam;
            public IGEN_ANIMALBREEDASSOCIATION AnimalBreedAssociation;
            public List<IGEN_PRODUCT> Products;
            public List<IGEN_SCIENTIFICTEST> Tests;
        }
    }
}
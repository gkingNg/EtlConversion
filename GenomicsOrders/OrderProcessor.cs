using System;
using System.Collections.Generic;
using System.Linq;
using GenomicsData.Model;
using GenomicsData.Repositories;
using GenomicsOrders.OrderModel;
using GenomicsOrders.Utils;
using NLog;

namespace GenomicsOrders
{
    public class OrderProcessor
    {
        private readonly ILogger _logger = LogManager.GetLogger("OrderProcessor");


        private readonly AllRepositories _allRepositories;
        private int _labId;

        //private GenomicsRepository _repository;
        //private GenomicsModel _uow;


        //private OrderStatusRepository _orderStatusRepo;
        //private OrderStatusCodesRepository _orderStatusCodesRepo;


        private readonly Dictionary<string, int> _orderStatusCodesList;
        private IList<IGEN_ORDERSTATUS> _orderStatusRepositoryOld;

        public OrderProcessor()
        {
            _allRepositories = new AllRepositories();
            _orderStatusCodesList = new Dictionary<string, int>();

            foreach (var code in _allRepositories.OrderStatusCodesRepository.GetAll())
                _orderStatusCodesList.Add(code.STATUS, code.ORDERSTATUSCODES_ID);
        }

        /// <summary>
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public int AddGenomicsOrder(GenomicsOrder order)
        {
            var custId = order.CustId.SafeToString();
            var genomicsCustomer = _allRepositories.CustomRepository.FindBy(x => x.SHIPTO == custId).ToList()
                .FirstOrDefault();
            var genomicsUser = _allRepositories.UserRepository.FindBy(x => x.USER_ID == order.UserId).FirstOrDefault();
            var genomicsLab = _allRepositories.LabRepository.FindBy(x => x.LAB_ID == order.LabId).FirstOrDefault();

            ValidationObjects(order, genomicsCustomer, genomicsUser, genomicsLab);

            var partialSamples = MakeGenomicsSamples(order, genomicsCustomer);

            var igenityOrder = new IGEN_IGENITYORDER
            {
                COMPSALESREP_ID = null,
                DECELERATOR = false,
                CHECKAMOUNT = null,
                CHECKNUMBER = null,
                PRIORITY = 2,
                ORDERTYPE = $"Commercial {order.OrderOrigin.SafeToString()}",
                PAYMENTTYPE = "No Charge",
                PAYMENTREFERENCE = null,
                COMMENTS = order.Notes,
                REDOORDERID = null,
                EMAILRECEIVED_DATE = null,
                SEASON_ID = null,
                IGEN_CUSTOMER = genomicsCustomer,
                IGEN_USER = genomicsUser,
                IGEN_LAB = genomicsLab
            };

            if (!order.OrderDate.HasValue) order.OrderDate = DateTime.Now;

            AddOrderStatus(igenityOrder, "Order Received", order.OrderDate.Value);

            foreach (var sample in partialSamples)
            {
                igenityOrder.IGEN_SAMPLE.Add(sample);
            }

            _allRepositories.IgenitiyOrderRepository.Add(igenityOrder);

            _allRepositories.Save();

            _logger.Info(
                $"Genomics Order added  Genomics Order Id: {igenityOrder.IGENITYORDER_ID}");

            return igenityOrder.IGENITYORDER_ID;
        }

        private void ValidationObjects(GenomicsOrder order, IGEN_CUSTOMER genomicsCustomer, IGEN_USER genomicsUser,
            IGEN_LAB genomicsLab)
        {
            if (genomicsCustomer == null)
            {
                var msg = $"CustomerId ({order.CustId}) does not exists.";
                _logger.Info(msg);
                throw new Exception(msg);
            }

            if (genomicsUser == null)
            {
                var msg = $"User ({order.UserId}) does not exist.";
                _logger.Info(msg);
                throw new Exception(msg);
            }

            if (genomicsLab == null)
            {
                var msg = $"Lab Id ({_labId} does not exist.)";
                _logger.Info(msg);
                throw new Exception(msg);
            }
        }

        private void AddOrderStatus(IGEN_IGENITYORDER order, string status, DateTime date)
        {
            order.IGEN_ORDERSTATUS.Add(new IGEN_ORDERSTATUS
            {
                IGEN_IGENITYORDER = order,
                ORDERSTATUSCODES_ID = _orderStatusCodesList[status],
                STATUSDATE = date
            });
        }

        private List<IGEN_SAMPLE> MakeGenomicsSamples(GenomicsOrder genOrder, IGEN_CUSTOMER genomicsCustomer)
        {
            IList<IGEN_SAMPLE> samples = new List<IGEN_SAMPLE>();

            foreach (var genOrderProduct in genOrder.Products)
            foreach (var genSample in genOrderProduct.Samples)
            {
                var sample = new IGEN_SAMPLE {ISVALID = true};
                var sire = new IGEN_POTENTIALSIRE();
                var dam = new IGEN_POTENTIALDAM();
                var animal = new IGEN_ANIMAL();

                sample.BARCODEID = genSample.BarcodeId;
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
                animal.IGEN_CUSTOMER = genomicsCustomer;

                //gak seems to be only used on Customer
                //var custBreedAssoc = customerBreedAssocs.FirstOrDefault(f =>
                //    f.BREEDASSOCIATIONCODE == genSample.BreedingAssociationCode);
                //if (custBreedAssoc != null)
                //{
                //    custBreedAssoc.MEMBERNUMBER = custBreedAssoc.MEMBERNUMBER;
                //}

                animal.ELECTRONICID = genSample.ElectronicId;
                animal.SEX = genSample.SexofAnimal.FixSexValue();
                animal.BREED1 = genSample.Breed1;
                animal.BREED2 = genSample.Breed2;
                animal.SIREGROUP = genSample.SireGroup;
                animal.BIRTHDATE = genSample.BirthDate;
                animal.ANIMALID2 = genSample.AnimalId2;
                animal.BIRTHSTATUS = GetBirthStatus(genSample);

                sample.IGEN_POTENTIALDAM.Add(dam);
                sample.IGEN_POTENTIALSIRE.Add(sire);
                sample.IGEN_ANIMAL = animal;

                samples.Add(sample);
            }

            return samples.ToList();
        }

        private int? GetBirthStatus(GenomicsSamples genSample)
        {
            var fieldStatus = _allRepositories.FieldValuesRepository
                .FindBy(x => x.FIELDVALUE == genSample.BirthStatus
                             && x.FIELD == "BIRTHSTATUS")
                .FirstOrDefault();

            return fieldStatus?.ID;
        }
    }
}
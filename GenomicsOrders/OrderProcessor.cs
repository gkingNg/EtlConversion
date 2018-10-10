using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using GenomicsData;
using GenomicsData.Models;
using NLog;

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
        private IList<IGEN_IGENITYORDER> _IntityOrders;

        public OrderProcessor()
        {
            _IntityOrders = new List<IGEN_IGENITYORDER>();

            _orderStatusRepository = new List<IGEN_ORDERSTATUS>();
            foreach (var code in _repository.OrderStatusCodes)
            {
                _orderStatusCodes.Add(code.STATUS,code.ORDERSTATUSCODES_ID);
            }
        }

        private int AddGenomicsOrder(NewOrder order, OrderTypeSource orderTypeSource)
        {
            _repository = new GenomicsRepository();
            _logger.Info("Adding Genomics Order for SL Order. Order Number: " + order.OrdNbr);
            //gak reveiw
            var customerId = 0;
            List<IGEN_CUSTOMERBREEDASSOCIATION> customerBreedAssocs = new List<IGEN_CUSTOMERBREEDASSOCIATION>();

            var genomicsCustomer = _repository.Customer.FirstOrDefault(c => c.SHIPTO == order.CustId);
            if (genomicsCustomer == null)
            {
                _logger.Info("SL Customer does not exists. SL Customer number: " + order.CustId);
                throw new Exception("Customer does not exist in Genomics");
            }
            else
            {
                customerId = genomicsCustomer.CUSTOMER_ID;
                customerBreedAssocs = genomicsCustomer.IGEN_CUSTOMERBREEDASSOCIATION.ToList();
            }

            var partialSamples = MakePartialGenomicsSamples(order, customerBreedAssocs);


            var entityOrder = new IGEN_IGENITYORDER
            {
                LAB_ID = _labId,
                CUSTOMER_ID = customerId,
                USER_ID = _genomicsUserId,
                COMPSALESREP_ID = null,
                DECELERATOR = false,
                CHECKAMOUNT = null,
                CHECKNUMBER = null,
                PRIORITY = 2,
                ORDERTYPE = $"Commercial {orderTypeSource.ToString()}",
                //MASTERORDERID = order.OrdNbr, gak Trinia says it's only used when coming from Solomon
                PAYMENTTYPE = "No Charge",
                PAYMENTREFERENCE = null,
                COMMENTS = order.notes,
                REDOORDERID = null,
                EMAILRECEIVED_DATE = null,
                SEASON_ID = null
            };

            _IntityOrders.Add(entityOrder);

            if (!DateTime.TryParse(order.OrdDate, out var orderDate))
                orderDate = DateTime.Today;

            AddOrderStatus(entityOrder, "Order Received", orderDate);

            foreach (var partialSample in partialSamples)
            {
                AddGenomicsSample(entityOrder, partialSample);
            }

            AddOrderStatus(entityOrder, "Order Entered", orderDate);

            _repository.Context.SaveChanges();

            _logger.Info($"Genomics Order added for SL Order. SL Order number: {order.OrdNbr}. Genomics Order Id: {entityOrder.IGENITYORDER_ID}");

            return entityOrder.IGENITYORDER_ID;
        }

        private void AddGenomicsSample(IGEN_IGENITYORDER entityOrder, object partialSample)
        {
            throw new NotImplementedException();
        }

        private void AddOrderStatus(IGEN_IGENITYORDER order, string status, DateTime date)
        {
            _orderStatusRepository.Add(new IGEN_ORDERSTATUS
            {
                IGEN_IGENITYORDER = order,
                ORDERSTATUSCODES_ID = _orderStatusCodes[status],
                STATUSDATE = date
            });
        }

        private IEnumerable MakePartialGenomicsSamples(NewOrder order, List<IGEN_CUSTOMERBREEDASSOCIATION> customerBreedAssocs)
        {
            throw new NotImplementedException();
        }

    }
}
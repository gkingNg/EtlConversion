using System;
using System.Collections.Generic;
using GenomicsData;

namespace GenomicsOrders
{
    public class OrderProcessor
    {
        private int AddGenomicsOrder(order1 order)
        {
            Logger.Info("Adding Genomics Order for SL Order. Order Number: " + order.OrdNbr);
            //gak reveiw
            var customerId = 0;
            List<IGEN_CUSTOMERBREEDASSOCIATION> customerBreedAssocs = new List<IGEN_CUSTOMERBREEDASSOCIATION>();
            var genomicsCustomer = _customerRepository.Where(c => c.SHIPTO == order.CustID).FirstOrDefault();
            if (genomicsCustomer == null)
            {
                Logger.Info("SL Customer does not exists. SL Customer number: " + order.CustID);
                customerId = AddGenomicsCustomerForOrder(order);
            }
            else
            {
                customerId = genomicsCustomer.CUSTOMER_ID;
                customerBreedAssocs = genomicsCustomer.IGEN_CUSTOMERBREEDASSOCIATION.ToList();
            }

            var partialSamples = MakePartialGenomicsSamples(order, customerBreedAssocs);


            var entityOrder = new IGEN_IGENITYORDER
            {
                //gak several hard coded values
                LAB_ID = _labId,
                CUSTOMER_ID = customerId,
                USER_ID = _genomicsUserId,
                COMPSALESREP_ID = null,
                DECELERATOR = false,
                CHECKAMOUNT = null,
                CHECKNUMBER = null,
                PRIORITY = 2,
                //TODO: get the info from order service
                ORDERTYPE = "Commercial Beef",
                MASTERORDERID = order.OrdNbr,
                //TODO: get the info from order service
                PAYMENTTYPE = "No Charge",
                PAYMENTREFERENCE = null,
                COMMENTS = order.notes,
                REDOORDERID = null,
                EMAILRECEIVED_DATE = null,
                SEASON_ID = null
            };

            _orderRepository.Add(entityOrder);

            DateTime orderDate;
            if (!DateTime.TryParse(order.OrdDate, out orderDate))
                orderDate = DateTime.Today;

            AddOrderStatus(entityOrder, "Order Received", orderDate);

            foreach (var partialSample in partialSamples)
            {
                AddGenomicsSample(entityOrder, partialSample);
            }

            AddOrderStatus(entityOrder, "Order Entered", orderDate);

            _uow.Commit();

            Logger.InfoFormat("Genomics Order added for SL Order. SL Order number: {0}. Genomics Order Id: {1}",
                order.OrdNbr, entityOrder.IGENITYORDER_ID);

            return entityOrder.IGENITYORDER_ID;
        }

    }
}
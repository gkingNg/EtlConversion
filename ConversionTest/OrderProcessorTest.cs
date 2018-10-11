using System;
using GenomicsData.Models;
using GenomicsOrders;
using GenomicsOrders.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversionTest
{
    [TestClass]
    public class OrderProcessorTest
    {
        [TestMethod]
        public void OrderProcessorTest_NewOrder()
        {
            var orderProc = new OrderProcessor();
            var genomicsOrder = new GenomicsOrder()
            {
                CustId = 6227,
                Notes = "This is a test note",
                OrderDate = new DateTime(2018,4,1),
                OrderNumber = "1234"
                
            };

            orderProc.AddGenomicsOrder(genomicsOrder,new IGEN_CUSTOMER());


        }

        [TestMethod]
        public void OrderProcessorTest_NoCustomer()
        {

        }
    }
}
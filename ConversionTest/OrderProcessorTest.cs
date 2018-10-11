using System;
using GenomicsData.Models;
using GenomicsOrders;
using GenomicsOrders.OrderModel;
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

            var product  = new GenomicsProduct()
            {
                GenomicsProductId = 266
            };

            product.Samples.Add(new GenomicsSamples()
            {
                AnimalId = 1,
                AnimalId2 = "2",
                BarcodeId = "abc123",
                BatchNumber = "batch",
                BirthDate = new DateTime?(new DateTime(2018,4,1))

            });

            var genomicsOrder = new GenomicsOrder()
            {
                CustId = 6227,
                Notes = "This is a test note",
                OrderDate = new DateTime(2018,4,1),
                OrderNumber = "1234",
            };


            genomicsOrder.Products.Add(product);

            orderProc.AddGenomicsOrder(genomicsOrder,new IGEN_CUSTOMER());


        }

        [TestMethod]
        public void OrderProcessorTest_NoCustomer()
        {

        }
    }
}
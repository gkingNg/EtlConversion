using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using GenomicsData.Model;
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
           

            var product = new GenomicsProduct()
            {
                GenomicsProductId = 266
            };

            product.Samples.Add(new GenomicsSamples()
            {
                AnimalId = 1,
                AnimalId2 = "2",
                BarcodeId = "abc123",
                BatchNumber = "batch",
                BirthStatus = "TWIN",
                BirthDate = new DateTime?(new DateTime(2018, 4, 1))

            });

            var genomicsOrder = new GenomicsOrder()
            {
                CustId = 500005,
                Notes = "This is a test note",
                OrderDate = new DateTime(2018, 4, 1),
                OrderNumber = "1234",
                UserId = 229,
                OrderOrigin = OrderOrigin.Dairy,
                LabId = 3
            };


            genomicsOrder.Products.Add(product);

            var orderProc = new OrderProcessor();
            orderProc.AddGenomicsOrder(genomicsOrder);


        }

        [TestMethod]
        public void OrderProcessorTest_NoCustomer()
        {

        }

        [TestMethod]
        public void ThisIsATestTest_GetAll()
        {
            GenomicsModel uow = new GenomicsModel();
            var repo = new GenomicsData.Repositories.AnimalRepository(uow);

            var animals = repo.GetAll().First();
        }

        [TestMethod]
        public void ThisIsATestTest_FindBy()
        {
            GenomicsModel uow = new GenomicsModel();
            var repo = new GenomicsData.Repositories.AnimalRepository(uow);

            var animal = repo.FindBy(x => x.ANIMALID == "CLKG025M25S");
           Assert.AreEqual(179471, animal.First().ANIMAL_ID);

        }

        [TestMethod]
        public void OrderOriginTest_()
        {
            var origin = OrderOrigin.Beef;
            var result = origin.ToString();
            Assert.AreEqual("Beef",result);
        }
    }
}
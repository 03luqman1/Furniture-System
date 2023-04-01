using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create the an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see it exists
            Assert.IsNotNull(AnSupplier);
        }
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            // create an instance of the class we went to create
            clsSupplier Supplier = new clsSupplier();
            // create some test data to assign to the property
            Int32 TestData = 479921;
            // assign the data to the property
            Supplier.SupplierID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(Supplier.SupplierID, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string Testdata = "John Smith";
            Supplier.SupplierName = Testdata;
            Assert.AreEqual(Supplier.SupplierName, Testdata);
        }
        [TestMethod]
        public void SupplierIteamPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string Testdata = "Smart phone";
            Supplier.SupplierIteam = Testdata;
            Assert.AreEqual(Supplier.SupplierIteam, Testdata);
        }

        [TestMethod]
        public void SupplierIteamCostPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            decimal TestData = 400;
            Supplier.SupplierIteamCost = TestData;
            Assert.AreEqual(Supplier.SupplierIteamCost, TestData);

        }
        [TestMethod]
        public void EstimateDeliveryPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            Supplier.EstimateDelivery = TestData;
            Assert.AreEqual(Supplier.EstimateDelivery, TestData);

        }
        [TestMethod]
        public void SupplierIteamStatusPropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean TestData = true;
            Supplier.SupplierIteamStatus = TestData;
            Assert.AreEqual(Supplier.SupplierIteamStatus, TestData);

        }

    }



}

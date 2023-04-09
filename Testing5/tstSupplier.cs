//v00egd00001l.lec-admin.dmu.ac.uk   -- Database directory

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        private string SupplierName;
        private string SupplierIteam;
        private string EstimateDelivery;
        private string SupplierIteamCost;

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

        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 21;

            Found = Supplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = Supplier.Find(SupplierID);
            if (Supplier.SupplierID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = Supplier.Find(SupplierID);
            if (Supplier.SupplierName != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestSupplierIteamFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = Supplier.Find(SupplierID);
            if (Supplier.SupplierIteam != "IPhone 13Pro")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestSupplierIteamStatusFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = Supplier.Find(SupplierID);
            if (Supplier.SupplierIteamStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEstimateDeliveryFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = Supplier.Find(SupplierID);
            if (Supplier.EstimateDelivery != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestSupplierIteamCostFound()

        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 21;
            Found = Supplier.Find(SupplierID);
            if (Supplier.SupplierIteamCost != 1025)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void ValidMethodOK()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            Error = Supplier.Valid(SupplierName,SupplierIteam,EstimateDelivery,SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinMinusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "a";
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "a";
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "aa";
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxMinusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(49, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(50, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(51, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(25, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamMinMinusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "";
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "a";
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "aa";
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamMaxMinusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "";
            SupplierIteam = SupplierIteam.PadRight(49, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "";
            SupplierIteam = SupplierIteam.PadRight(50, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "";
            SupplierIteam = SupplierIteam.PadRight(51, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "";
            SupplierIteam = SupplierIteam.PadRight(200, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierIteamMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string SupplierIteam = "";
            SupplierIteam = SupplierIteam.PadRight(25, 'a');
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EstimateDeliveryExtremeMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1000);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryMinMinusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-3);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-150);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryMaxMinusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-3);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-2);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryMaxPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1000);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EstimateDeliveryMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-16);
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryToday()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string EstimateDelivery = TestDate.ToString();
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EstimateDeliveryInvalidData()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string EstimateDelivery = "This is not a date!";
            Error = Supplier.Valid(SupplierName, SupplierIteam, EstimateDelivery, SupplierIteamCost);
            Assert.AreNotEqual(Error, "");
        }






    }
}

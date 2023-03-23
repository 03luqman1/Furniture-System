//v00egd00001l.lec-admin.dmu.ac.uk   -- Database directory

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]

    
    public class tstCustomer
    {

        string Name = "Test Name";
        string DateOfBirth = DateTime.Now.Date.ToString();
        string Email = "TestEmail@TestMail.com";
        string PhoneNumber = "09284893523";
        string Verified = "true";

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void VerifiedOK()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean TestData = true;
            Customer.Verified = TestData;
            Assert.AreEqual(Customer.Verified, TestData);
        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            clsCustomer Customer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            Customer.DateOfBirth = TestData;
            Assert.AreEqual(Customer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer Customer = new clsCustomer();
            Int32 TestData = 232456;
            Customer.CustomerID = TestData;
            Assert.AreEqual(Customer.CustomerID, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsCustomer Customer = new clsCustomer();
            string TestData = "Simon Hugh";
            Customer.Name = TestData;
            Assert.AreEqual(Customer.Name, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer Customer = new clsCustomer();
            string TestData = "simon_hugh@gmail.com";
            Customer.Email = TestData;
            Assert.AreEqual(Customer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            clsCustomer Customer = new clsCustomer();
            string TestData = "07285645237";
            Customer.PhoneNumber = TestData;
            Assert.AreEqual(Customer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 21;

            Found = Customer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = Customer.Find(CustomerID);
            if (Customer.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = Customer.Find(CustomerID);
            if (Customer.Name != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = Customer.Find(CustomerID);
            if (Customer.DateOfBirth != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestVerifiedFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = Customer.Find(CustomerID);
            if (Customer.Verified != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = Customer.Find(CustomerID);
            if (Customer.Email != "TestName@TestMail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 21;
            Found = Customer.Find(CustomerID);
            if (Customer.PhoneNumber != "12345678901")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            Error = Customer.Valid(Name,DateOfBirth,Email,PhoneNumber,Verified);
            Assert.AreEqual(Error, "");
        }
    }
}

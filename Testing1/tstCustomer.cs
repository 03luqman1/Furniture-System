//v00egd00001l.lec-admin.dmu.ac.uk   -- Database directory

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
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
            Int32 CustomerID = 2;

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
            //string CustomerName = "test name";
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
            if (Customer.Name != "test name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void DateOfBirthFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = Customer.Find(CustomerId);
            if (Customer.DateOfBirth != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void VerifiedFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = Customer.Find(CustomerId);
            if (Customer.Verified != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void EmailFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = Customer.Find(CustomerId);
            if (Customer.Email != "test@email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void PhoneNumberFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = Customer.Find(CustomerId);
            if (Customer.PhoneNumber != "123456789")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}

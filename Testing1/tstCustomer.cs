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
            Customer.ID = TestData;
            Assert.AreEqual(Customer.ID, TestData);
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



    }
}

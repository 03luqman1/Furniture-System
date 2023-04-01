using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 10;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18).Date;
            TestItem.Name = "Testing Name";
            TestItem.Email = "testing_name@test.com";
            TestItem.PhoneNumber = "098766665521";
            TestItem.Verified = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerID = 10;
            TestCustomer.DateOfBirth = DateTime.Now.AddYears(-18).Date;
            TestCustomer.Name = "Testing Name";
            TestCustomer.Email = "testing_name@test.com";
            TestCustomer.PhoneNumber = "098766665521";
            TestCustomer.Verified = true;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 10;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18).Date;
            TestItem.Name = "Testing Name";
            TestItem.Email = "testing_name@test.com";
            TestItem.PhoneNumber = "098766665521";
            TestItem.Verified = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
           Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustomerID = 10;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18).Date;
            TestItem.Name = "Testing Name";
            TestItem.Email = "testing_name@test.com";
            TestItem.PhoneNumber = "098766665521";
            TestItem.Verified = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }



    }
}

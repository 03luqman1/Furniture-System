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
        /*
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Verified = true;
            TestItem.Name = "Test Name123";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(18);
            TestItem.Email = "test@mail.com123";
            TestItem.PhoneNumber = "12345654345";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.AddressNo = PrimaryKey;
            TestItem.Verified = false;
            TestItem.Name = "Test Name1234567";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(20);
            TestItem.Email = "test@mail.com12345678";
            TestItem.PhoneNumber = "1212121212121";
            AllCustomers.ThisAddress = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        CREATE PROCEDURE sproc_tblCustomer_Update
            @CustomerID int,
            @Name varchar(50),
            @DateOfBirth date,
            @Email varchar(50),
            @PhoneNumber varchar(50),
            @Verified bit

            AS
            update tblCustomer
            set Name-@Name,
                DateOfBirth-@DateOfBirth,
                Email-@Email,
                PhoneNumber-@PhoneNumber,
                Verified-@Verified

            where CustomerID-@CustomerID




        PUT IN CUSTOMER COLLECTION CLASS
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Verified", mThisCustomer.Verified);
            DB.Execute("sproc_tblCustomer_Update");
        }

        */












    }
}

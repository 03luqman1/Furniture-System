using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierID = 10;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18).Date;
            TestItem.Name = "Testing Name";
            TestItem.Email = "testing_name@test.com";
            TestItem.PhoneNumber = "098766665521";
            TestItem.Verified = true;
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }


        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
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
    }
}

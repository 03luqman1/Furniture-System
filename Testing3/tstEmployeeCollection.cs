using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstEmployeeCollection
    {
        public void InstanceOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            Assert.IsNotNull(AllEmployees);
        }

        [TestMethod]
        public void EmployeeListOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            List<clsEmployee> TestList = new List<clsEmployee>();
            clsEmployee TestItem = new clsEmployee();
            TestItem.EmployeeID = 10;
            TestItem.StartDate = DateTime.Now.AddDays(-1).Date;
            TestItem.Name = "Testing Name";
            TestItem.JobPosition = "Manager";
            TestItem.ContentNumber = "09876634521";
            TestItem.CurrentEmployeeStatus = true;
            TestList.Add(TestItem);
            AllEmployees.EmployeeList = TestList;
            Assert.AreEqual(AllEmployees.EmployeeList, TestList);
        }


        [TestMethod]
        public void ThisEmployeePropertyOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            clsEmployee TestEmployee = new clsEmployee();
            TestEmployee.EmployeeID = 10;
            TestEmployee.StartDate = DateTime.Now.AddDays(-1).Date;
            TestEmployee.Name = "Testing Name";
            //TestItem.JobPosition = "Manager";
            //TestItem.ContentNumber = "09876634521";
            //TestItem.CurrentEmployeeStatus = true;
            AllEmployees.ThisEmployee = TestEmployee;
            Assert.AreEqual(AllEmployees.ThisEmployee, TestEmployee);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            List<clsEmployee> TestList = new List<clsEmployee>();
            clsEmployee TestItem = new clsEmployee();
            TestItem.EmployeeID = 10;
            TestItem.StartDate = DateTime.Now.AddDays(-1).Date;
            TestItem.Name = "Testing Name";
            TestItem.JobPosition = "Manager";
            TestItem.ContentNumber = "09876634521";
            TestItem.CurrentEmployeeStatus = true;
            TestList.Add(TestItem);
            AllEmployees.EmployeeList = TestList;
            Assert.AreEqual(AllEmployees.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            clsEmployee TestItem = new clsEmployee();
            Int32 PrimaryKey = 0;
            TestItem.EmployeeID = 10;
            TestItem.StartDate = DateTime.Now.AddDays(-1).Date;
            TestItem.Name = "Testing Name";
            TestItem.JobPosition = "Manager";
            TestItem.ContentNumber = "09876634521";
            TestItem.CurrentEmployeeStatus = true;
            AllEmployees.ThisEmployee = TestItem;
            PrimaryKey = AllEmployees.Add();
            TestItem.EmployeeID = PrimaryKey;
            AllEmployees.ThisEmployee.Find(PrimaryKey);
            Assert.AreEqual(AllEmployees.ThisEmployee, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            clsEmployee TestItem = new clsEmployee();
            Int32 PrimaryKey = 0;
            TestItem.EmployeeID = 10;
            TestItem.StartDate = DateTime.Now.AddDays(-1).Date;
            TestItem.Name = "Testing Name";
            TestItem.JobPosition = "Manager";
            TestItem.ContentNumber = "09876634521";
            TestItem.CurrentEmployeeStatus = true;
            AllEmployees.ThisEmployee = TestItem;
            PrimaryKey = AllEmployees.Add();
            TestItem.EmployeeID = PrimaryKey;
            TestItem.CurrentEmployeeStatus = false;
            TestItem.Name = "Test Name87765";
            TestItem.StartDate = DateTime.Now.AddDays(-3).Date;
            TestItem.JobPosition = "Manager4567";

            TestItem.ContentNumber = "1212121212121";
            AllEmployees.ThisEmployee = TestItem;
            AllEmployees.Update();
            AllEmployees.ThisEmployee.Find(PrimaryKey);
            Assert.AreEqual(AllEmployees.ThisEmployee, TestItem);


            [TestMethod]
            public void DeleteMethodOK()
            {
                clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
                clsEmployee TestItem = new clsEmployee();
                Int32 PrimaryKey = 0;
                TestItem.EmployeeID = 10;
                TestItem.StartDate = DateTime.Now.AddDays(-1).Date;
                TestItem.Name = "Testing Name";
                TestItem.JobPosition = "Manager";
                TestItem.ContentNumber = "09876634521";
                TestItem.CurrentEmployeeStatus = true;
                AllEmployees.ThisEmployee = TestItem;
                PrimaryKey = AllEmployees.Add();
                TestItem.EmployeeID = PrimaryKey;
                AllEmployees.ThisEmployee.Find(PrimaryKey);
                AllEmployees.Delete();
                Boolean Found = AllEmployees.ThisEmployee.Find(PrimaryKey);
                Assert.IsFalse(Found);
            }

            [TestMethod]
            public void ReportByNameMethodOK()
            {
                clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
                clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();
                FilteredEmployees.ReportByName("");
                Assert.AreEqual(AllEmployees.Count, FilteredEmployees.Count);
            }

            [TestMethod]
            public void ReportByNameNoneFound()
            {
                clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();
                FilteredEmployees.ReportByName("THIS IS NOT A NAME");
                Assert.AreEqual(0, FilteredEmployees.Count);
            }

            [TestMethod]
            public void ReportByNameTestDataFound()
            {
                clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();
                Boolean OK = true;
                FilteredEmployees.ReportByName("Filter");
                if (FilteredEmployees.Count == 2)
                {
                    if (FilteredEmployees.EmployeeList[0].EmployeeID != 25)
                    {
                        OK = false;
                    }
                    if (FilteredEmployees.CustomerList[1].EmployeeID != 26)
                    {
                        OK = false;
                    }
                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

        }
    }
}

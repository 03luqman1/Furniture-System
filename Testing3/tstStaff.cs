using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create the an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //test to see it exists
            Assert.IsNotNull(AnEmployee);
        }
        [TestMethod]
        public void EmployeeIDPropertyOK()
        {
            // create an instance of the class we went to create
            clsEmployee Employee = new clsEmployee();
            // create some test data to assign to the property
            Int32 TestData = 479921;
            // assign the data to the property
            Employee.EmployeeID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(Employee.EmployeeID, TestData);
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            string Testdata = "Babar Azam";
            Employee.Name = Testdata;
            Assert.AreEqual(Employee.Name, Testdata);
        }
        [TestMethod]
        public void ContentNumberPropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            string TestData = "07428429221";
            Employee.ContentNumber = TestData;
            Assert.AreEqual(Employee.ContentNumber, TestData);

        }
        [TestMethod]
        public void JobPostionPropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            string TestData = "Manager";
            Employee.JobPostion = TestData;
            Assert.AreEqual(Employee.JobPostion, TestData);
        }
        [TestMethod]
        public void EmployeeSalaryPropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            decimal TestData = 4000;
            Employee.EmployeeSalary = TestData;
            Assert.AreEqual(Employee.EmployeeSalary, TestData);

        }
        [TestMethod]
        public void StartDatePropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            DateTime TestData = DateTime.Now.Date;
            Employee.StartData = TestData;
            Assert.AreEqual(Employee.StartData, TestData);

        }
        [TestMethod]
        public void CurrentEmployeeStatusPropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean TestData = true;
            Employee.CurrentEmployeeStatus = TestData;
            Assert.AreEqual(Employee.CurrentEmployeeStatus, TestData);

        }



    }
}

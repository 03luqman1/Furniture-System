//v00egd00001l.lec-admin.dmu.ac.uk   -- Database directory

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]


    public class tstEmployee
    {
        string Name = "Test Name";
        string ContentNumber = "12345678901";
        string StartDate = "01/01/2000";
        string CurrentEmployeeStatus = "true";
        string EmployeeSalary = "2500";
        string JobPosition = "Manager";

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
        public void JobPositionPropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            string TestData = "Manager";
            Employee.JobPosition = TestData;
            Assert.AreEqual(Employee.JobPosition, TestData);
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
            Employee.StartDate = TestData;
            Assert.AreEqual(Employee.StartDate, TestData);

        }
        [TestMethod]
        public void CurrentEmployeeStatusPropertyOK()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean TestData = true;
            Employee.CurrentEmployeeStatus = TestData;
            Assert.AreEqual(Employee.CurrentEmployeeStatus, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Int32 EmployeeID = 21;

            Found = Employee.Find(EmployeeID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestEmployeeIDFound()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 21;
            Found = Employee.Find(EmployeeID);
            if (Employee.EmployeeID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestNameFound()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 21;
            Found = Employee.Find(EmployeeID);
            if (Employee.Name != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestContentNumbeFound()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 21;
            Found = Employee.Find(EmployeeID);
            if (Employee.ContentNumber != "12345678901")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCurrentEmployeeStatusFound()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 21;
            Found = Employee.Find(EmployeeID);
            if (Employee.CurrentEmployeeStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStartDateFound()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 21;
            Found = Employee.Find(EmployeeID);
            if (Employee.StartDate != Convert.ToDateTime("01/01/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestJobPositionFound()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 21;
            Found = Employee.Find(EmployeeID);
            if (Employee.JobPosition != "Manager")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void EmployeeSalaryFound()
        {
            clsEmployee Employee = new clsEmployee();
            Boolean Found = false;
            Boolean OK = true;
            Int32 EmployeeID = 21;
            Found = Employee.Find(EmployeeID);
            if (Employee.EmployeeSalary != 2500)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void ValidMethodOK()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "a";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "aa";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(49, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(50, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(51, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(1000, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NameMid()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(25, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ContentNumberExtremeMin()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberMinMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "11";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberMin()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "123";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberMinPlusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "1234";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberMaxMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "";
            ContentNumber = ContentNumber.PadRight(13, '1');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "";
            ContentNumber = ContentNumber.PadRight(14, '1');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberMaxPlusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "";
            ContentNumber = ContentNumber.PadRight(15, '1');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberExtremeMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "";
            ContentNumber = ContentNumber.PadRight(100, '1');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ContentNumberMid()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "";
            ContentNumber = ContentNumber.PadRight(10, '1');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContentNumberIsNumeric()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string ContentNumber = "1345h678";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void JobPositionExtremeMin()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionMinMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "aa";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionMin()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "abc";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionMinPlusOne()
        {
            clsEmployee Employee = new Employee();
            String Error = "";
            string JobPosition = "abcd";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionMaxMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "";
            Email = Email.PadRight(49, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "";
            JobPosition = JobPosition.PadRight(50, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionMaxPlusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "";
            JobPosition = JobPosition.PadRight(51, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionExtremeMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "";
            JobPosition = JobPosition.PadRight(1000, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void JobPositionMid()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "";
            JobPosition = JobPosition.PadRight(25, '@');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobPositionSymbol()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string JobPosition = "";
            JobPosition = JobPosition.PadRight(25, 'a');
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMin()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1).AddYears(-35);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-35);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinPlusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1).AddYears(-35);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMaxMinusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-2);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMaxPlusOne()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(0);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StartDateMid()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateToday()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StartDate = TestDate.ToString();
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData()
        {
            clsEmployee Employee = new clsEmployee();
            String Error = "";
            string StartDate = "This is not a date!";
            Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
            Assert.AreNotEqual(Error, "");
        }
    }
}
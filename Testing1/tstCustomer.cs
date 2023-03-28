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
        string DateOfBirth = "12/03/2000";
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

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "a";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "aa";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(49, 'a');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(50, 'a');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(51, 'a');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(1000, 'a');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NameMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(25, 'a');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "a@";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "a@b";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "a@bc";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, '@');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(50, '@');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(51, '@');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(1000, '@');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, '@');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailSymbol()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, 'a');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }























        [TestMethod]
        public void PhoneNumberExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "12";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "123";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "1234";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(14, '1');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(15, '1');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(16, '1');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(100, '1');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(10, '1');
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberIsNumeric()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "1345h678";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1000);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1).AddYears(-150);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-150);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1).AddYears(-150);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxMinusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1).AddYears(-18);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1).AddYears(-18);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1000);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateOfBirthMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-66);
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthToday()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfBirth = TestDate.ToString();
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string DateOfBirth = "This is not a date!";
            Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
            Assert.AreNotEqual(Error, "");
        }
    }
}

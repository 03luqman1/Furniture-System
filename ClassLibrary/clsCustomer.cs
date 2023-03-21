using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        private string mName;
        private DateTime mDateOfBirth;
        private bool mVerified;
        private string mEmail;
        private string mPhoneNumber;
        public DateTime DateOfBirth 
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        public bool Verified
        {
            get
            {
                return mVerified;
            }
            set
            {
                mVerified = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public bool Find(int customerID)
        {
            mCustomerID = 21;
            mName = "test name";
            mDateOfBirth = Convert.ToDateTime("16/09/2015");
            mVerified = true;
            mEmail = "test@email.com";
            mPhoneNumber = "123456789";
            return true;
        }

        

    }
}
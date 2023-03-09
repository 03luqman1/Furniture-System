using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        private string mCustomerName;
        public DateTime DateOfBirth { get; set; }
        public bool Verified { get; set; }
        public string Name
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
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




        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public bool Find(int customerNo)
        {
            mCustomerID = 2;
            return true;
        }
    }
}
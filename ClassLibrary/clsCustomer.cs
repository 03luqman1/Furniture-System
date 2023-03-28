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

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mVerified = Convert.ToBoolean(DB.DataTable.Rows[0]["Verified"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string name,string dateOfBirth,string email,string phoneNumber,string verified)
        {
            String Error = "";
            DateTime DateTemp;
            if (name.Length == 0)
            {
                Error = Error + "The Name Cannot Be Left Blank : ";
            }
            if (name.Length > 50)
            {
                Error = Error + "The Name Cannot Be More Than 50 Characters: ";
            }
            if ((email.Length < 3) || (email.Contains("@") == false))
            {
                Error = Error + "Please Enter A Valid Email Address : ";
            }
            if (email.Length > 50)
            {
                Error = Error + "The Email Address Cannot Be More Than 50 Characters : ";
            }
            if (phoneNumber.Length < 3)
            {
                Error = Error + "The Phone Number Cannot Be Less Than 3 Characters : ";
            }
            if (phoneNumber.Length > 15)
            {
                Error = Error + "The Phone Number Cannot Be More Than 15 Characters : ";
            }
            bool Digits = true;
            foreach (char c in phoneNumber)
            {
                if (c < '0' || c > '9')
                {
                    Digits = false;
                }
            }
            if (Digits == false)
            {
                Error = Error + "The Email Address Must Only Contain Integers : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-150))
                {
                    Error = Error + "The Date Of Birth Cannot Be More Than 150 Years Ago : ";
                }
                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    Error = Error + "The Date Of Birth must show you are at least 18 Years Old : ";
                }
            }
            catch
            {
                Error = Error + "Please Enter the date in the correct format : ";
            }
            

















            return Error;
        }



    }
}
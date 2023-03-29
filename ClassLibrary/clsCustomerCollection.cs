using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();
                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                Customer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Customer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                Customer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Customer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                Customer.Verified = Convert.ToBoolean(DB.DataTable.Rows[Index]["Verified"]);
                mCustomerList.Add(Customer);
                Index++;
            }

            
        }
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get 
            {
                return mCustomerList.Count;
            }
            set 
            { 
                
            } 
        }
        public clsCustomer ThisCustomer { get; set; }
        
        
        
    }
}
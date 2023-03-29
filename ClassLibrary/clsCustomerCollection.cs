using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public clsCustomerCollection()
        {
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 11;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-19).Date;
            TestItem.Name = "Testing Name1";
            TestItem.Email = "testing_name1@test.com";
            TestItem.PhoneNumber = "098766665521";
            TestItem.Verified = false;
            mCustomerList.Add(TestItem);
            TestItem = new clsCustomer();
            TestItem.CustomerID = 12;
            TestItem.DateOfBirth = DateTime.Now.AddYears(-30).Date;
            TestItem.Name = "Testing Name2";
            TestItem.Email = "testing_name2@test.com";
            TestItem.PhoneNumber = "098766665521";
            TestItem.Verified = true;
            mCustomerList.Add(TestItem);
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
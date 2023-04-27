using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        private Int32 mOrderId;
        private string mOrderName;
        private DateTime mOrderDate;
        private string mOrderQuantity;
        private string mOrderCost;
        private bool mOrderConfirm;



        private Boolean mConfirm;
        public bool Confirm
        {
            get
            {
                return mConfirm;

            }
            set
            {
                mConfirm = value;

            }
        }

        private Int32 mOrderId;
        private string mOrderName;
        private DateTime mOrderDate;
        private Int32 mOrderQuantity;
        private decimal mOrderCost;
        private bool mOrderConfirm;


        public Int32 OrderId
        {
            get
            {
                return mOrderId;

            }
            set
            {
                mOrderId = value;

            }
        }


        public string OrderQuantity
        {
            get
            {
                return mOrderQuantity;
            }
            set
            {
                mOrderQuantity = value;
            }
        }



            }
        }

        public string OrderName
        {
            get
            {
                return mOrderName;
            }
            set
            {
                mOrderName = value;
            }
        }



        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;

            }
            set
            {
                mOrderDate = value;
            }
        }






        public string OrderCost

        
        public Int32 OrderQuantity
        {
            get
            {
                return mOrderQuantity;

            }
            set
            {
                mOrderQuantity = value;

            }
        }
       


        public decimal OrderCost

        {
            get
            {
                return mOrderCost;
            }
            set
            {
                mOrderCost = value;
            }

        }
        public bool OrderConfirm
        {
            get
            {
                return mOrderConfirm;
            }
            set
            {
                mOrderConfirm = value;
            }
        }

        public bool Find(int OrderID)

        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0][" SupplierID"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0][" SupplierName"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0][" OrderDate"]);
                mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0][" OrderQuantity"]);
                mOrderCost = Convert.ToDecimal(DB.DataTable.Rows[0][" OrderCost"]);
                mOrderConfirm = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderConfirm"]);
                    
                    return true;
            }

            else
            {
                return false;
            }


        }


        public string OrderName
        {
            get
            {
                return mOrderName;
            }
            set
            {
                mOrderName = value;
            }
        }

        public bool OrderConfirm
        {
            get
            {
                return mOrderConfirm;
            }
            set
            {
                mOrderConfirm = value;
            }
        }

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mOrderConfirm = Convert.ToBoolean(DB.DataTable.Rows[0]["Verified"]);
                mOrderQuantity = Convert.ToString(DB.DataTable.Rows[0]["OrderQuantity"]);
                mOrderCost = Convert.ToString(DB.DataTable.Rows[0]["OrderCost"]);
                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string OrderName, string OrderDate, string OrderQuantity, string OrderCost, string OrderConfirm)
        {
           
            String Error = "";
            
            DateTime DateTemp;
         
            if (OrderName.Length == 0)
            {
                
                Error = Error + "The OrderName may not be blank : ";
            }
           
            if (OrderName.Length > 15)
            {
                
                Error = Error + "The OrderName must be less than 15 characters : ";
            }
            try
            {
                
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                  
                    Error = Error + "The date cannot be in the past : ";
                }
               
                if (DateTemp > DateTime.Now.Date)
                {
                  
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                
                Error = Error + "The date was not a valid date : ";
            }
            
            if (OrderCost.Length == 0)
            {
               
                Error = Error + "The OrderCost may not be blank : ";
            }
           
            if (OrderCost.Length < 10)
            {
             
                Error = Error + "The OrderCost must be greater than 9  : ";
            }

          
            if (OrderQuantity.Length == 0)
            {
               
                Error = Error + "The OrderQuantity may not be blank : ";
            }
            
            if (OrderQuantity.Length <= 1)
            {
                
                Error = Error + "The OrderQuantity must be greater than or equal to 1 characters : ";
            }
            
            return Error;
        }


    }
}
using System;

namespace ClassLibrary
{
    public class clsOrder
    {

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
    }
}
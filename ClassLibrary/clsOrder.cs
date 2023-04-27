using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;

            }
            set
            {
                mActive = value;

            }
        }

        private Int32 mOrderId;
        private string mOrderName;
        private DateTime mOrderDate;
        private bool mOrderConfirm;
        private Int32 mOrderQuantity;
        private decimal mOrderCost;
        private bool mOrderStatus;

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
        public bool OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
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
                mOrderConfirm = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderConfirm"]);
                mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0][" OrderQuantity"]);
                mOrderCost = Convert.ToDecimal(DB.DataTable.Rows[0][" OrderCost"]);
                mOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0][" OrderStatus"]);
            

               
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
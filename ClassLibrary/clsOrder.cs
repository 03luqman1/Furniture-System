using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderId;
        private bool mConfirm;
        private DateTime mDateAdded;
        private int mQuantity;
        private decimal mCost;
        private string mName;
       

        public bool Find(int supplierID)

        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mOrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0][" OrderId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0][" Name"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0][" DateAdded"]);

                mConfirm= Convert.ToBoolean(DB.DataTable.Rows[0][" Confirm"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0][" Quantity"]);

                mCost = Convert.ToDecimal(DB.DataTable.Rows[0][" Cost"]);
                return true;
            }

            else
            {
                return false;
            }

        }
        public int OrderId
        {
            get
            {
                return OrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
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
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
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
        public decimal Cost
        {
            get
            {
                return mCost;
            }
            set
            {
                mCost = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        public string Valid(string Name, string Quantity, string DateAdded, string Cost, string Confirm)
        {
            String Error = "";
            DateTime DateTemp;
            if (Name.Length == 0)
            {
                Error = Error + "The Name Cannot Be Left Blank : ";
            }
            if (Name.Length > 50)
            {
                Error = Error + "The Name Cannot Be More Than 50 Characters : ";
            }
            if (Quantity.Length == 0)
            {
                Error = Error + "The Iteam Cannot Be Left Blank : ";
            }
            if (Quantity.Length > 50)
            {
                Error = Error + "The Iteam Cannot Be More Than 50 Characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date.AddDays(-30))
                {
                    Error = Error + "The Date Cannot Be More Than 30 Days Ago : ";
                }
                if (DateTemp > DateTime.Now.Date.AddDays(-2))
                {
                    Error = Error + "The Date Must Show You Are At Least 2 Days Old : ";
                }
            }
            catch
            {
                Error = Error + "Please Enter The Date In The Correct Format : ";
            }
            return "";
        }


    }
}

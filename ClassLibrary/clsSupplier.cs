using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private int mSupplierID;
        private bool mSupplierIteamStatus;
        private DateTime mEstimateDelivery;
        private string mSupplierIteam;
        private decimal mSupplierIteamCost;
        private string mSupplierName;

        public bool Find(int supplierID)

        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0][" SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0][" SupplierName"]);
                mEstimateDelivery = Convert.ToDateTime(DB.DataTable.Rows[0][" EstimateDelivery"]);

                mSupplierIteamStatus = Convert.ToBoolean(DB.DataTable.Rows[0][" SupplierIteamStatus"]);
                mSupplierIteam = Convert.ToString(DB.DataTable.Rows[0][" SupplierIteam"]);

                mSupplierIteamCost = Convert.ToDecimal(DB.DataTable.Rows[0][" SupplierIteamCost"]);
                return true;
            }

            else
            {
                return false;
            }

        }
        public int SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }
        public bool SupplierIteamStatus
        {
            get
            {
                return mSupplierIteamStatus;
            }
            set
            {
                mSupplierIteamStatus = value;
            }
        }
        public DateTime EstimateDelivery
        {
            get
            {
                return mEstimateDelivery;
            }
            set
            {
                mEstimateDelivery = value;
            }
        }
        public string SupplierIteam
        {
            get
            {
                return mSupplierIteam;
            }
            set
            {
                mSupplierIteam = value;
            }
        }
        public decimal SupplierIteamCost
        {
            get
            {
                return mSupplierIteamCost;
            }
            set
            {
                mSupplierIteamCost = value;
            }
        }
        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }

        public string Valid(string supplierName, string supplierIteam, string estimateDelivery, string supplierIteamCost)
        {
            String Error = "";
         
            if (supplierName.Length == 0)
            {
                Error = Error + "The Name Cannot Be Left Blank : ";
            }
            if (supplierName.Length > 50)
            {
                Error = Error + "The Name Cannot Be More Than 50 Characters : ";
            }
            return "";
        }

      
    }
}

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
            mSupplierID = 21;
            mSupplierIteamStatus = true;
            mEstimateDelivery = Convert.ToDateTime("01/01/2000");
            mSupplierIteam = "IPhone 13Pro";
            mSupplierIteamCost = 1025;
            mSupplierName = "Test Name";
            return true;
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


    }
}

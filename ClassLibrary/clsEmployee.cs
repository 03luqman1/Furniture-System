using System;

namespace ClassLibrary
{
    public class clsEmployee
    {
        private Int32 mEmployeeID;
        private string mName;
        private string mContentNumber;
        private string mJobPosition;
        private DateTime mStartDate;
        private bool mCurrentEmployeeStatus;
        private decimal mEmployeeSalary;


        public bool Find(int EmployeeID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EmployeeID", EmployeeID);
            DB.Execute("sproc_tbiStaff_FilterBy EmployeeID");
            if (DB.Count == 1)
            {
                mEmployeeID = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mCurrentEmployeeStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["CurrentEmployeeStatus"]);
                mJobPosition = Convert.ToString(DB.DataTable.Rows[0]["JobPosition"]);
                mContentNumber = Convert.ToString(DB.DataTable.Rows[0]["ContentNumber"]);
                mEmployeeSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["EmployeeSalary"]);
                return true;
            }

            else
            {
                return false;
            }
        }


        public Int32 EmployeeID
        {
            get
            {
                return mEmployeeID;
            }
            set
            {
                mEmployeeID = value;
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
        public string ContentNumber
        {
            get
            {
                return mContentNumber;
            }
            set
            {
                mContentNumber = value;
            }

        }
        public bool CurrentEmployeeStatus
        {
            get
            {
                return mCurrentEmployeeStatus;
            }
            set
            {
                mCurrentEmployeeStatus = value;
            }
        }
        public DateTime StartDate
        { 
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }
        public decimal EmployeeSalary
        {
            get
            {
                return mEmployeeSalary;
            }
            set
            {
                mEmployeeSalary = value;
            }
        }
        public string JobPosition
        {
            get
            {
                return mJobPosition;
            }
            set
            {
                mJobPosition = value;
            }
        }

   
    }

}
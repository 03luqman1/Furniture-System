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

        public string Vaild(string name, string employeeSalary, string startDate, string currentEmployeeStatus, string contentNumber, string jobPosition)
        {
            String Error = "";
            DateTime DateTemp;
            if (name.Length == 0)
            {
                Error = Error + "The Name Cannot Be Left Blank : ";
            }
            if (name.Length > 50)
            {
                Error = Error + "The Name Cannot Be More Than 50 Characters : ";
            }
            if (JobPosition.Length == 0)
            {
                Error = Error + "The JobPosition Cannot Be Left Blank : ";
            }
            if (JobPosition.Length > 50)
            {
                Error = Error + "The JobPosition Cannot Be More Than 50 Characters : ";
            }
            if (contentNumber.Length < 3)
            {
                Error = Error + "The Phone Number Cannot Be Less Than 3 Characters : ";
            }
            if (contentNumber.Length > 14)
            {
                Error = Error + "The Phone Number Cannot Be More Than 15 Characters : ";
            }
            bool Digits = true;
            foreach (char c in contentNumber)
            {
                if (c < '0' || c > '9')
                {
                    Digits = false;
                }
            }
            try
            {
                DateTemp = Convert.ToDateTime(StartDate);
                if (DateTemp < DateTime.Now.Date.AddYears(-35))
                {
                    Error = Error + "The StartDate Cannot Be More Than 35 Years Ago : ";
                }
                if (DateTemp > DateTime.Now.Date.AddDays(-1))
                {
                    Error = Error + "The StartDate Must Show You Are At Least 18 Years Old : ";
                }
            }
            catch
            {
                Error = Error + "Please Enter The Date In The Correct Format : ";
            }



            return Error;
            
        }
    }
}
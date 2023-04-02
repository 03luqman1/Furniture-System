using System;

namespace ClassLibrary
{
    public class clsEmployee
    {
        private Int32 mEmployeeID;
        private string mName;
        private string mContentNumber;
        private string mJobPostion;
        private DateTime mStartDate;
        private bool mCurrentEmployeeStatus;
        private decimal mEmployeeSalary;
       

        public bool Find(int mployeeID)
        {
            mEmployeeID = 21;
            mName = "Test Name";
            mContentNumber = "12345678901";
            mStartDate = Convert.ToDateTime("01/01/2000");
            mCurrentEmployeeStatus = true;
            mEmployeeSalary = 2500;
            mJobPostion = "Manager";
            return true;
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
        public string JobPostion
        {
            get
            {
                return mJobPostion;
            }
            set
            {
                mJobPostion = value;
            }
        }
    }

}
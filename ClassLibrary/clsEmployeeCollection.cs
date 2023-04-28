using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsEmployeeCollection
    {
        List<clsEmployee> mEmployeeList = new List<clsEmployee>();
        clsEmployee mThisEmployee = new clsEmployee();
        public clsEmployeeCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblEmployee_SelectAll");
            PopulateArray(DB);


        }
        public List<clsEmployee> EmployeeList
        {
            get
            {
                return mEmployeeList;
            }
            set
            {
                mEmployeeList = value;
            }
        }
        public int Count
        {
            get
            {
                return mEmployeeList.Count;
            }
            set
            {

            }
        }
        public clsEmployee ThisEmployee
        {
            get
            {
                return mThisEmployee;
            }
            set
            {
                mThisEmployee = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", mThisEmployee.Name);
            DB.AddParameter("@StartDate", mThisEmployee.StartDate);
            DB.AddParameter("@JobPosition", mThisEmployee.JobPosition);
            DB.AddParameter("@ContentNumber", mThisEmployee.ContentNumber);
            DB.AddParameter("@CurrentEmployeeStatus", mThisEmployee.CurrentEmployeeStatus);
            return DB.Execute("sproc_tblEmployee_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Name", mThisEmployee.Name);
            DB.AddParameter("@StartDate", mThisEmployee.StartDate);
            DB.AddParameter("@JobPosition", mThisEmployee.JobPosition);
            DB.AddParameter("@ContentNumber", mThisEmployee.ContentNumber);
            DB.AddParameter("@CurrentEmployeeStatus", mThisEmployee.CurrentEmployeeStatus);

            DB.Execute("sproc_tblEmployee_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_Employee_FilterByName");
            PopulateArray(DB);


        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mEmployeeList = new List<clsEmployee>();
            while (Index < RecordCount)
            {
                clsEmployee Employee = new clsEmployee();
                Employee.EmployeeID = Convert.ToInt32(DB.DataTable.Rows[Index][" EmployeeID"]);
                Employee.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Employee.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index][" StartDate"]);
                Employee.JobPosition = Convert.ToString(DB.DataTable.Rows[Index][" JobPosition"]);
                Employee.ContentNumber = Convert.ToString(DB.DataTable.Rows[Index][" ContentNumber"]);
                using System;
                using System.Collections.Generic;

namespace ClassLibrary
    {
        public class clsEmployeeCollection
        {
            List<clsEmployee> mEmployeeList = new List<clsEmployee>();
            clsEmployee mThisEmployee = new clsEmployee();
            public clsEmployeeCollection()
            {

                clsDataConnection DB = new clsDataConnection();
                DB.Execute("sproc_tblEmployee_SelectAll");
                PopulateArray(DB);


            }
            public List<clsEmployee> EmployeeList
            {
                get
                {
                    return mEmployeeList;
                }
                set
                {
                    mEmployeeList = value;
                }
            }
            public int Count
            {
                get
                {
                    return mEmployeeList.Count;
                }
                set
                {

                }
            }
            public clsEmployee ThisEmployee
            {
                get
                {
                    return mThisEmployee;
                }
                set
                {
                    mThisEmployee = value;
                }
            }

            public int Add()
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@Name", mThisEmployee.Name);
                DB.AddParameter("@StartDate", mThisEmployee.StartDate);
                DB.AddParameter("@JobPosition", mThisEmployee.JobPosition);
                DB.AddParameter("@ContentNumber", mThisEmployee.ContentNumber);
                DB.AddParameter("@CurrentEmployeeStatus", mThisEmployee.CurrentEmployeeStatus);
                return DB.Execute("sproc_tblEmployee_Insert");
            }

            public void Update()
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter
                DB.Execute("sproc_tblCustomer_Update");
            }

            public void Delete()
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
                DB.AddParameter("@Name", mThisEmployee.Name);
                DB.AddParameter("@StartDate", mThisEmployee.StartDate);
                DB.AddParameter("@JobPosition", mThisEmployee.JobPosition);
                DB.AddParameter("@ContentNumber", mThisEmployee.ContentNumber);
                DB.AddParameter("@CurrentEmployeeStatus", mThisEmployee.CurrentEmployeeStatus);

                DB.Execute("sproc_tblEmployee_Delete");
            }

            public void ReportByName(string Name)
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@Name", Name);
                DB.Execute("sproc_Employee_FilterByName");
                PopulateArray(DB);


            }

            void PopulateArray(clsDataConnection DB)
            {
                Int32 Index = 0;
                Int32 RecordCount = 0;
                RecordCount = DB.Count;
                mEmployeeList = new List<clsEmployee>();
                while (Index < RecordCount)
                {
                    clsEmployee Employee = new clsEmployee();
                    Employee.EmployeeID = Convert.ToInt32(DB.DataTable.Rows[Index][" EmployeeID"]);
                    Employee.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                    Employee.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index][" StartDate"]);
                    Employee.JobPosition = Convert.ToString(DB.DataTable.Rows[Index][" JobPosition"]);
                    Employee.ContentNumber = Convert.ToString(DB.DataTable.Rows[Index][" ContentNumber"]);
                    Employee.CurrentEmployeeStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["CurrentEmployeeStatus"]);
                    mEmployeeList.Add(Employee);
                    Index++;
                }
            }
        }
    }
.CurrentEmployeeStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["CurrentEmployeeStatus"]);
                mEmployeeList.Add(Employee);
                Index++;
            }
        }
    }
}

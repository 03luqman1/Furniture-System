using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 EmployeeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (EmployeeID != -1)
            {
                DisplayEmployee();
                txtEmployeeID.ReadOnly = true;
                btnFind.Visible = false;
            }
        }
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        clsEmployee Employee = new clsEmployee();
        string Name = txtEmployeeName.Text;
        string StartDate = txtEmployeeStartDate.Text.ToString();
        string EmployeeSalary = txtEmployeeSalary.Text.ToString();
        string JobPosition = txtEmployeeJobPosition.Text;
        string ContentNumber = txtEmployeeContentNo.Text;
        string CurrentEmployeeStatus = chkCurrentEmployeeStatus.Checked.ToString();
        string Error = "";
        Error = Employee.Valid(Name, EmployeeSalary, StartDate, CurrentEmployeeStatus, ContentNumber, JobPosition);
        if (Error == "")
        {
            // Employee.EmployeeID = EmployeeID;
            Employee.Name = Name;
            Employee.StartDate = Convert.ToDateTime(StartDate);
            Employee.JobPosition = JobPosition;
            Employee.ContentNumber = ContentNumber;
            Employee.CurrentEmployeeStatus = Convert.ToBoolean(CurrentEmployeeStatus);
           // Session["Employee"] = Employee;
           // Response.Write("EmployeeViewer.aspx");
            clsEmployeeCollection EmployeeList = new clsEmployeeCollection();
           if (EmployeeID == -1)
          {
           EmployeeList.ThisEmployee = Employee;
           EmployeeList.Add();
           }
           else
           {
              EmployeeList.ThisEmployee.Find(EmployeeID);
              EmployeeList.ThisEmployee = Employee;
               EmployeeList.Update();
           }

          Response.Redirect("EmployeeList.aspx");

        }
       else
       { 
          lblError.Text = Error;
       }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblDoesNotExist.Visible = false;
        clsEmployee Employee = new clsEmployee();
        Int32 EmployeeID;
        Boolean Found = false;
        EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
        Found = Employee.Find(EmployeeID);
        if (Found == true)
        {
            txtEmployeeName.Text = Employee.Name;
            txtEmployeeContentNo.Text = Employee.ContentNumber;
            txtEmployeeJobPosition.Text = Employee.JobPosition;
            txtEmployeeStartDate.Text = Employee.StartDate.ToString();
            txtEmployeeSalary.Text = Employee.EmployeeSalary.ToString();
            chkCurrentEmployeeStatus.Checked = Employee.CurrentEmployeeStatus;

        }
        else
        {
            lblDoesNotExist.Visible = true;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblDoesNotExist.Visible = false;
        clsEmployee Employee = new clsEmployee();
        Int32 EmployeeID;
        Boolean Found = false;
        EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
        Found = Employee.Find(EmployeeID);
        if (Found == true)
        {
            txtEmployeeName.Text = Employee.Name;
            txtEmployeeContentNo.Text = Employee.ContentNumber;
            txtEmployeeJobPosition.Text = Employee.JobPosition;
            txtEmployeeStartDate.Text = Employee.StartDate.ToString();
            txtEmployeeSalary.Text = Employee.EmployeeSalary.ToString();
            chkCurrentEmployeeStatus.Checked = Employee.CurrentEmployeeStatus;

        }
        else
        {
            lblDoesNotExist.Visible = true;
        }
    }
    void DisplayEmployee()
    {
        clsEmployee Employee = new clsEmployee();

        Boolean Found = false;
        EmployeeID = Convert.ToInt32(EmployeeID);
        Found = Employee.Find(EmployeeID);
        if (Found == true)
        {
            txtEmployeeID.Text = EmployeeID.ToString();
            txtEmployeeName.Text = Employee.Name;
            txtEmployeeContentNo.Text = Employee.ContentNumber;
            txtEmployeeJobPosition.Text = Employee.JobPosition;
            txtEmployeeStartDate.Text = Employee.StartDate.ToString();
            txtEmployeeSalary.Text = Employee.EmployeeSalary.ToString();
            chkCurrentEmployeeStatus.Checked = Employee.CurrentEmployeeStatus;
        }
    }

    protected void btnClear_Click1(object sender, EventArgs e)
    {
        txtEmployeeName.Text = "";
        txtEmployeeContentNo.Text = "";
        txtEmployeeJobPosition.Text = "";
        txtEmployeeStartDate.Text = "";
        txtEmployeeSalary.Text = "";
        chkCurrentEmployeeStatus.Checked = false;
    }

    protected void btnCancel0_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeList.aspx");
    }
}
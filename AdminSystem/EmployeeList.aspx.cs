using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {

            DisplayEmployees();

        }


    }
    void DisplayEmployees()
    {
        clsEmployeeCollection Employees = new clsEmployeeCollection();
        lstEmployeeList.DataSource = Employees.EmployeeList;
        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "Name";
        lstEmployeeList.DataBind();
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsEmployeeCollection Employees = new clsEmployeeCollection();
        Employees.ReportByName("");
        txtFilter.Text = "";
        lstEmployeeList.DataSource = Employees.EmployeeList;
        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "Name";
        lstEmployeeList.DataBind();

    }
    // Add Button
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["EmployeeID"] = -1;
        Response.Redirect("EmployeeDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;
        if (lstEmployeeList.SelectedIndex != -1)
        {
            EmployeeID = Convert.ToInt32(lstEmployeeList.SelectedValue);
            Session["EmployeeID"] = EmployeeID;
            Response.Redirect("EmployeeDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please Select A Record From The List To Edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 EmployeeID;
        if (lstEmployeeList.SelectedIndex != -1)
        {
            EmployeeID = Convert.ToInt32(lstEmployeeList.SelectedValue);
            Session["EmployeeID"] = EmployeeID;
            Response.Redirect("EmployeeConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please Select A Record From The List To Delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsEmployeeCollection Employees = new clsEmployeeCollection();
        Employees.ReportByName(txtFilter.Text);
        lstEmployeeList.DataSource = Employees.EmployeeList;
        lstEmployeeList.DataValueField = "EmployeeID";
        lstEmployeeList.DataTextField = "Name";
        lstEmployeeList.DataBind();
    }
}
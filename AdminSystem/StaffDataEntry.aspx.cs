using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       clsEmployee Employee = new clsEmployee();
       Employee = (clsEmployee)Session["Employee"];
       //Response.Write(Employee.EmployeeName);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsEmployee Employee = new clsEmployee();
        //Employee.EmployeeName = txtEmployeeName.Text;
        Session["Employee"] = Employee;
        // navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");


    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        Response.Redirect("StaffViewer.aspx");
    }
}
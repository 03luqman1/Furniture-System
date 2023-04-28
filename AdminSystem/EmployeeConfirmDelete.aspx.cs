using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 EmployeeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeID = Convert.ToInt32(Session["EmployeeID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsEmployeeCollection Employee = new clsEmployeeCollection();
        Employee.ThisEmployee.Find(EmployeeID);
        Employee.Delete();
        Response.Redirect("EmployeeList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeList.aspx");
    }
}
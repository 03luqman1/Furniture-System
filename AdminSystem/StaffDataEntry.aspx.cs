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
        //clsEmployee AnStaff = new clsEmployee();
       // AnStaff = (clsEmployee)Session["AnStaff"];
      //  Response.Write(AnStaff.EmployeeName);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsEmployee AnStaff = new clsEmployee();
        AnStaff.EmployeeName = txtEmployeeName.Text;
        Session["AnStaff"] = AnStaff;
        // navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");


    }
}
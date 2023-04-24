using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //private object txtOrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {// create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order no
        AnOrder.OrderNo = txtOrderNo.Text;
        // store the order in the session object
        Session["AnOrder"] = AnOrder;

        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

}


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

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();
        Supplier.SupplierName = txtSupplierName.Text;
        Session["Supplier"] = Supplier;
        Response.Redirect("SupplierViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblDoesNotExist.Visible = false;
        clsSupplier Supplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = Supplier.Find(SupplierID);
        if (Found == true)
        {
            txtSupplierName.Text = Supplier.SupplierName;
            txtSupplierIteam.Text = Supplier.SupplierIteam;
            txtEstimateDelivery.Text = Supplier.EstimateDelivery.ToString();
            txtSupplierIteamCost.Text = Supplier.SupplierIteamCost.ToString();
            chkSupplierIteamStatus.Checked = Supplier.SupplierIteamStatus;



        }
        else
        {
            lblDoesNotExist.Visible = true;
        }

    }

}

   
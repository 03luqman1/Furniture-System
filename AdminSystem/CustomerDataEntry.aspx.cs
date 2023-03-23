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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        Customer.Name = txtName.Text;
        Session["Customer"] = Customer;
        Response.Redirect("CustomerViewer.aspx");

    }
    
    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblDoesNotExist.Visible = false;
        clsCustomer Customer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = Customer.Find(CustomerID);
        if (Found == true)
        {
            txtName.Text = Customer.Name;
            txtEmailAddress.Text = Customer.Email;
            txtPhoneNumber.Text = Customer.PhoneNumber;
            txtDateOfBirth.Text = Customer.DateOfBirth.ToString();
            chkVerified.Checked = Customer.Verified;
        }
        else
        {
            lblDoesNotExist.Visible = true;
        }
    }
}
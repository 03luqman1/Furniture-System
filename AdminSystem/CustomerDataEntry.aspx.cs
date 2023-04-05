using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomer();
                txtCustomerID.ReadOnly = true;
                btnFind.Visible = false;
            }
        }
    }

    void DisplayCustomer()
    {
        clsCustomer Customer = new clsCustomer();
        
        Boolean Found = false;
        CustomerID = Convert.ToInt32(CustomerID);
        Found = Customer.Find(CustomerID);
        if (Found == true)
        {
            txtCustomerID.Text = CustomerID.ToString();
            txtName.Text = Customer.Name;
            txtEmailAddress.Text = Customer.Email;
            txtPhoneNumber.Text = Customer.PhoneNumber;
            txtDateOfBirth.Text = Customer.DateOfBirth.ToString();
            chkVerified.Checked = Customer.Verified;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        string Name = txtName.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Email = txtEmailAddress.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Verified = chkVerified.Checked.ToString();
        string Error = "";
        Error = Customer.Valid(Name, DateOfBirth, Email, PhoneNumber, Verified);
        if (Error == "")
        {
            Customer.CustomerID = CustomerID;
            Customer.Name = Name;
            Customer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            Customer.Email = Email;
            Customer.PhoneNumber = PhoneNumber;
            Customer.Verified = Convert.ToBoolean(Verified);
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerID == -1)
            {
                CustomerList.ThisCustomer = Customer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = Customer;
                CustomerList.Update();
            }
            
            Response.Redirect("CustomerList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }

    }
    
    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblDoesNotExist.Text = "";
        clsCustomer Customer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        try
        {
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
                lblDoesNotExist.Text = "The Customer ID Entered Does Not Exist";
            }
        }
        catch 
        {
            lblDoesNotExist.Text = "The Customer ID Must Be An Integer";
        }
        
        
    }




    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtEmailAddress.Text = "";
        txtPhoneNumber.Text = "";
        txtDateOfBirth.Text = "";
        chkVerified.Checked = false;
    }
}
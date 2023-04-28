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
        // OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //  if (OrderId != -1)
            {
                //     DisplaySupplier();
                txtOrderId.ReadOnly = true;
                btnFind.Visible = false;
            }
        }

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder Order = new clsOrder();
        string Name = txtName.Text;
        string Quantity = txtQuantity.Text;
        string DateAdded = txtDateAdded.Text.ToString();
        string Cost = txtCost.ToString();
        string Confirm = chkConfirm.Checked.ToString();
        string Error = "";
        Error = Order.Valid(Name, Quantity, DateAdded, Cost, Confirm);
        if (Error == "")
        {
            Order.Name = Name;
            Order.Quantity= Quantity;
            Order.DateAdded = Convert.ToDateTime(DateAdded);
            Order.Cost = Convert.ToDecimal(Cost);
            Order.Confirm = Convert.ToBoolean(Confirm);
            Session["Order"] = Order;
            Response.Redirect("OrderViewer.aspx");

        }

        Session["Order"] = Order;
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblDoesNotExist.Visible = false;
        clsOrder Order = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = Order.Find(OrderId);
        if (Found == true)
        {
            txtName.Text = Order.Name;
            txtQuantity.Text = Order.Quantity;
            txtDateAdded.Text = Order.DateAdded.ToString();
            txtCost.Text = Order.Cost.ToString();
            chkConfirm.Checked = Order.Confirm;



        }
        else
        {
            lblDoesNotExist.Visible = true;
        }

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}


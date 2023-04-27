using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
                txtOrderId.ReadOnly = true;
                btnFind.Visible = false;
            }
        }
    }

    void DisplayOrder()
    {
        clsOrder Order = new clsOrder();

        Boolean Found = false;
        OrderId = Convert.ToInt32(OrderId);
        Found = Order.Find(OrderId);
        if (Found == true)
        {
            txtOrderId.Text = OrderId.ToString();
            txtOrderName.Text = Order.OrderName;
            txtOrderDate.Text = Order.OrderDate.ToString(); 
            txtOrderQuantity.Text = Order.OrderQuantity;
            txtOrderCost.Text = Order.OrderCost;
            chkOrderConfirm.Checked = Order.OrderConfirm;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder Order = new clsOrder();
        string OrderName = txtOrderName.Text;
        string OrderDate = txtOrderDate.Text;
        string OrderQuantity = txtOrderQuantity.Text;
        string OrderCost = txtOrderCost.Text;
        string OrderConfirm = chkOrderConfirm.Checked.ToString();
        string Error = "";
        Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
        if (Error == "")
        {
            Order.OrderId = OrderId;
            Order.OrderName = OrderName;
            Order.OrderDate = Convert.ToDateTime(OrderDate);
            Order.OrderQuantity = OrderQuantity;
            Order.OrderCost = OrderCost;
            Order.OrderConfirm = Convert.ToBoolean(OrderConfirm);
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderId == -1)
            {
                OrderList.ThisOrder = Order;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = Order;
                OrderList.Update();
            }

            Response.Redirect("OrderList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblDoesNotExist.Text = "";
        clsOrder Order = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        try
        {
            OrderId = Convert.ToInt32(txtOrderId.Text);
            Found = Order.Find(OrderId);
            if (Found == true)
            {
                txtOrderName.Text = Order.OrderName;
                txtOrderDate.Text = Order.OrderDate.ToString();
                txtOrderQuantity.Text = Order.OrderQuantity;
                txtOrderCost.Text = Order.OrderCost;
                chkOrderConfirm.Checked = Order.OrderConfirm;

            }
            else
            {
                lblDoesNotExist.Text = "The Order Id Entered Does Not Exist";
            }
        }
        catch
        {
            lblDoesNotExist.Text = "The Order Id Must Be An Integer";
        }


    }




    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtOrderName.Text = "";
        txtOrderDate.Text = "";
        txtOrderQuantity.Text = "";
        txtOrderCost.Text = "";
        chkOrderConfirm.Checked = false;
    }
}
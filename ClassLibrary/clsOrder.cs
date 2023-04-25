using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool orderConfirm;

        public int OrderId { get; set; }
        public int OrderID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
        public object OrderNo { get; set; }
        public int OrdersNo { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal OrderCost { get; set; }
        public int OrdersID { get; set; }
        public string OrderName { get; set; }
        public string Confirm { get; set; }
        public string OrderConfirm { get; set; }

        public bool Find(int orderID)
        {
            return true;
        }
    }
}
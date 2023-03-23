using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool orderConfirm;

        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderStatus { get; set; }
    }
}
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderId = 10;
            TestItem.DateAdded = DateTime.Now.AddYears(-18).Date;
            TestItem.Name = "Furniture";
            TestItem.Quantity = "124";
            TestItem.Cost = "400";
            TestItem.Confirm = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderId = 10;
            TestOrder.DateAdded = DateTime.Now.AddYears(-18).Date;
            TestOrder.Name = "Furniture";
            TestOrder.Quantity = "124";
            TestOrder.Cost = "400";
            TestOrder.Confirm = true;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrdertCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder.TestItem = new clsOrder();
            TestOrder.OrderId = 10;
            TestOrder.DateAdded = DateTime.Now.AddYears(-18).Date;
            TestOrder.Name = "Furniture";
            TestOrder.Quantity = "124";
            TestOrder.Cost = "400";
            TestOrder.Confirm = true;
            TestList.Add(TestOrder);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.OrderId = 10;
            TestOrder.DateAdded = DateTime.Now.AddYears(-18).Date;
            TestOrder.Name = "Furniture";
            TestOrder.Quantity = "124";
            TestOrder.Cost = "50";
            TestOrder.Confirm = true;
            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsTestOrder();
            Int32 PrimaryKey = 0;
            TestOrder.Confirm = true;
            TestOrder.Name = "Furniture";
            TestOrder.DateAdded = DateTime.Now.Date.AddYears(-18);
            TestOrder.Quantity = "124";
            TestOrder.Cost = "350";
            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            TestOrder.Confirm = false;
            TestOrder.Name = "Furniture";
            TestOrder.DateAdded = DateTime.Now.Date.AddYears(-20);
            TestOrder.Quantity = "25";
            TestOrder.Cost = "15";
            AllOrders.ThisOrder = TestOrder;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.OrderId = 1;
            TestOrder.Confirm = true;
            TestOrder.Name = "Furniture";
            TestOrder.DateAdded = DateTime.Now.Date.AddYears(-18);
            TestOrder.Quantity = "20";
            TestOrder.Cost = "15";
            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByName("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByName("THIS IS NOT A NAME");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByName("Filter");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderId != 25)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderId != 26)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }








    }
}

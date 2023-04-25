using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
	[TestClass]
	public class tstorder
	{
		public object Order { get; private set; }
		public object OrderID { get; private set; }

		[TestMethod]
		public void InstanceOk()
		{
			//Create an instance of the class we want to create
			clsOrder AnOrder = new clsOrder();
			//test to see that it exits
			Assert.IsNotNull(AnOrder);
		}
		
		[TestMethod]
		public void OrderIdOK()
		{
			clsOrder Order = new clsOrder();
			Int32 TestData = 232456;
			Order.OrderId = TestData;
			Assert.AreEqual(Order.OrderId, TestData);
		}

		[TestMethod]
		public void OrderNameOK()
		{
			clsOrder Order = new clsOrder();
			string Testdata = "Furniture";
			Order.OrderName = Testdata;
			Assert.AreEqual(Order.OrderName, Testdata);
		}
		
		[TestMethod]
		public void OrderDateOK()
		{
			clsOrder Order = new clsOrder();
			DateTime TestData = DateTime.Now.Date;
			Order.OrderDate = TestData;
			Assert.AreEqual(Order.OrderDate, TestData);
		}
		[TestMethod]
		public void OrderConfirmOK()
		{
			clsOrder Order = new clsOrder();
			Boolean TestData = true;
			Order.orderConfirm = TestData;
			Assert.AreEqual(Order.orderConfirm, TestData);
		}
		[TestMethod]
		public void OrderQuantityOk()
		{

			clsOrder Order = new clsOrder();
			int TestData = 100;
			Order.OrderQuantity = TestData;
			Assert.AreEqual(Order.OrderQuantity, TestData);

		}
		[TestMethod]
		public void OrderCostOk()
		{
			clsOrder Order = new clsOrder();
			decimal TestData = 350;
			Order.OrderCost = TestData;
			Assert.AreEqual(Order.OrderCost, TestData);

		}
		[TestMethod]
		public void OrderStatusOK()
		{
			clsOrder Order = new clsOrder();
			Boolean TestData = true;
			Order.OrderStatus = TestData;
			Assert.AreEqual(Order.OrderStatus, TestData);

		}
		
		[TestMethod]
		public void FinfMethodOk()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Int32 OrderID = 1;

			Found = Order.Find(OrderID);
			Assert.IsTrue(Found);
		}
		[TestMethod]
		public void TestOrderIDFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderID = 21;
			Found = Order.Find(OrderID);
			if (Order.OrderID != 21)
			{
				OK = false;
			}
			Assert.IsTrue(OK);

		}

		[TestMethod]
		public void TestOrderNameFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderID = 21;
			Found = Order.Find(OrderID);
			if (Order.OrderName != "Furniture")
			{
				OK = false;
			}
			Assert.IsTrue(OK);
		}

		[TestMethod]
		public void TestOrderDateFound()
		{
			clsOrder AnOrder = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderNo = 21;
			Found = AnOrder.Find(OrderNo);
			if (AnOrder.DateAdded != Convert.ToDateTime("24/02/2023"))
			{
				OK = false;
			}

			Assert.IsTrue(OK);
		}
		[TestMethod]
		public void TestConfirmFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderID = 1;
			Found = Order.Find(OrderID);
			if (Order.orderConfirm != true)
			{
				OK = false;
			}
			Assert.IsTrue(OK);

		}
		[TestMethod]
		public void TestQuantityFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderID = 1;
			Found = Order.Find(OrderID);
			if (Order.OrderConfirm != "5")
			{
				OK = false;
			}
			Assert.IsTrue(OK);

		}


		[TestMethod]
		public void TestOrderCostFound()

		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderID = 21;
			Found = Order.Find(OrderID);
			if (Order.OrderCost != 1025)
			{
				OK = false;
			}
			Assert.IsTrue(OK);

		}
		[TestMethod]
		public void TestOrderStatusFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderID = 21;
			Found = Order.Find(OrderID);
			if (Order.OrderStatus != true)
			{
				OK = false;
			}
			Assert.IsTrue(OK);

		}

	}

}



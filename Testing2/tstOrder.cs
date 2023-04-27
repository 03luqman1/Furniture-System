using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
	[TestClass]
	public class tstorder
	{
		public object Order { get; private set; }
		public object OrderId { get; private set; }
        public bool Dispatch { get; private set; }

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
			Order.OrderConfirm = TestData;
			Assert.AreEqual(Order.OrderConfirm, TestData);
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
		public void FindMethodOk()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Int32 OrderId = 1;

			Found = Order.Find(OrderId);
			Assert.IsTrue(Found);
		}
		[TestMethod]
		public void TestOrderIdFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderId = 21;
			Found = Order.Find(OrderId);
			if (Order.OrderId != 21)
			{
				OK = false;
			}
			Assert.IsTrue(Found);

		}

		[TestMethod]
		public void TestOrderNameFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderId = 21;
			Found = Order.Find(OrderId);
			if (Order.OrderName != "Furniture")
			{
				OK = false;
			}
			Assert.IsTrue(Found);
		}

		[TestMethod]
		public void TestOrderDateFound()
		{
			clsOrder AnOrder = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderId = 21;
			Found = AnOrder.Find(OrderId);
			if (AnOrder.OrderDate != Convert.ToDateTime("24/02/2023"))
			{
				OK = false;
			}

			Assert.IsTrue(Found);
		}
		[TestMethod]
		public void TestOrderConfirmFound()
		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderId = 1;
			Found = Order.Find(OrderId);
			if (Order.OrderConfirm != true)
			{
				OK = false;
			}
			Assert.IsTrue(Found);

		}
		[TestMethod]
		public void TestOrderQuantityFound()
		{
			{
				clsOrder Order = new clsOrder();
				Boolean Found = false;
				Boolean OK = true;
				Int32 OrderId = 21;
				Found = Order.Find(OrderId);
				if (Order.OrderQuantity != 5)
				{
					OK = false;
				}
				Assert.IsTrue(Found);

			}
		}

		[TestMethod]
		public void TestOrderCostFound()

		{
			clsOrder Order = new clsOrder();
			Boolean Found = false;
			Boolean OK = true;
			Int32 OrderId = 21;
			Found = Order.Find(OrderId);
			if (Order.OrderCost != 1025)
			{
				OK = false;
			}
			Assert.IsTrue(Found);

		}
		
		
		

	}

}



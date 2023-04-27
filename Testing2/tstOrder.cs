using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
	[TestClass]
	public class tstorder
	{

		string OrderName = "Furniture";
		string OrderDate = "12/03/2000";
		string OrderQuantity = "2";
		string OrderCost = "400";
		string OrderConfirm = "true";

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
			string Testdata = "Bed";
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
		public void OrderQuantityOK()
		{
			clsOrder Order = new clsOrder();
			string TestData = "25";
			Order.OrderQuantity = TestData;
			Assert.AreEqual(Order.OrderQuantity, TestData);

		}
	}
	public void OrderCostOK()
	{
		clsOrder Order = new clsOrder();
		string TestData = 250;
		Order.OrderCost = TestData;
		Assert.AreEqual(Order.OrderCost, TestData);
	}


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

			Assert.IsTrue(OK);

		}

		[TestMethod]
		public void ValidMethodOK()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfim);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameMinMinusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameMin()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "a";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameMinPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "aa";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameMaxMinusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "";
			OrderName = OrderName.PadRight(49, 'a');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "";
			OrderName = OrderName.PadRight(50, 'a');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameMaxPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "";
			OrderName = OrderName.PadRight(51, 'a');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameExtremeMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "";
			OrderName = OrderName.PadRight(1000, 'a');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderNameMid()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderName = "";
			OrderName = OrderName.PadRight(25, 'a');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostExtremeMin()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostlMinMinusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "a@";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostMin()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "a@b";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostMinPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "a@bc";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostMaxMinusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "";
			OrderCost = OrderCost.PadRight(49, '@');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "";
			OrderCost = OrderCost.PadRight(50, '@');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostMaxPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "";
			OrderCost = OrderCost.PadRight(51, '@');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostExtremeMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "";
			OrderCost = OrderCost.PadRight(1000, '@');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostMid()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "";
			OrderCost = OrderCost.PadRight(25, '@');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderCostSymbol()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderCost = "";
			OrderCost = OrderCost.PadRight(25, 'a');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderQuantityExtremeMin()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void OrderQuantityMinMinusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "12";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void OrderQuantityMin()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "123";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderQuantityrMinPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "1234";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void OrderQuantityrMaxMinusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "";
			OrderQuantity = OrderQuantity.PadRight(14, '1');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void OrderQuantityMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "";
			OrderQuantity = OrderQuantity.PadRight(15, '1');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderQuantityMaxPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "";
			OrderQuantity = OrderQuantity.PadRight(16, '1');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}

			Assert.IsTrue(Found);


		[TestMethod]
		public void OrderQuantityrExtremeMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "";
			OrderQuantity = OrderQuantity.PadRight(100, '1');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderQuantityMid()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "";
			OrderQuantity = OrderQuantity.PadRight(10, '1');
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		
		
		

		[TestMethod]
		public void OrderQuantityIsNumeric()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderQuantity = "134";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderDatetExtremeMin()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddYears(-1000);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void OrderDateMinMinusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddDays(-1).AddYears(-150);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderDateMin()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddYears(-150);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void OrderDateMinPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddDays(1).AddYears(-150);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderDateMaxMinusOne()
		{
			clsCustomer Customer = new clsCustomer();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddDays(-1).AddYears(-18);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void OrderDateMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddYears(-18);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}
		[TestMethod]
		public void OrderDateMaxPlusOne()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddDays(1).AddYears(-18);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}

		[TestMethod]
		public void OrderDateExtremeMax()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddYears(1000);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderDateMid()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			TestDate = TestDate.AddYears(-66);
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreEqual(Error, "");
		}

		[TestMethod]
		public void OrderDateToday()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			DateTime TestDate;
			TestDate = DateTime.Now.Date;
			string OrderDate = TestDate.ToString();
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
		[TestMethod]
		public void OrderDateInvalidData()
		{
			clsOrder Order = new clsOrder();
			String Error = "";
			string OrderDate = "This is not a date!";
			Error = Order.Valid(OrderName, OrderDate, OrderQuantity, OrderCost, OrderConfirm);
			Assert.AreNotEqual(Error, "");
		}
	}

}



using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
	[TestClass]
	public class tstorder
	{

		string Name = "Furniture";
		string DateAdded = "12/03/2000";
		string Quantity = "2";
		string Cost = "400";
		string Confirm = "true";

		
		[TestMethod]
		public void InstanceOk()
		{
		
			clsOrder AnOrder = new clsOrder();
			
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
		public void NameOK()
		{
			clsOrder Order = new clsOrder();
			string Testdata = "Bed";
			Order.Name = Testdata;
			Assert.AreEqual(Order.Name, Testdata);
		}

		[TestMethod]
		public void DateAddedOK()
		{
			clsOrder Order = new clsOrder();
			DateTime TestData = DateTime.Now.Date;
			Order.DateAdded = TestData;
			Assert.AreEqual(Order.DateAdded, TestData);
		}
		[TestMethod]
		public void ConfirmOK()
		{
			clsOrder Order = new clsOrder();
			Boolean TestData = true;
			Order.Confirm = TestData;
			Assert.AreEqual(Order.Confirm, TestData);
		}
		[TestMethod]
		public void QuantityOK()
		{
			clsOrder Order = new clsOrder();
			int TestData = "25";
			Order.Quantity = TestData;
			Assert.AreEqual(Order.Quantity, TestData);

		}
	
       [TestMethod]
      public void CostOk()
{
	   clsOrder Order = new clsOrder();
	   decimal TestData = 350;
	  Order.Cost = TestData;
	   Assert.AreEqual(Order.Cost, TestData);

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
	if (Order.Name != "Furniture")
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
	if (AnOrder.DateAdded != Convert.ToDateTime("24/02/2023"))
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
	if (Order.Confirm != true)
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
		if (Order.Quantity != 5)
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
	if (Order.Cost != 1025)
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
	Error = Order.Valid(Name, DateAdded,Quantity, Cost, Confirm);
	Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderNameMinMinusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderNameMin()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "a";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderNameMinPlusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "aa";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderNameMaxMinusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "";
			Name = Name.PadRight(49, 'a');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderNameMax()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "";
			Name = Name.PadRight(50, 'a');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderNameMaxPlusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "";
			Name = Name.PadRight(51, 'a');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderNameExtremeMax()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "";
			Name = Name.PadRight(1000, 'a');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderNameMid()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Name = "";
			Name = Name.PadRight(25, 'a');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderCostExtremeMin()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderCostlMinMinusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "a@";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderCostMin()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "a@b";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderCostMinPlusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "a@bc";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderCostMaxMinusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "";
			Cost = Cost.PadRight(49, '@');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderCostMax()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "";
			Cost = Cost.PadRight(50, '@');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderCostMaxPlusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "";
			Cost = Cost.PadRight(51, '@');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderCostExtremeMax()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "";
			Cost = Cost.PadRight(1000, '@');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderCostMid()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "";
			Cost = Cost.PadRight(25, '@');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderCostSymbol()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Cost = "";
			Cost = Cost.PadRight(25, 'a');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderQuantityExtremeMin()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void OrderQuantityMinMinusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "12";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void OrderQuantityMin()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "123";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderQuantityrMinPlusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "1234";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}

[TestMethod]
public void OrderQuantityrMaxMinusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "";
			Quantity = Quantity.PadRight(14, '1');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}

[TestMethod]
public void OrderQuantityMax()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "";
			Quantity = Quantity.PadRight(15, '1');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderQuantityMaxPlusOne()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "";
			Quantity = Quantity.PadRight(16, '1');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}

//Assert.IsTrue(Found);


[TestMethod]
public void OrderQuantityrExtremeMax()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "";
			Quantity = Quantity.PadRight(100, '1');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderQuantityMid()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "";
			Quantity = Quantity.PadRight(10, '1');
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}




[TestMethod]
public void OrderQuantityIsNumeric()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string Quantity = "134";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			//Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
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
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreEqual(Error, "");
}

[TestMethod]
public void OrderDateToday()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	DateTime TestDate;
	TestDate = DateTime.Now.Date;
	string DateAdded = TestDate.ToString();
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderDateInvalidData()
{
	clsOrder Order = new clsOrder();
	String Error = "";
	string DateAdded = "This is not a date!";
			Error = Order.Valid(Name, DateAdded, Quantity, Cost, Confirm);
			Assert.AreNotEqual(Error, "");
}
	}

}



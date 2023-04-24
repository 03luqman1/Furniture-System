using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
	[TestClass]
	public class tstorder
	{
		[TestMethod]
		public void InstanceOk()
		{
			//Create an instance of the class we want to create
			clsOrder AnOrder = new clsOrder();
			//test to see that it exits
			Assert.IsNotNull(AnOrder);
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
		public void OrderIdOK()
		{
			clsOrder Order = new clsOrder();
			Int32 TestData = 232456;
			Order.OrderId = TestData;
			Assert.AreEqual(Order.OrderId, TestData);
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
		public void OrderDateOK()
		{
			clsOrder Order = new clsOrder();
			DateTime TestData = DateTime.Now.Date;
			Order.OrderDate = TestData;
			Assert.AreEqual(Order.OrderDate, TestData);
		}
		[TestMethod]
		public void OrderStatusOK()
		{
			clsOrder Order = new clsOrder();
			Boolean TestData = true;
			Order.OrderStatus = TestData;
			Assert.AreEqual(Order.OrderStatus, TestData);

		}


	}


}






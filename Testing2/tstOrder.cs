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
	}

    
}



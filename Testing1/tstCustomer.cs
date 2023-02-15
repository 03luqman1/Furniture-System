using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK(){
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
    }
}

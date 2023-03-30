using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create the an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see it exists
            Assert.IsNotNull(AnSupplier);
        }
    }

    class clsSupplier
    {
    }
}

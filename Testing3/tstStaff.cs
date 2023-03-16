using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create the an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //test to see it exists
            Assert.IsNotNull(AnEmployee);
        }
    }
}

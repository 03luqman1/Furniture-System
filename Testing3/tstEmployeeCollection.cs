using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstEmployeeCollection
    {
        public void InstanceOK()
        {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            Assert.IsNotNull(AllEmployees);
        }
    }
}

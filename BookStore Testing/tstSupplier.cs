using BookStoreClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStore_Testing
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instace of the class
            clsSupplier ASupplier = new clsSupplier();
            //test to see if it exists
            Assert.IsNotNull(ASupplier);
        }
    }

}

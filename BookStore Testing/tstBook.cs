using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStore_Testing
{
    [TestClass]
    public class tstBook
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //test to see that it exists
            Assert.IsNotNull(ABook);
        }
    }
}

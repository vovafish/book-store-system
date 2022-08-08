using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStore_Testing.Deliverytesting
{
    [TestClass]
    public class tstDelivery
    {
        [TestMethod]
        public void TestMethod1()
        {

           
                //create an instance of the class we want to create
                clsDelivery ADelivery = new clsDelivery();
                //test to see that it exists
                Assert.IsNotNull(ADelivery);
            
        }
    }
}

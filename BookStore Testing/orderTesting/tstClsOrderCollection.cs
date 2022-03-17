using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStoreClasses;



namespace BookStoreClasses
{
    [TestClass]
    class clsOrderCollection
    {
        public int Order { get; private set; }

        public void InstanceOK()
        {
            //creates instance of class 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see if its there 
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            Int32 SomeOrder = 1;

            AllOrders.Order = SomeOrder;

            Assert.AreEqual(AllOrders.Order, SomeOrder);
        }

        public void AllOrdersOK()
        {

        }
       
    }
}

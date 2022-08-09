using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStore_Testing.DeliveryTesting
{
    [TestClass]
    public class tstDelivery
    {
       
        //creating an instance of the class we want to create for all test
        clsDelivery ADelivery = new clsDelivery();
        //Test System
        [TestMethod]
        public void DeliveryOK()
        {
            string Somedelivery = "";
            //Assign the data to the property
            ADelivery.DeliveryStatus = Somedelivery;
            //test to see that it exists
            Assert.IsNotNull(ADelivery);
        }
        [TestMethod]
        public void ActiveOK()
        {

            Boolean TestData;
            TestData = true;
            ADelivery.Active = TestData;
            Assert.AreEqual(TestData, ADelivery.Active);

        }
        [TestMethod]
        public void Delivery_statusOK()
        {

            //Create a test data to be assigned to the properties
            string Name = "pending";
            //assigning  the data to the property
            ADelivery.Delivery_status = Name;
            //testing to check  that the 2 values are equal
            Assert.AreEqual(Name, ADelivery.Delivery_status);
        }
        

        [TestMethod]
        public void Delivery_IDOK()
        {

            //Create  the test data to be assigned to the properties
            Int32 TestData = 1;
            //assign the data to the property
            ADelivery.Delivery_ID = TestData;
            //test to check  that the 2 values are equal
            Assert.AreEqual(TestData, ADelivery.Delivery_ID);
        }

        [TestMethod]
        public void FK_Order_IDOK()
        {

            //Create the test data to be assigned to the properties
            Int32 TestData = 12;
            //assigning  the data to the property
            ADelivery.FK_Order_ID = TestData;
            //test to  see that the 2 values are equal
            Assert.AreEqual(TestData, ADelivery.FK_Order_ID);
        }

        [TestMethod]
        public void Delivery_DateOK()
        {

            //Create the test data to be assigned to the properties
            DateTime TestData = DateTime.Now.Date;
            //assigning  the data to the property
            ADelivery.Delivery_date = TestData;
            //testto see that the 2 values are the same
            Assert.AreEqual(TestData, ADelivery.Delivery_date);
        }

        [TestMethod]
        public void FoundOK()
        {

            
           Int32 TestData;
           TestData = 1;
           Boolean found;
           found = ADelivery.find(TestData);
           Assert.IsTrue(found);
        }


        [TestMethod]
        public void ValidMethodOK()
        {

            //creating a string varible to store the result of the validation
            string Error = "";
            //creating some test data to test the method
            string TestData = "pending";
            //invoking the method
            Error = ADelivery.Valid(TestData);
            //test to see that the result is ok(no error returned)
            Assert.AreEqual(Error, "");


        }

        //Field Testing Below
        //Delivery_ID Tests

        [TestMethod]
        //this test covers both extreme and -1 min tests
        public void NameMinMinus1()
        {
            //testing the minimum for the field Staff_Name -1
            string TestData;
            TestData = "";
            string Error;
            Error = ADelivery.Valid(TestData);
            Assert.AreNotEqual(Error, "");//AreNotEqual means if Fails the ValidMethod then the test passes as the Vaild Method has worked


        }
        [TestMethod]
        //min test
        public void NameMin()
        {
            //testing the minimum for the field Staff_Name
            string TestData;
            TestData = "A";
            string Error;
            Error = ADelivery.Valid(TestData);
            Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
        }
        [TestMethod]
        //Max -1 Test
        public void NameMaxMinus1()
        {
            string TestData = "";
            TestData = TestData.PadRight(19, 'A');
            string Error;
            Error = ADelivery.Valid(TestData);
            Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
        }
        [TestMethod]
        //Max Test
        public void NameMax()
        {
            string TestData = "";
            TestData = TestData.PadRight(20, 'A');
            string Error;
            Error = ADelivery.Valid(TestData);
            Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
        }

        [TestMethod]
        //Max +1 Test
        public void NameMaxPlus1()
        {
            string TestData = "";
            TestData = TestData.PadRight(21, 'A');
            string Error;
            Error = ADelivery.Valid(TestData);
            Assert.AreNotEqual(Error, "");//AreNotEqual means if Fails the ValidMethod then the test passes as the Vaild Method has worked


        }
        [TestMethod]
        //Mid Test
        public void NameMid()
        {
            string TestData = "";
            TestData = TestData.PadRight(10, 'A');
            string Error;
            Error = ADelivery.Valid(TestData);
            Assert.AreEqual(Error, "");//AreEqual means if passes the Valid method then the test passes
        }
        [TestMethod]
        //Max Extreme Test
        public void NameMaxExtreme()
        {
            string TestData = "";
            TestData = TestData.PadRight(500, 'A');
            string Error;
            Error = ADelivery.Valid(TestData);
            Assert.AreNotEqual(Error, "");//AreNotEqual means if Fails the ValidMethod then the test passes as the Vaild Method has worked


        }

    }
}

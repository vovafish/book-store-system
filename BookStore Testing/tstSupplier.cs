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

        [TestMethod]
        public void SupplierNoOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //declare test data variable
            Int32 TestData;
            //create test data
            TestData = 5;
            //assign test data to property
            ASupplier.SupplierNo = TestData;
            //test to see if values match
            Assert.AreEqual(TestData, ASupplier.SupplierNo);
        }

            [TestMethod]
        public void NameOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //declare test data variable
            string TestData;
            //create test data
            TestData = "Book Depot";
            //assign test data to property
            ASupplier.Name = TestData;
            //test to see if values match
            Assert.AreEqual(TestData, ASupplier.Name);
        }

        [TestMethod]
        public void AddressOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //declare test data variable
            string TestData;
            //create test data
            TestData = "67 Front Street, North Thorold, Ontario";
            //assign test data to property
            ASupplier.Address = TestData;
            //test to see if values match
            Assert.AreEqual(TestData, ASupplier.Address);
        }

        [TestMethod]
        public void PostcodeOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //declare test data variable
            string TestData;
            //create test data
            TestData = "L2V 1X3";
            //assign test data to property
            ASupplier.Postcode = TestData;
            //test to see if values match
            Assert.AreEqual(TestData, ASupplier.Postcode);
        }

        [TestMethod]
        public void CostOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //declare test data variable
            double TestData;
            //create test data
            TestData = 5.23;
            //assign test data to property
            ASupplier.Cost = TestData;
            //test to see if values match
            Assert.AreEqual(TestData, ASupplier.Cost);
        }

        [TestMethod]
        public void DescriptionOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //declare test data variable
            string TestData;
            //create test data
            TestData = "Closed to the public, Wholesalers by appointment only. Book Depot has been in the wholesale bargain book business for over 35 years, saving organizations time and money by offering the largest selection of high-margin books.";
            //assign test data to property
            ASupplier.Description = TestData;
            //test to see if values match
            Assert.AreEqual(TestData, ASupplier.Description);
        }

        [TestMethod]
        public void PhoneNumberOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //declare test data variable
            string TestData;
            //create test data
            TestData = "07897657886";
            //assign test data to property
            ASupplier.PhoneNumber = TestData;
            //test to see if values match
            Assert.AreEqual(TestData, ASupplier.PhoneNumber);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to for the validation results
            Boolean Found = false;
            //create test data
            Int32 SupplierNo = 5;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void SupplierNoFound()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the validation results
            Boolean Found = false;
            //boolean variable to record is data is OK
            Boolean OK = true;
            //create test data
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the supplier no
            if (ASupplier.SupplierNo != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NameFound()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the validation results
            Boolean Found = false;
            //boolean variable to record is data is OK
            Boolean OK = true;
            //create test data
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the supplier no
            if (ASupplier.Name != Convert.ToString("Book Depot"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressFound()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the validation results
            Boolean Found = false;
            //boolean variable to record is data is OK
            Boolean OK = true;
            //create test data
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the supplier no
            if (ASupplier.Address != Convert.ToString("1 Book Lane, Booksford"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostcodeFound()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the validation results
            Boolean Found = false;
            //boolean variable to record is data is OK
            Boolean OK = true;
            //create test data
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the supplier no
            if (ASupplier.Postcode != Convert.ToString("BK120PG"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DescriptionFound()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the validation results
            Boolean Found = false;
            //boolean variable to record is data is OK
            Boolean OK = true;
            //create test data
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the supplier no
            if (ASupplier.Description != Convert.ToString("The number 1 bookshop in bookfords"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNumberFound()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the validation results
            Boolean Found = false;
            //boolean variable to record is data is OK
            Boolean OK = true;
            //create test data
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the supplier no
            if (ASupplier.PhoneNumber != Convert.ToString("07453457689"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CostFound()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the validation results
            Boolean Found = false;
            //boolean variable to record is data is OK
            Boolean OK = true;
            //create test data
            Int32 SupplierNo = 1;
            //invoke the method
            Found = ASupplier.Find(SupplierNo);
            //check the supplier no
            if (ASupplier.Cost != Convert.ToDouble(111))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}



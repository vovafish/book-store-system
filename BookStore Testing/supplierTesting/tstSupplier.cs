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

        [TestMethod]
        public void ValidMethodOk()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        string Name = "Book Depot";
        string Address = "1 Book Lane, Booksford";
        string Postcode = "BK148PG";
        string PhoneNumber = "07849302192";
        string Cost = "5.23";
        string Description = "The best book store";
        


        [TestMethod]
        public void NameMinMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = ""; // this should trigger and error
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = "a";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = "aa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = "0123456789012345678";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = "01234567890123456789";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = "012345678901234567890";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMidRange()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = "0123456789";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Name = "";
            Name = Name.PadRight(200, 'a'); //this should fail
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = ""; // this should trigger and error
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description); ;
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "aa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "a";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "KN6HLesHY9ILznPnxzRnrbBuGyfhKm6iI4NLOGp2qXTAfqNtK";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "KN6HLesHY9ILznPnxzRnrbBuGyfhKm6iI4NLOGp2qXTAfqNtKr";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "KN6HLesHY9ILznPnxzRnrbBuGyfhKm6iI4NLOGp2qXTAfqNtKre";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMidRange()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "khBR2TMDuqIX3deZah9VnSCFa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Address = "";
            Address = Address.PadRight(500, 'a'); //this should fail
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = ""; // this should trigger and error
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = "aa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = "a";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = "aaaaaa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = "aaaaaaa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = "aaaaaaaa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMidRange()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = "aaa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Postcode = "";
            Postcode = Postcode.PadRight(20, 'a'); //this should fail
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = ""; // this should trigger and error
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = "aa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = "a";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = "";
            Description = Description.PadRight(199, 'a');
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = "";
            Description = Description.PadRight(200, 'a');
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = "";
            Description = Description.PadRight(201, 'a');
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMidRange()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = "aaa";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string Description = "";
            Description = Description.PadRight(700, 'a'); //this should fail
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = ""; // this should trigger and error
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = "123456789012";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = "12345678901";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = "1234567890";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = "12345678901";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = "123456789012";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMidRange()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = "12345678901";
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //create test data
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(20, 'a'); //this should fail
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMinMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = -1;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostNumberMinPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = 1;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostNumberMinBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = 0;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostNumberMaxMinusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = 999999;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostNumberMaxBoundary()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = 1000000;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostNumberMaxPlusOne()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = 1000001;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostNumberMidRange()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = 500000;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostNumberExtremeMax()
        {
            //instance of the class
            clsSupplier ASupplier = new clsSupplier();
            //create a string variable to store the result of validation
            string Error = "";
            //variable for test data
            Double TestData;
            //create test data
            TestData = 2000000;
            //set test data to the cost
            string Cost = TestData.ToString();
            //assign test data to property
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //test to see if found
            Assert.AreNotEqual(Error, "");
        }
    }
}




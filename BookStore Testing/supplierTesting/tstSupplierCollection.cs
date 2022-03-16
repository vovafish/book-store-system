using BookStoreClasses;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStore_Testing.supplierTesting
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see if it exists
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create a list of data to test
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierNo = 1;
            TestItem.Name = "Book Depot";
            TestItem.Address = "1 Book Street, Booksford";
            TestItem.Postcode = "BK141PG";
            TestItem.Cost = 5.23;
            TestItem.Description = "This is the best book supplier";
            TestItem.PhoneNumber = "0748594386";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void CountOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //int 32 test count
            Int32 TestCount = 0;
            //assign the data to the proeprty
            AllSuppliers.Count = TestCount;
            //test to see if it exists
            Assert.AreEqual(AllSuppliers, TestCount);
        }

        [TestMethod]
        public void ThisSupplierOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestSupplier = new clsSupplier();
            //set its properties
            TestSupplier.SupplierNo = 1;
            TestSupplier.Name = "Book Depot";
            TestSupplier.Address = "1 Book Street, Booksford";
            TestSupplier.Postcode = "BK141PG";
            TestSupplier.Cost = 5.23;
            TestSupplier.Description = "This is the best book supplier";
            TestSupplier.PhoneNumber = "0748594386";
            //assign data to the proeprty
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create a list of data to test
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add item to the list
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierNo = 1;
            TestItem.Name = "Book Depot";
            TestItem.Address = "1 Book Street, Booksford";
            TestItem.Postcode = "BK141PG";
            TestItem.Cost = 5.23;
            TestItem.Description = "This is the best book supplier";
            TestItem.PhoneNumber = "0748594386";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
    }
}

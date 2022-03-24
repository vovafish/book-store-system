using BookStoreClasses;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BookStore_Testing
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

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestSupplier = new clsSupplier();
            //var to store the pk 
            Int32 PrimaryKey = 0;
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
            //add the record 
            PrimaryKey = AllSuppliers.Add();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestSupplier = new clsSupplier();
            //var to store the pk 
            Int32 PrimaryKey = 0;
            //set its properties
            TestSupplier.SupplierNo = 1;
            TestSupplier.Name = "Book Depot";
            TestSupplier.Address = "1 Book Street, Booksford";
            TestSupplier.Postcode = "BK141PG";
            TestSupplier.Cost = 5.23;
            TestSupplier.Description = "This is the best book supplier";
            TestSupplier.PhoneNumber = "0748594386";
            //set ThisAddress to the test data
            AllSuppliers.ThisSupplier = TestSupplier;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //Set the PK of the record
            TestSupplier.SupplierNo = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //delete the record
            AllSuppliers.Delete();
            //now find the record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestSupplier = new clsSupplier();
            //var to store the pk 
            Int32 PrimaryKey = 0;
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
            //add the record 
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data 
            TestSupplier.SupplierNo = PrimaryKey;
            //modify the test data
            TestSupplier.SupplierNo = 2;
            TestSupplier.Name = "Book Life";
            TestSupplier.Address = "1 Book Land, Booksford";
            TestSupplier.Postcode = "BK141TT";
            TestSupplier.Cost = 4.45;
            TestSupplier.Description = "This is the best book supplier ever";
            TestSupplier.PhoneNumber = "07567483942";
            //set the record based on the new test data
            AllSuppliers.ThisSupplier = TestSupplier;
            //update the record
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see thissupplier matches the test data 
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ReportByNameOk()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create an instance of the giltered data 
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a blank string 
            FilteredSuppliers.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);

        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {    
            //create an instance of the giltered data 
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a blank string 
            FilteredSuppliers.ReportByName("xxxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredSuppliers.Count);

        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the giltered data 
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Name that doesn't exist
            FilteredSuppliers.ReportByName("All Books");
            //check that the correct nyumber of records are found
            if (FilteredSuppliers.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredSuppliers.SupplierList[0].SupplierNo != 52)
                {
                    OK = false;
                }
                //check that the first record is 37
                if (FilteredSuppliers.SupplierList[1].SupplierNo != 54)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see that there are no records
            Assert.IsTrue(OK);

        }
    }
}

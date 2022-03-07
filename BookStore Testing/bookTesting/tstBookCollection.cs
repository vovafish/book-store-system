using BookStoreClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

/* @VR */

namespace BookStore_Testing
{
    [TestClass]
    public class tstBookCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //test to see if it exists
            Assert.IsNotNull(AllBooks);
        }

        [TestMethod]
        public void BookListOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsBook> TestList = new List<clsBook>();
            //add an item to the list
            //create the item of test data
            clsBook TestItem = new clsBook();
            //set its properties
            TestItem.BookId = 1;
            TestItem.Author = "Lee One";
            TestItem.BookPrice = 19.99m;
            TestItem.BookTitle = "Shape of Voice";
            TestItem.Edition = 0;
            TestItem.BookShelfNo = 144.002m;
            TestItem.GenreName = "Drama";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllBooks.BookList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllBooks.BookList, TestList);
        }
        /*
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //craete some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllBooks.Count = SomeCount;
            //test to see that two values are the same
            Assert.AreEqual(AllBooks.Count, SomeCount);
        }
        */
        [TestMethod]
        public void ThisBookPropertyOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //create some test data to assign for the property
            clsBook TestBook = new clsBook();
            //set its properties
            TestBook.BookId = 1;
            TestBook.Author = "Lee One";
            TestBook.BookPrice = 19.99m;
            TestBook.BookTitle = "Shape of Voice";
            TestBook.Edition = 0;
            TestBook.BookShelfNo = 144.002m;
            TestBook.GenreName = "Drama";
            //assign the data to the property
            AllBooks.ThisBook = TestBook;
            //test to see that two values are the same
            Assert.AreEqual(AllBooks.ThisBook, TestBook);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //create some test data to assign for the property
            //in this case the data need to be a list of objects
            List<clsBook> TestList = new List<clsBook>();
            //add an item to the list
            //create the item of test data
            clsBook TestItem = new clsBook();
            //set its properties
            TestItem.BookId = 1;
            TestItem.Author = "Lee One";
            TestItem.BookPrice = 19.99m;
            TestItem.BookTitle = "Shape of Voice";
            TestItem.Edition = 0;
            TestItem.BookShelfNo = 144.002m;
            TestItem.GenreName = "Drama";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllBooks.BookList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllBooks.Count, TestList.Count);
        }
        /*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //test to see that two values are the same
            Assert.AreEqual(AllBooks.Count, 2);
        }
        */
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //create the item of test data
            clsBook TestItem = new clsBook();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.BookId = 1;
            TestItem.Author = "Lee One";
            TestItem.BookPrice = 19.99m;
            TestItem.BookTitle = "Shape of Voice";
            TestItem.Edition = 0;
            TestItem.BookShelfNo = 144.002m;
            TestItem.GenreName = "Drama";
            //set ThisBook to the test data
            AllBooks.ThisBook = TestItem;
            //add the record
            PrimaryKey = AllBooks.Add();
            //set the Primary key of the test data
            TestItem.BookId = PrimaryKey;
            //find the record   
            AllBooks.ThisBook.Find(PrimaryKey);
            //delete the record 
            AllBooks.Delete();
            //now find the record
            Boolean Found = AllBooks.ThisBook.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //create the item of test data
            clsBook TestItem = new clsBook();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.BookId = 1;
            TestItem.Author = "Lee One";
            TestItem.BookPrice = 19.99m;
            TestItem.BookTitle = "Shape of Voice";
            TestItem.Edition = 0;
            TestItem.BookShelfNo = 144.002m;
            TestItem.GenreName = "Drama";
            //set ThisBook to the test data
            AllBooks.ThisBook = TestItem;
            //add the record
            PrimaryKey = AllBooks.Add();
            //set the Primary key of the test data
            TestItem.BookId = PrimaryKey;
            //find the record   
            AllBooks.ThisBook.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsBookCollection AllBooks = new clsBookCollection();
            //create the item of test data
            clsBook TestItem = new clsBook();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
           // TestItem.BookId = 1;
            TestItem.Author = "Lee One";
            TestItem.BookPrice = 19.99m;
            TestItem.BookTitle = "Shape of Voice";
            TestItem.Edition = 0;
            TestItem.BookShelfNo = 144.002m;
            TestItem.GenreName = "Drama";
            //set ThisBook to the test data
            AllBooks.ThisBook = TestItem;
            //add the record
            PrimaryKey = AllBooks.Add();
            //set the Primary key of the test data
            TestItem.BookId = PrimaryKey;
            //modify the test data
            TestItem.Author = "Lee OneChaned";
            TestItem.BookPrice = 3.99m;
            TestItem.BookTitle = "Shape of VoiceChaned";
            TestItem.Edition = 1;
            TestItem.BookShelfNo = 133.002m;
            TestItem.GenreName = "DramaChaned";
            //set the record based on the new test data
            AllBooks.ThisBook = TestItem;
            //update the record   
            AllBooks.Update();
            //find the record 
            AllBooks.ThisBook.Find(PrimaryKey);
            //test to see ThisBook mathces the test data
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }

        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsBookCollection AllBooks = new clsBookCollection();
            //create an instance of the filtered data
            clsBookCollection FilteredBooks = new clsBookCollection();
            //apply a blank string (should return all records)
            FilteredBooks.ReportByTitle("");
            //test to see ThisBook mathces the test data
            Assert.AreEqual(AllBooks.Count, FilteredBooks.Count);
        }

        [TestMethod]
        public void ReportByTitleNoneFound()
        {
            
            //create an instance of the filtered data
            clsBookCollection FilteredBooks = new clsBookCollection();
            //apply a title that doesn't exist
            FilteredBooks.ReportByTitle("ItDoesNotExist");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredBooks.Count);
        }

        [TestMethod]
        public void ReportByTitleTestDataFound()
        {
            //create an instance of the filtered data
            clsBookCollection FilteredBooks = new clsBookCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a title that doesn't exist
            FilteredBooks.ReportByTitle("ItDoesNotExist");
            //check that the correct number of records found
            if (FilteredBooks.Count == 2)
            {
                //check that the first record is ID 11
                if (FilteredBooks.BookList[0].BookId != 11)
                {
                    OK = false;
                }
                //check that the second record is ID 13
                if (FilteredBooks.BookList[1].BookId != 13)
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

using BookStoreClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            //test to see that two values are the same
            Assert.AreEqual(AllBooks.ThisBook, TestItem);
        }
    }
}

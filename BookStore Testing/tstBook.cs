using BookStoreClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

/* THE FILE CREATED BY VLADIMIRS RIBAKOVS */

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

        // Author //

        [TestMethod]
        public void AuthorMinLessOne()
        {
            //instance of the class
            clsBook ABook = new clsBook();
            //declare test data variable
            string TestData;
            //create test data
            TestData = "";
            //create var to hold error msg
            string Error;
            //validate test data and result put in the Error var
            Error = ABook.Valid(TestData);
            //if error not equal to empty string than OK
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMin()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "A";
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMinPlusOne()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "Aa";
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMaxLessOne()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(49, 'A');
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMax()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(50, 'A');
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMaxPlusOne()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(51, 'A');
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMid()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(25, 'A');
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorExtremeMax()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(500, 'A');
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorOK()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "TestAuthor";
            ABook.Author = TestData;
            Assert.AreEqual(TestData, ABook.Author);
        }

        // Author End //

        // Publication Year //

        [TestMethod]
        public void PublicationYearExtremeMin()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = -1000;
            string Error;
            Error = ABook.ValidPubYear(TestData);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PublicationYearMinLessOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1699;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMin()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1700;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMinPlusOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1701;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMaxLessOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 2999;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMax()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 3000;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMaxPlusOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 3001;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMid()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1500;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearExtremeMax()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 10000;
            string Error;

            Error = ABook.ValidPubYear(TestData);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PublicationYearOK()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1998;
            ABook.PublicationYear = TestData;
            Assert.AreEqual(TestData, ABook.PublicationYear);
        }

        // Publication Year End //

        // Edition //

        [TestMethod]
        public void EditionOK()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1;
            ABook.Edition = TestData;
            Assert.AreEqual(TestData, ABook.Edition);
        }

        [TestMethod]
        public void EditionExtremeMin()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = -100;
            string Error;
            Error = ABook.ValidEdition(TestData);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EditionMinLessOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = -1;
            string Error;
            Error = ABook.ValidEdition(TestData);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EditionMin()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 0;
            string Error;

            Error = ABook.ValidEdition(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMinPlusOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1;
            string Error;

            Error = ABook.ValidEdition(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMaxLessOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 0;
            string Error;

            Error = ABook.ValidEdition(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMax()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1;
            string Error;

            Error = ABook.ValidEdition(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMaxPlusOne()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 2;
            string Error;

            Error = ABook.ValidEdition(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EditionMid()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 1;
            string Error;

            Error = ABook.ValidEdition(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionExtremeMax()
        {
            clsBook ABook = new clsBook();
            Int32 TestData;
            TestData = 100;
            string Error;

            Error = ABook.ValidEdition(TestData);
            Assert.AreNotEqual(Error, "");
        }

        // Edition end //

        // Book Price //

        [TestMethod]
        public void BookPriceOK()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 48.28m;
            ABook.BookPrice = TestData;
            Assert.AreEqual(TestData, ABook.BookPrice);
        }

        [TestMethod]
        public void BookPriceExtremeMin()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = -1.00m;
            string Error;
            Error = ABook.ValidBookPrice(TestData);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void BookPriceMinLessOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 0.00m;
            string Error;
            Error = ABook.ValidBookPrice(TestData);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookPriceMin()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 0.01m;
            string Error;

            Error = ABook.ValidBookPrice(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMinPlusOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 0.02m;
            string Error;

            Error = ABook.ValidBookPrice(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMaxLessOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 499.99m;
            string Error;

            Error = ABook.ValidBookPrice(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMax()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 500.00m;
            string Error;

            Error = ABook.ValidBookPrice(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceMaxPlusOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 500.01m;
            string Error;

            Error = ABook.ValidBookPrice(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceYearMid()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 250.00m;
            string Error;

            Error = ABook.ValidBookPrice(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPriceExtremeMax()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 10000.00m;
            string Error;
            Error = ABook.ValidBookPrice(TestData);
            Assert.AreNotEqual(Error, "");
        }

        // Book Price end //

        // BookShelfNo  //


        [TestMethod]
        public void BookShelfNoOK()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 48.284m;
            ABook.BookShelfNo = TestData;
            Assert.AreEqual(TestData, ABook.BookShelfNo);
        }

        [TestMethod]
        public void BookShelfNpExtremeMin()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = -1300.2131m;
            string Error;
            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void BookShelfNoMinLessOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = -000.0001m;
            string Error;
            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookShelfNoMin()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 000.0000m;
            string Error;

            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMinPlusOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 000.0001m;
            string Error;

            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMaxLessOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 999.9998m;
            string Error;

            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMax()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 999.9999m;
            string Error;

            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMaxPlusOne()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 1000.0000m;
            string Error;

            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMid()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 499.9995m;
            string Error;

            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoExtremeMax()
        {
            clsBook ABook = new clsBook();
            decimal TestData;
            TestData = 11230.231m;
            string Error;
            Error = ABook.ValidBookShelfNo(TestData);
            Assert.AreNotEqual(Error, "");
        }

        // BookShelfNo end //

        // Book Title //

        [TestMethod]
        public void BookTitleMinLessOne()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "";
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMin()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "A";
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMinPlusOne()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "Aa";
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMaxLessOne()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(49, 'A');
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMax()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(50, 'A');
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMaxPlusOne()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(51, 'A');
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleMid()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(25, 'A');
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleExtremeMax()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(500, 'A');
            string Error;

            Error = ABook.ValidTitle(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookTitleOK()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "TestBookTitle";
            ABook.BookTitle = TestData;
            Assert.AreEqual(TestData, ABook.BookTitle);
        }

        // Book Title end // 

        // Genre name //

        [TestMethod]
        public void GenreNameMinLessOne()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "";
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameMin()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "A";
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameMinPlusOne()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "Aa";
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameMaxLessOne()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(49, 'A');
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameMax()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(50, 'A');
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameMaxPlusOne()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(51, 'A');
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameMid()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(25, 'A');
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameExtremeMax()
        {
            clsBook ABook = new clsBook();
            string TestData = "";
            TestData = TestData.PadRight(500, 'A');
            string Error;

            Error = ABook.ValidGenre(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreNameOK()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "Drama";
            ABook.GenreName = TestData;
            Assert.AreEqual(TestData, ABook.GenreName);
        }

        // Genre name end //

        [TestMethod]
        public void FindOK()
        {
            clsBook ABook = new clsBook();
            Boolean Found = false;
            int TestData = 1;
            Found = ABook.Find(TestData);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            clsBook ABook = new clsBook();
            Boolean Found = false;
            Boolean OK = true;
            int BookId = 3;
            Found = ABook.Find(BookId);
            if (ABook.BookId != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestBookTitleFound()
        {
            clsBook ABook = new clsBook();
            Boolean Found = false;
            Boolean OK = true;
            int BookId = 3;
            Found = ABook.Find(BookId);
            if (ABook.BookTitle != "BookName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEditionFound()
        {
            clsBook ABook = new clsBook();
            Boolean Found = false;
            Boolean OK = true;
            int BookId = 3;
            Found = ABook.Find(BookId);
            if (ABook.Edition != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPublicationYearFound()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            int BookId = 3;
            Found = ABook.Find(BookId);
            //check the property
            if (ABook.PublicationYear != 2000)
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAuthorFound()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int BookId = 3;
            Found = ABook.Find(BookId);
            //check the property
            if (ABook.Author != "James Ross")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookPriceFound()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int BookId = 3;
            Found = ABook.Find(BookId);
            //check the property
            if (ABook.BookPrice != 14.78m)
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookShelfNoFound()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int BookId = 3;
            Found = ABook.Find(BookId);
            //check the property
            if (ABook.BookShelfNo != 100.10m)
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenreNameFound()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //create some test data to use with the method
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //boolean variable to store the result of the search
            Boolean Found = false;
            //invoke the method
            int BookId = 3;
            Found = ABook.Find(BookId);
            //check the property
            if (ABook.GenreName != "Drama")
            {
                OK = false;
            }
            //test to see that result if correct
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void ValidOK()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "BookName";
            string Error;

            Error = ABook.Valid(TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ListOK()
        {
            clsBook ABook = new clsBook();
            Boolean Listed;
            Listed = ABook.List();
            Assert.IsTrue(Listed);
        }
    }
}

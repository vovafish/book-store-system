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
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "";
            string Error;

            Error = ABook.Valid(TestData);
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
            ABook.bookPrice = TestData;
            Assert.AreEqual(TestData, ABook.bookPrice);
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
            ABook.bookShelfNo = TestData;
            Assert.AreEqual(TestData, ABook.bookShelfNo);
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
            ABook.bookTitle = TestData;
            Assert.AreEqual(TestData, ABook.bookTitle);
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
            TestData = "TestGenreName";
            ABook.genreName = TestData;
            Assert.AreEqual(TestData, ABook.genreName);
        }

        // Genre name end //

        [TestMethod]
        public void FindOK()
        {
            clsBook ABook = new clsBook();
            string TestData;
            TestData = "BookName";
            Boolean Found = false;
            Found = ABook.Find(TestData);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookTitleFound()
        {
            clsBook ABook = new clsBook();
            string bookTitle = "BookName";
            Boolean OK = true;
            Boolean Found = false;
            Found = ABook.Find(bookTitle);
            if (ABook.bookTitle != "BookName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEditionFound()
        {
            clsBook ABook = new clsBook();
            string bookTitle = "BookName";
            Boolean OK = true;
            Boolean Found = false;
            Found = ABook.Find(bookTitle);
            if (ABook.Edition != 1)
            {
                OK = false;
            }
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

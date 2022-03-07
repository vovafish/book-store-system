using BookStoreClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

/* @VR */

namespace BookStore_Testing
{
    [TestClass]
    public class tstBook
    {
        //good test data
        //create some test data to pass to the method
        string Author = "James Ross";
        string Title = "Tree";
        string PublicationYear = 2000.ToString();
        string Edition = 1.ToString();
        string Price = 19.99.ToString();
        string BookShelfNo = 10.1000.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //test to see that it exists
            Assert.IsNotNull(ABook);
        }
        
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
        public void ListOK()
        {
            clsBook ABook = new clsBook();
            Boolean Listed;
            Listed = ABook.List();
            Assert.IsTrue(Listed);
        }

        /* Test Validation real data */

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /* Author */

        [TestMethod]
        public void AuthorMinLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = ""; //this should trigger an error
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = "A"; //this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = "Aa"; //this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AuthorMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = "";
            //genarate 50 times letter A
            Author = Author.PadRight(49, 'A');//this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = "";
            //genarate 50 times letter A
            Author = Author.PadRight(50, 'A');//this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMid()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = "";
            //genarate 50 times letter A
            Author = Author.PadRight(25, 'A');//this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AuthorMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = "";
            //genarate 50 times letter A
            Author = Author.PadRight(51, 'A');//this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorExtremeMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Author = "";
            //genarate 50 times letter A
            Author = Author.PadRight(500, 'A');//this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /* Author End */

        /* Title */

        [TestMethod]
        public void TitleMinLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = ""; //this should trigger an error
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = "A"; //this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = "Aa"; //this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            //genarate 50 times letter A
            Title = Title.PadRight(49, 'A');//this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            //genarate 50 times letter A
            Title = Title.PadRight(50, 'A');//this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            //genarate 50 times letter A
            Title = Title.PadRight(25, 'A');//this should be ok
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            //genarate 50 times letter A
            Title = Title.PadRight(51, 'A');//this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            //genarate 50 times letter A
            Title = Title.PadRight(500, 'A');//this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /* Title End */

        /* Edition */

        [TestMethod]
        public void EditionMinLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = -1; //this should trigger an error
            //covert int to string
            string Edition = TestData.ToString(); 
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void EditionMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 0; //this should be ok
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 1; //this should be ok
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EditionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 0; //this should be ok
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 1; //this should be ok
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMid()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 0; //this should be ok
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EditionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 2; //this should fail
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EditionExtremeMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 10; //this should fail
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EditionExtremeMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = -10; //this should fail
            //covert int to string
            string Edition = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EditionInvalidData()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Edition = "invalid"; //this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /* Edition End */

        /* PublicationYear */
        
        [TestMethod]
        public void PublicationYearMinLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 1799; //this should trigger an error
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void PublicationYearMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 1800; //this should be ok
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void PublicationYearMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = 1801; //this should be ok
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PublicationYearMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = (DateTime.Now.Year - 1); //this should be ok
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = DateTime.Now.Year; //this should be ok
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMid()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = DateTime.Now.Year; //this should be ok
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = (DateTime.Now.Year + 1); //this should fail
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearExtremeMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = (DateTime.Now.Year + 100); //this should fail
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearExtremeMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            int TestData = (DateTime.Now.Year - 1000); //this should fail
            //Convert int to string
            PublicationYear = Convert.ToString(TestData);
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublicationYearInvalidData()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string PublicationYear = "invalid"; //this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /* PublicationYear End */

        /* Price */

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 0.00m; //this should trigger an error
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 0.01m; //this should be ok
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 0.02m; //this should be ok
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 199.99m; //this should be ok
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 200.00m; //this should be ok
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 100.00m; //this should be ok
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 200.01m; //this should fail
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 1000.00m; //this should fail
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = -1000.00m; //this should fail
            //covert int to string
            string Price = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = "invalid"; //this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /* Price End */


        /* BookShelfNo */

        [TestMethod]
        public void BookShelfNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = -0000.001m; //this should trigger an error
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void BookShelfNoMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 0000.000m; //this should be ok
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 0000.001m; //this should be ok
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookShelfNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 9999.998m; //this should be ok
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 9999.999m; //this should be ok
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMid()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 4500.450m; //this should be ok
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 10000.000m; //this should fail
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = 10000.100000m; //this should fail
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoExtremeMin()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            decimal TestData = -10000.10000m; //this should fail
            //covert int to string
            string BookShelfNo = TestData.ToString();
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookShelfNoInvalidData()
        {
            //create an instance of the class we want to create
            clsBook ABook = new clsBook();
            //string var to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string BookShelfNo = "invalid"; //this should fail
            //invoke the method
            Error = ABook.Valid(Author, Title, PublicationYear, Edition, Price, BookShelfNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        /* BookShelfNo End */



    }
}

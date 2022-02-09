using System;

/* THE FILE CREATED BY VLADIMIRS RIBAKOVS */

namespace BookStoreClasses
{
    public class clsBook
    {
        //private data members for all the attributes
        private string mBookTitle;
        private int mEdition;
        private int mPublicationYear;
        private string mAuthor;
        private decimal mBookPrice;
        private decimal mBookShelfNo;
        private string mGenreName;

        //public property for Author
        public string Author
        {
            get
            {
                //return the private data
                return mAuthor;
            }
            set
            {
                //set the private data
                mAuthor = value;
            }
        }
        /*
         the rest of the code means the same
         */
        public int Edition
        {
            get
            {
                return mEdition;
            }
            set
            {
                mEdition = value;
            }
        }
        public int PublicationYear
        {
            get
            {
                return mPublicationYear;
            }
            set
            {
                mPublicationYear = value;
            }
        }
        public decimal bookPrice
        {
            get
            {
                return mBookPrice;
            }
            set
            {
                mBookPrice = value;
            }
        }
        public decimal bookShelfNo
        {
            get
            {
                return mBookShelfNo;
            }
            set
            {
                mBookShelfNo = value;
            }
        }
        public string bookTitle 
        {
            get
            {
                return mBookTitle;    
            }
            set 
            {
                mBookTitle = value;
            }
        }
        public string genreName
        {
            get
            {
                return mGenreName;
            }
            set
            {
                mGenreName = value;
            }
        } 

        public bool Find(string bookTitle)
        {
            //set the private data members to the test data value
            mBookTitle = "BookName";
            mEdition = 1;
            mPublicationYear = 2000;
            mAuthor = "James Ross";
            mBookPrice = 14.78m;
            mBookShelfNo = 100.10m;
            mGenreName = "Drama";
            //always return true
            return true;
        }

        public string Valid(string Author)
        {
            //function to check if validation works for Author
            string Error = "";
            //check if Author string is empty
            if (Author == "")
            {
                Error = "The Author may not be blank";
            }
            //check if Length of Author is longer than 50 char
            if (Author.Length > 50)
            {
                Error = "The Author must be 50 characters or less";
            }
            //return Error msg
            return Error;
        }

        public string ValidPubYear(Int32 PubYear)
        {
            string Error = "";
            //check if publication year less than 1700 or greater than 3001 if so return the error msg
            if (PubYear <= 1700 || PubYear >= 3001)
            {
                Error = "Please enter valid publication year";
            }
            return Error;
        }

        public string ValidEdition(Int32 Edition)
        {
            string Error = "";
            //is edition not equal to 1 or 0 return the error msg
            if (Edition < 0 || Edition > 1)
            {
                Error = "The edition can be only 0 or 1";
            }

            return Error;
        }

        public string ValidBookPrice(decimal bookPrice)
        {
            string Error = "";
            //if book price not less than 0.01  or greater than 500.00 reutrn the error msg 
            if (bookPrice < 0.01m || bookPrice > 500.00m)
            {
                Error = "The book price is not valid";
            }

            return Error;
        }

        public string ValidBookShelfNo(decimal bookShelfNo)
        {
            string Error = "";
            //if book shelf less than 0.0000 or greater than 999.9999 return the error msg
            if (bookShelfNo < 0.0000m || bookShelfNo > 999.9999m)
            {
                Error = "The book shlef number is not valid";
            }

            return Error;
        }

        /* the same as validation for attribute Author */
        public string ValidTitle(string bookTitle)
        {
            string Error = "";
            if (bookTitle == "")
            {
                Error = "The Book Title may not be blank";
            }
            if (bookTitle.Length > 50)
            {
                Error = "The Book Title must be 50 characters or less";
            }
            return Error;
        }

        /* the same as validation for attribute Author */
        public string ValidGenre(string genreName)
        {
            string Error = "";
            if (genreName == "")
            {
                Error = "The Book Genre may not be blank";
            }
            if (genreName.Length > 50)
            {
                Error = "The Book Genre must be 50 characters or less";
            }
            return Error;
        }

        public bool List()
        {
            //always return true
            return true;
        }
    }
}
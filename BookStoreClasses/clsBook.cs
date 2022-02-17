using System;

/* THE FILE CREATED BY VLADIMIRS RIBAKOVS */

namespace BookStoreClasses
{
    public class clsBook
    {
        //private data members for all the attributes
        private int mBookId;
        private string mBookTitle;
        private int mEdition;
        private int mPublicationYear;
        private string mAuthor;
        private decimal mBookPrice;
        private decimal mBookShelfNo;
        private string mGenreName;

        

        public string BookTitle
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
        public decimal BookPrice
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
        public decimal BookShelfNo
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
       
        public string GenreName
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

        public int BookId
        {
            get
            {
                return mBookId;
            }
            set
            {
                mBookId = value;
            }
        }

        public bool Find(int BookId)
        {
            //create an instance of the data connectin
            clsDataConnection DB = new clsDataConnection();
            //add the parametrs for the book to search for it
            DB.AddParameter("@BookId", BookId);
            //execute the stored procedure
            DB.Execute("sproc_tblBook_FillterByBookId");
            //if one record if found (there should either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mBookId = Convert.ToInt32(DB.DataTable.Rows[0]["bk_id"]);
                mBookTitle = Convert.ToString(DB.DataTable.Rows[0]["bk_title"]);
                mEdition = Convert.ToInt32(DB.DataTable.Rows[0]["bk_edition_no"]);
                mPublicationYear = Convert.ToInt32(DB.DataTable.Rows[0]["bk_pub_yr"]);
                mAuthor = Convert.ToString(DB.DataTable.Rows[0]["bk_author"]);
                mBookPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["bk_price"]);
                mBookShelfNo = Convert.ToDecimal(DB.DataTable.Rows[0]["bk_shelf_no"]);
                mGenreName = Convert.ToString(DB.DataTable.Rows[0]["bk_genre"]);
                //return everyting worked OK
                return true;
            }
            //if no records was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }

        public string ValidAuthor(string Author)
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

        public string ValidBookPrice(decimal BookPrice)
        {
            string Error = "";
            //if book price not less than 0.01  or greater than 500.00 reutrn the error msg 
            if (BookPrice < 0.01m || BookPrice > 500.00m)
            {
                Error = "The book price is not valid";
            }

            return Error;
        }

        public string ValidBookShelfNo(decimal BookShelfNo)
        {
            string Error = "";
            //if book shelf less than 0.0000 or greater than 999.9999 return the error msg
            if (BookShelfNo < 0.0000m || BookShelfNo > 999.9999m)
            {
                Error = "The book shlef number is not valid";
            }

            return Error;
        }

        /* the same as validation for attribute Author */
        public string ValidTitle(string BookTitle)
        {
            string Error = "";
            if (BookTitle == "")
            {
                Error = "The Book Title may not be blank";
            }
            if (BookTitle.Length > 50)
            {
                Error = "The Book Title must be 50 characters or less";
            }
            return Error;
        }

        /* the same as validation for attribute Author */
        public string ValidGenre(string GenreName)
        {
            string Error = "";
            if (GenreName == "")
            {
                Error = "The Book Genre may not be blank";
            }
            if (GenreName.Length > 50)
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

        public string Valid(string author, string title, string publicationYear, string edition, string price, string bookShelfNo)
        {
            //craete a string var to store the errro
            string Error = "";
            //if the Author is blank
            if (author.Length == 0) 
            {
                //record the error
                Error += "The author may not be blank : ";
            }
            //if author is greater than 50 char
            if (author.Length > 50)
            {
                Error += "The author must be less than 50 characters";
            }
            //return any error msg
            return Error;
        }


    }
}
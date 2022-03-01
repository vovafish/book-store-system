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

        
     
        public bool List()
        {
            //always return true
            return true;
        }

        public string Valid(string author, string title, string publicationYear, string edition, string price, string bookShelfNo)
        {
            //craete a string var to store the errro
            string Error = "";
            int DateTemp;
            int EditionTemp;
            decimal PriceTemp;
            decimal BookShelfNo;

            try
            {
                //if the Author is blank
                if (author.Length == 0)
                {
                    //record the error
                    Error += "The author may not be blank : ";
                }
                //if the Author is blank
                if (author.Length > 50)
                {
                    //record the error
                    Error += "The author must be 50 characters or less : ";
                }
            }
            catch 
            {

                //record the error
                Error += "The author must be correct format : ";
            }

            try
            {
                //if the title is blank
                if (title.Length == 0)
                {
                    //record the error
                    Error += "The title may not be blank : ";
                }

                //if title is greater than 50 char
                if (title.Length > 50)
                {
                    //record the error
                    Error += "The title must be less than 50 characters : ";
                }
            }
            catch 
            {
                //record the error
                Error += "The titke must be correct format : ";
            }

            try
            {
                //copy the edition value to the EditionTemp variable
                EditionTemp = Convert.ToInt32(edition);
                if (EditionTemp < 0 || EditionTemp > 1)
                {
                    //record the error
                    Error += "The edition must be between 0 and 1 : ";
                }
            }
            catch
            {

                //record the error
                Error += "The edition was not a valid number : ";
            }

            try
            {
                //copy the edition value to the EditionTemp variable
                PriceTemp = Convert.ToDecimal(price);
                if (PriceTemp < 0.01m || PriceTemp > 200.00m)
                {
                    //record the error
                    Error += "The price must be 0.01 or higher : ";
                }
            }
            catch
            {

                //record the error
                Error += "The price was not a valid value : ";
            }

            try
            {
                //copy the edition value to the EditionTemp variable
                BookShelfNo = Convert.ToDecimal(bookShelfNo);
                if (BookShelfNo < 0000.0000m || BookShelfNo > 9999.9999m)
                {
                    //record the error
                    Error += "The book shelf number must be between 0000.0000 and 9999.9999 : ";
                }
            }
            catch
            {

                //record the error
                Error += "The book shelf number was not a valid value : ";
            }
            
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToInt32(publicationYear);
                if (DateTemp < 1800)
                {
                    //record the error
                    Error += "The date cannot be before 1800th : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Year)
                {
                    //record the error
                    Error += "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error += "The date was not a valid date : ";
            }
            
            //return any error msg
            return Error;
        }


    }
}
using System;
using System.Collections.Generic;

namespace BookStoreClasses
{
    public class clsBookCollection
    {
        //private data member for the list
        List<clsBook> mBookList = new List<clsBook>();
        public List<clsBook> BookList
        {
            get
            {
                //return the private data
                return mBookList;
            }
            set
            {
                //set the private data
                mBookList = value;
            }
        }
        public clsBook ThisBook { get; set; }
        public int Count
        {
            get 
            { 
                //return the count of the list
               return mBookList.Count;
            }
            set
            {
                //dont worry :)
            }
        }

        public clsBookCollection()
        {
            //var for the index
            int Index = 0;
            //var to store the record count 
            int RecordsCount = 0;
            //objcet for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblBook_SelectAll");
            //get the count of records
            RecordsCount = DB.Count;
            //while there are records to process
            while (Index < RecordsCount)
            {
                //create a blank book
                clsBook ABook = new clsBook();
                //read in the fields from the current records
                ABook.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["bk_id"]);
                ABook.BookTitle = Convert.ToString(DB.DataTable.Rows[Index]["bk_title"]);
                ABook.Edition = Convert.ToInt32(DB.DataTable.Rows[Index]["bk_edition_no"]);
                ABook.PublicationYear = Convert.ToInt32(DB.DataTable.Rows[Index]["bk_pub_yr"]);
                ABook.Author = Convert.ToString(DB.DataTable.Rows[Index]["bk_author"]);
                ABook.BookPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["bk_price"]);
                ABook.BookShelfNo = Convert.ToDecimal(DB.DataTable.Rows[Index]["bk_shelf_no"]);
                ABook.GenreName = Convert.ToString(DB.DataTable.Rows[Index]["bk_genre"]);
                //add the record to the private data member
                mBookList.Add(ABook);
                //point at the record
                Index++;
            }
        }
    }
}
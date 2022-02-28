using System;
using System.Collections.Generic;

namespace BookStoreClasses
{
    public class clsBookCollection
    {
        //private data member for the list
        List<clsBook> mBookList = new List<clsBook>();
        //private data member thisBook
        clsBook mThisBook = new clsBook();
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
        public clsBook ThisBook
        {
            //return the private data
            get
            {
                return mThisBook;
            }
            set
            {
                mThisBook = value;
            }
        }
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

        public int Add() 
        {
            //adds a new record to the DB based on the value of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Author", mThisBook.Author);
            DB.AddParameter("@Title", mThisBook.BookTitle);
            DB.AddParameter("@EditionNo", mThisBook.Edition);
            DB.AddParameter("@PubYear", mThisBook.PublicationYear);
            DB.AddParameter("@Price", mThisBook.BookPrice);
            DB.AddParameter("@ShelfNo", mThisBook.BookShelfNo);
            DB.AddParameter("@Genre", mThisBook.GenreName);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblBook_Insert");
        }

        public void Delete()
        {
            //delete the record pointed by the thisBook
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookId", mThisBook.BookId);
            //execute the stored procedure 
            DB.Execute("sproc_tblBook_Delete");
        }
    }
}
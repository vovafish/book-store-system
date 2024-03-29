﻿using System;
using System.Web;
using System.Web.UI.WebControls;
using BookStoreClasses;



public partial class ABook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayBooks("");
        }

    }

    void DisplayBooks()
    {
        //create an instance of the ??? Collection * simplified code *
        clsBookCollection Books = new clsBookCollection();
        //set the data source to the list of ??? on the collection
        lstBooks.DataSource = Books.BookList;
        //set the name of the primary key
        lstBooks.DataValueField = "BookId";
        //set the data field to display
        lstBooks.DataTextField = "BookTitle";
        //bind the data to the list
        lstBooks.DataBind();
    }

    //function use to populate the list box
    Int32 DisplayBooks(string TitleFilter)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsAddress
        clsBookCollection MyBookList = new clsBookCollection();
        //var to store the count of records
        Int32 RecordCount;

        //var to store the house no
        string Author;
        //var to store the street name
        string Edition;
        //var to store the post code
        string Title;
        //var to store the primary key value
        string BookId;
        string BookPrice;
        string GenreName;
        string ShelfNo;
        string PubYear;
        //var to store the index
        // string ShelfNo;
        Int32 Index = 0;
        //clear the list of any existing items
        lstBooks.Items.Clear();
        //call the filter by post code method
        MyBookList.ReportByTitle(TitleFilter);
        //get the count of records found
        RecordCount = MyBookList.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            BookId = Convert.ToString(MyBookList.BookList[Index].BookId);
            //get the house no from the query results
            Author = Convert.ToString(MyBookList.BookList[Index].Author);
            //get the street from the query results
            Edition = Convert.ToString(MyBookList.BookList[Index].Edition);
            //get the post code from the query results
            Title = Convert.ToString(MyBookList.BookList[Index].BookTitle);
            //get the address no from the query results
            BookPrice = Convert.ToString(MyBookList.BookList[Index].BookPrice);
            // BookShelfNo = Convert.ToString(MyBookList.BookList[Index].BookShelfNo);
            GenreName = Convert.ToString(MyBookList.BookList[Index].GenreName);
            ShelfNo = Convert.ToString(MyBookList.BookList[Index].BookShelfNo);
            PubYear = Convert.ToString(MyBookList.BookList[Index].PublicationYear);

            //set up a new object of class list item 
            
            ListItem NewItem = new ListItem(BookId + " : ID" + " | " +
                                            "Author: " + Author + " |" +
                                            " Title: " + Title + " |" +
                                            " Edition: " + Edition + " |" +
                                            " Book Shelf Number: " + ShelfNo + " |" +
                                            " Publication Year: " + PubYear + " |" +
                                            " Price: " + BookPrice + " |" +
                                            " Genre: " + GenreName
                                            );
            
            //add the new item to the list
            lstBooks.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsBook ABook = new clsBook();
        int BookId;
        Boolean Found = false;
        try
        {
            BookId = Convert.ToInt32(txtBookId.Text);
            Found = ABook.Find(BookId);
            if (Found == true)
            {
                txtAuthor.Text = ABook.Author;
                txtTitle.Text = ABook.BookTitle;
                txtPubYear.Text = ABook.PublicationYear.ToString();
                txtEdition.Text = ABook.Edition.ToString();
                txtShelfNo.Text = ABook.BookShelfNo.ToString();
                txtPrice.Text = ABook.BookPrice.ToString();
                txtGenre.Text = ABook.GenreName;

            }
        }
        catch 
        {
            lblError.Text = "<p>Please enter a valid PK</p>";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate  this is a new record
        Session["BookId"] = -1;
        //redirect to the data entry page
        Response.Redirect("AddNewBook.aspx");
    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 BookId;
        //if a record has be selected from the list
        if (lstBooks.SelectedIndex != -1)
        {
            int test = lstBooks.SelectedValue.IndexOf(":");
            string test1 = lstBooks.SelectedValue.Remove(test);
            //get the primary key value of the record to delete
            BookId = Convert.ToInt32(test1);
            //store the data in the session object
            Session["BookId"] = BookId;
            //redirect to the delete page
            Response.Redirect("BookDelete.aspx");
        }
        else //if no records has be selected
        {
            //display an error;
            lblError.Text = "<p>Plese select a record to delete from the list</p>";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 BookId;
        //if a record has be selected from the list
        if (lstBooks.SelectedIndex != -1)
        {
            //find the position of the symbol (:) in string
            int test = lstBooks.SelectedValue.IndexOf(":");
            //remove everything from the string after the indexed position
            string test1 = lstBooks.SelectedValue.Remove(test);
            //get the primary key value of the record to delete
            BookId = Convert.ToInt32(test1);
            //store the data in the session object
            Session["BookId"] = BookId;
            //redirect to the delete page
            Response.Redirect("AddNewBook.aspx");
        }
        else //if no records has be selected
        {
            //display an error;
            lblError.Text = "<p>Plese select a record to delete from the list<p>";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayBooks(txtTitle.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayBooks("");
        //display the number of records found
        lblError.Text = "<span>" + RecordCount + " records in the database</span>";
        //clear the post code filter text box
        txtTitle.Text = "";
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Default.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("../AdminMenu.aspx");

    }
}
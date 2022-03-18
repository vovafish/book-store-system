using BookStoreClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handels the load event for the paga
    protected void Page_Load(object sender, EventArgs e)
    {
        

        
        
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //populate the list and display the number of records found
            lblError.Text = DisplayBooks("") + " records in the database";
        }

    }

    void DisplayBooks()
    {

        //create an instance of the books Collection * simplified code *
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
        string BookPrice;
        string GenreName;
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
            //get the house no from the query results
            Author = Convert.ToString(MyBookList.BookList[Index].Author);
            //get the street from the query results
            Edition = Convert.ToString(MyBookList.BookList[Index].Edition);
            //get the post code from the query results
            Title = Convert.ToString(MyBookList.BookList[Index].BookTitle);
            BookPrice = Convert.ToString(MyBookList.BookList[Index].BookPrice);
           // BookShelfNo = Convert.ToString(MyBookList.BookList[Index].BookShelfNo);
            GenreName = Convert.ToString(MyBookList.BookList[Index].GenreName);
            PubYear = Convert.ToString(MyBookList.BookList[Index].PublicationYear);

            //get the address no from the query results
            //set up a new object of class list item 
            ListItem NewItem = new ListItem("Publication Year: " + PubYear + " |" +
                                            "Author: " + Author + " |" +
                                            " Title: " + Title + " |" +
                                            " Edition: " + Edition + " |" +
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


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayBooks("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminMenu.aspx");
    }
}
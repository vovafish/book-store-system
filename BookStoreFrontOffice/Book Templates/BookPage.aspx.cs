using System;
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
            DisplayBooks();
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
            //get the address no from the query results
            BookId = Convert.ToString(MyBookList.BookList[Index].BookId);
            //ShelfNo = Convert.ToString(MyBookList.BookList[Index].BookShelfNo);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(Author + " " + Edition + " " + Title, BookId);
            //add the new item to the list
            lstBooks.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        //create a new instance of the class
        clsBook ABook = new clsBook();
        //capture the author
        string Author = txtAuthor.Text;
        //capture the title
        string BookTitle = txtTitle.Text;
        //capture the author
        string PublicationYear = txtPubYear.Text;
        //capture the author
        string Edition = txtEdition.Text;
        //capture the author
        string Price = txtPrice.Text;
        //capture the author
        string BookShelfNo = txtShelfNo.Text;

        string Error = "";
        Error = ABook.Valid(Author, BookTitle, PublicationYear, Edition, Price, BookShelfNo);
        if (Error == "")
        {
            //capture the author
            ABook.Author = Author;
            //capture the title
            ABook.BookTitle = BookTitle;
            //capture the PubYear
            ABook.PublicationYear = int.Parse(PublicationYear);
            //capture the book shelf no
            ABook.BookShelfNo = decimal.Parse(BookShelfNo);
            //capture the price
            ABook.BookPrice = decimal.Parse(Price);
            //capture the edition
            ABook.Edition = int.Parse(Edition);
            //store the author in the session object
            Session["ABook"] = ABook;
            //redirect to the page
            Response.Redirect("BookViewer.aspx");
        }
        else
        {
            //display the error msg
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsBook ABook = new clsBook();
        int BookId;
        Boolean Found = false;
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
            //get the primary key value of the record to delete
            BookId = Convert.ToInt32(lstBooks.SelectedValue);
            //store the data in the session object
            Session["BookId"] = BookId;
            //redirect to the delete page
            Response.Redirect("BookDelete.aspx");
        }
        else //if no records has be selected
        {
            //display an error;
            lblError.Text = "Plese select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 BookId;
        //if a record has be selected from the list
        if (lstBooks.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            BookId = Convert.ToInt32(lstBooks.SelectedValue);
            //store the data in the session object
            Session["BookId"] = BookId;
            //redirect to the delete page
            Response.Redirect("AddNewBook.aspx");
        }
        else //if no records has be selected
        {
            //display an error;
            lblError.Text = "Plese select a record to delete from the list";
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
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtTitle.Text = "";
    }
}
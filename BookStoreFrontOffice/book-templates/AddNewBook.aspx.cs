using BookStoreClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddNewBook : System.Web.UI.Page
{
    //var to store the PK with page level scope
    Int32 BookId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the book to be proccessed
        BookId = Convert.ToInt32(Session["BookId"]);
        if (IsPostBack == false)    
        {
            //populate the list of book
            DisplayBook();
           
        }
    }

    //function for adding new record
    void Add()
    {
        //create an instance of the book list
        clsBookCollection BookList = new clsBookCollection();
        //validate the data on the web form
        String Error = BookList.ThisBook.Valid(txtAuthor.Text, txtTitle.Text, txtPubYear.Text, txtEdition.Text, txtPrice.Text, txtShelfNo.Text);
        //if the data is OK then add it to the objcet
        if (Error == "")
        {
            //get the data entered by the user
            BookList.ThisBook.Author = txtAuthor.Text;
            BookList.ThisBook.BookTitle = txtTitle.Text;
            BookList.ThisBook.PublicationYear = Convert.ToInt32(txtPubYear.Text);
            BookList.ThisBook.Edition = Convert.ToInt32(txtEdition.Text);
            BookList.ThisBook.BookPrice = Convert.ToDecimal(txtPrice.Text);
            BookList.ThisBook.BookShelfNo = Convert.ToDecimal(txtShelfNo.Text);
            BookList.ThisBook.GenreName = txtGenre.Text;
            //add the record
            BookList.Add();
            //all done so redirect back to the main page
            Response.Redirect("BookPage.aspx");
        }
        else
        {
            //report an erro
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //function for updating new record
    void Update()
    {
        //create an instance of the book list
        clsBookCollection BookList = new clsBookCollection();
        //validate the data on the web form
        String Error = BookList.ThisBook.Valid(txtAuthor.Text, txtTitle.Text, txtPubYear.Text, txtEdition.Text, txtPrice.Text, txtShelfNo.Text);
        //if the data is OK then add it to the objcet
        if (Error == "")
        {
            //find the record to update
            BookList.ThisBook.Find(BookId);
            //get the data entered by the user
            BookList.ThisBook.Author = txtAuthor.Text;
            BookList.ThisBook.BookTitle = txtTitle.Text;
            BookList.ThisBook.PublicationYear = Convert.ToInt32(txtPubYear.Text);
            BookList.ThisBook.Edition = Convert.ToInt32(txtEdition.Text);
            BookList.ThisBook.BookPrice = Convert.ToDecimal(txtPrice.Text);
            BookList.ThisBook.BookShelfNo = Convert.ToDecimal(txtShelfNo.Text);
            BookList.ThisBook.GenreName = txtGenre.Text;
            //add the record
            BookList.Update();
            //all done so redirect back to the main page
            Response.Redirect("BookPage.aspx");
        }
        else
        {
            //report an erro
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (BookId == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //Update the record
            Update();
        }
        
        //all done so redirect back to the main page
        //Response.Redirect("BookPage.aspx");
    }

    void DisplayBook()
    {
        //craete an instance of the book list
        clsBookCollection BookList = new clsBookCollection();
        //find the record to update
        BookList.ThisBook.Find(BookId);
        //display the data for this record
        txtAuthor.Text = BookList.ThisBook.Author;
        txtTitle.Text = BookList.ThisBook.BookTitle;
        txtPubYear.Text = BookList.ThisBook.PublicationYear.ToString();
        txtEdition.Text = BookList.ThisBook.Edition.ToString();
        txtShelfNo.Text = BookList.ThisBook.BookShelfNo.ToString();
        txtPrice.Text = BookList.ThisBook.BookPrice.ToString();
        txtGenre.Text = BookList.ThisBook.GenreName;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookPage.aspx");
    }
}
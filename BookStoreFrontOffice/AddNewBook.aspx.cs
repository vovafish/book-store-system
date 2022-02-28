using BookStoreClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddNewBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect back to the main page
        Response.Redirect("BookPage.aspx");
    }
}
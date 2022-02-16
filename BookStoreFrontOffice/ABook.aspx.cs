using System;
using BookStoreClasses;



public partial class ABook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        //create a new instance of the class
        clsBook ABook = new clsBook();
        //capture the author
        ABook.Author = txtAuthor.Text;
        //store the author in the session object
        Session["ABook"] = ABook;
        //redirect to the page
        Response.Redirect("BookViewer.aspx");
        
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
            ddlGenre.Text = ABook.GenreName;

        }
    }
}
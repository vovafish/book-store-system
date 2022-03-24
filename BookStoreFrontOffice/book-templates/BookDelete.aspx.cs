using BookStoreClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 BookId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the book to be deleted from the session objcet
        BookId = Convert.ToInt32(Session["BookId"]);
        
    }

    void DeleteBook() 
    {
        //function to delete the selected record

        //create a new instance of the list book
        clsBookCollection ListBook = new clsBookCollection();
        //find the record to delete
        ListBook.ThisBook.Find(BookId);
        //delete the record
        ListBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteBook();
        //redirect back to the main page
        Response.Redirect("BookPage.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookPage.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Default.aspx");
    }
}
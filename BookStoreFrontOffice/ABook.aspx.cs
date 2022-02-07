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
}
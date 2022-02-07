using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreClasses;

public partial class SupplierViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        //get the data from the session object
        ASupplier = (clsSupplier)Session["ASupplier"];
        //display the house number for this entry
        Response.Write(ASupplier.Name);
    }
}
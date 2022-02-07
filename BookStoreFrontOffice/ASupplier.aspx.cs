using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreClasses;

public partial class ASupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        //capture the name
        ASupplier.Name = txtName.Text;
        //Store address in session object
        Session["ASupplier"] = ASupplier;
        //redirect to viewer page
        Response.Redirect("SupplierViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
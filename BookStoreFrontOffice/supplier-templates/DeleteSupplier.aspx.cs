using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreClasses;

public partial class DeleteSupplier : System.Web.UI.Page
{

    //var to store the pk of supplier
    Int32 SupplierNo;

    void DeleteASupplier()
    {
        //function to delete the selected record
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //find the record to delete
        Suppliers.ThisSupplier.Find(SupplierNo);
        //delete the record
        Suppliers.Delete();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session oject
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
    }

    protected void BtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierDefault.aspx");
    }

    protected void BtnSupplier_Click(object sender, EventArgs e)
    {
        Response.Redirect("Supplier.aspx");
    }

    protected void BtnAddSupplierPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddSupplier.aspx");
    }

    protected void BtnEditSupplierPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditSupplier.aspx");
    }

    protected void BtnDeleteSupplierPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteSupplier.aspx");
    }

    protected void btnYesDelete_Click(object sender, EventArgs e)
    {
        //Delete the record
        DeleteASupplier();
        //redirect back to the main page
        Response.Redirect("SupplierDefault.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierDefault.aspx");
    }
}




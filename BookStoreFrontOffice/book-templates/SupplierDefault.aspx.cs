using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierDefault : System.Web.UI.Page
{
    //this function handles the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first visit
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();
        }

    }

    
    void DisplaySuppliers()
    {
        //create an instance of the county collection 
        BookStoreClasses.clsSupplierCollection Suppliers = new BookStoreClasses.clsSupplierCollection();
        //set the data source to the list of suppliers in the collection
        LstSupplier.DataSource = Suppliers.SupplierList;
        //set the name of the pk 
        LstSupplier.DataValueField = "SupplierNo";
        //set the data field to display
        LstSupplier.DataTextField = "Name";
        //bind the data to the list 
        LstSupplier.DataBind();
    }

    protected void LstSupplier_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DdlSupplier_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TxtSearchSupplier_TextChanged(object sender, EventArgs e)
    {

    }

    protected void BtnSearch_Click(object sender, EventArgs e)
    {

    }

    protected void BtnSelectSupplier_Click(object sender, EventArgs e)
    {

    }

    protected void BtnHome_Click(object sender, EventArgs e)
    {

    }

    protected void BtnBooks_Click(object sender, EventArgs e)
    {

    }

    protected void BtnSupplier_Click(object sender, EventArgs e)
    {

    }

    protected void BtnUsers_Click(object sender, EventArgs e)
    {

    }

    protected void BtnOrders_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void BtnSignUp_Click(object sender, EventArgs e)
    {

    }

    protected void BtnStaff_Click(object sender, EventArgs e)
    {

    }

    protected void BtnAddSupplierPage_Click(object sender, EventArgs e)
    {

    }

    protected void BtnEditSupplierPage_Click(object sender, EventArgs e)
    {

    }

    protected void BtnDeleteSupplierPage_Click(object sender, EventArgs e)
    {

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreClasses;

public partial class AddSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //function for adding new records
    void Add()
    {
        //create instance of the suppliers
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //validate the data on the web form 
        String Error = Suppliers.ThisSupplier.Valid(txtName.Text, txtAddress.Text, txtPostcode.Text, txtPhoneNumber.Text, txtCost.Text, txtDescription.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //get the entered data from the text boxes
            Suppliers.ThisSupplier.Name = txtName.Text;
            Suppliers.ThisSupplier.Address = txtAddress.Text;
            Suppliers.ThisSupplier.Postcode = txtPostcode.Text;
            Suppliers.ThisSupplier.PhoneNumber = txtPhoneNumber.Text;
            Suppliers.ThisSupplier.Cost = Convert.ToDouble(txtCost.Text);
            Suppliers.ThisSupplier.Description = txtDescription.Text;
            //add the record
            Suppliers.Add();
            //all done so redirect back to the main page
            Response.Redirect("SupplierDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered: " + Error;
            //lblvisible
            lblError.Visible = true;
        }
    }

    protected void BtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierDefault.aspx");
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

    protected void BtnSupplier_Click(object sender, EventArgs e)
    {
        Response.Redirect("Supplier.aspx");
    }

    protected void BtnAddSupplier_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        
    }


    protected void txtCost_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtPhoneNumber_TextChanged(object sender, EventArgs e)
    {

    }
}
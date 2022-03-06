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
        ASupplier.Address = txtAddress.Text;
        ASupplier.Postcode = txtPostcode.Text;
        ASupplier.PhoneNumber = txtPhoneNumber.Text;
        ASupplier.Description = txtDescription.Text;
        ASupplier.Cost = Convert.ToDouble(txtCost.Text);
        //Store address in session object
        Session["ASupplier"] = ASupplier;
        //redirect to viewer page
        Response.Redirect("SupplierViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsSupplier ASupplier = new clsSupplier();
        //variable to store the primary key 
        Int32 SupplierNo;
        //variable to store the result of the find op
        Boolean Found = false;
        //Get the pk entered
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        //find the record
        Found = ASupplier.Find(SupplierNo);
        //if found
        if (Found==true)
        {
            //display values of propeties in the form
            txtName.Text = ASupplier.Name;
            txtAddress.Text = ASupplier.Address;
            txtPostcode.Text = ASupplier.Postcode;
            txtCost.Text = ASupplier.Cost.ToString();
            txtDescription.Text = ASupplier.Description;
            txtPhoneNumber.Text = ASupplier.PhoneNumber;
            
        }
        //if not found
        else
        {
            //return error message
            lblError.Text = "This Supplier Number does not exist! Please try again.";
            lblError.Visible = true;
            lblError.ForeColor = System.Drawing.Color.Red;
        }
    }
}
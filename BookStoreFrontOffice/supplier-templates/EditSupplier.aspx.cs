using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreClasses;


public partial class EditSupplier : System.Web.UI.Page
{
    //var for supplier no
    Int32 SupplierNo;

    //function for updating records 

    void Update()
    {
        //create instance of the suppliers
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //validate the data on the web form 
        String Error = Suppliers.ThisSupplier.Valid(txtName.Text, txtAddress.Text, txtPostcode.Text, txtPhoneNumber.Text, txtCost.Text, txtDescription.Text);
        //if the data is ok then add it to the object
        if (Error == "")
        {
            //find the record to update 
            Suppliers.ThisSupplier.Find(SupplierNo);
            //get the entered data from the text boxes
            Suppliers.ThisSupplier.Name = txtName.Text;
            Suppliers.ThisSupplier.Address = txtAddress.Text;
            Suppliers.ThisSupplier.Postcode = txtPostcode.Text;
            Suppliers.ThisSupplier.PhoneNumber = txtPhoneNumber.Text;
            Suppliers.ThisSupplier.Cost = Convert.ToDouble(txtCost.Text);
            Suppliers.ThisSupplier.Description = txtDescription.Text;
            //add the record
            Suppliers.Update();
            //all done so redirect back to the main page
            Response.Redirect("SupplierDefault.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data enters " + Error;
        }
    }

    void DisplaySuppliers()
    {
        //create ad instance of teh suplleirs
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //find the record to update
        Suppliers.ThisSupplier.Find(SupplierNo);
        //display the data for this record
        txtName.Text = Suppliers.ThisSupplier.Name;
        txtAddress.Text = Suppliers.ThisSupplier.Address;
        txtPostcode.Text = Suppliers.ThisSupplier.Postcode;
        txtPhoneNumber.Text = Suppliers.ThisSupplier.PhoneNumber;
        txtCost.Text = Suppliers.ThisSupplier.Cost.ToString();
        txtDescription.Text = Suppliers.ThisSupplier.Description;
    }


        protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Supplier to be processed
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
        if (IsPostBack == false)
        {
            
            //if this is not a new record 
            if (SupplierNo != -1)
            {
                DisplaySuppliers();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button8_Click(object sender, EventArgs e)
    {

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

    protected void btnView_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        //capture the inputs
        string Name = txtName.Text;
        string Address = txtAddress.Text;
        string Postcode = txtPostcode.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Description = txtDescription.Text;
        string Cost = txtCost.Text;
        //variable to store error message
        string Error = "";
        //validate the data
        Error = ASupplier.Valid(Name, Address, Postcode, Cost, Description, PhoneNumber);
        //if there is no error
        if (Error == "")
        {
            //capture the data
            ASupplier.Name = Name;
            ASupplier.Address = Address;
            ASupplier.Postcode = Postcode;
            ASupplier.PhoneNumber = PhoneNumber;
            ASupplier.Description = Description;
            ASupplier.Cost = Convert.ToDouble(Cost);
            //Store address in session object
            Session["ASupplier"] = ASupplier;
            //redirect to viewer page
            Response.Redirect("SupplierViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
            lblError.Visible = true;
            lblError.ForeColor = System.Drawing.Color.Red;
        }
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
        try
        {
            //See if the record is entered.
            SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
            //find the record
            Found = ASupplier.Find(SupplierNo);
            lblError.Visible = false;
        }
        catch
        {
            // if not return error message
            lblError.Text = "Please enter a supplier number to find a supplier!";
            lblError.Visible = true;
            lblError.ForeColor = System.Drawing.Color.Red;
        }
        
        //if found
        if (Found == true)
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (SupplierNo == -1)
        {

            //add the new record
            lblError.Text = "To add a new supplier, please navigate to the add supplier page, to edit a supplier, please go back to the supplier page and select one there first.";
            lblError.Visible = true;

        }
        else
        {

            //create a new instance of clsSupplier
            clsSupplier ASupplier = new clsSupplier();
            //capture the inputs
            string Name = txtName.Text;
            string Address = txtAddress.Text;
            string Postcode = txtPostcode.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            string Description = txtDescription.Text;
            string Cost = txtCost.Text;
            //variable to store error message
            string Error = "";
            //validate the data
            Error = ASupplier.Valid(Name, Address, Postcode, PhoneNumber, Cost, Description);
            //if there is no error
            if (Error == "")
            {
                //capture the data
                ASupplier.Name = Name;
                ASupplier.Address = Address;
                ASupplier.Postcode = Postcode;
                ASupplier.PhoneNumber = PhoneNumber;
                ASupplier.Cost = Convert.ToDouble(Cost);
                ASupplier.Description = Description;
                //update the record
                Update();
            }
            else
            {
                //display error message
                lblError.Text = Error;
                lblError.Visible = true;
                lblError.ForeColor = System.Drawing.Color.Red;
            }
                
        }
    }

}

   
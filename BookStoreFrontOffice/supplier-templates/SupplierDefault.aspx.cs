using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookStoreClasses;

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
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        //set the data source to the list of suppliers in the collection
        LstSupplier.DataSource = Suppliers.SupplierList;
        //set the name of the pk 
        LstSupplier.DataValueField = "SupplierNo";
        //set the data field to display
        LstSupplier.DataTextField = "Name";
        //bind the data to the list 
        LstSupplier.DataBind();
    }

    //function use to populate the list box
    Int32 FilterAllSuppliers()
    {
        //this fuction filters the list by name 

        //create a new instance of the clsAddress
        clsSupplierCollection ListofSuppliers = new clsSupplierCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the data
        string Name;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        LstSupplier.Items.Clear();
        //send the search text to the method
        ListofSuppliers.ThisSupplier.Name = TxtSearchSupplier.Text;
        //Initiate the method
        ListofSuppliers.FilterAllSuppliers();
        //get the count of records found
        RecordCount = ListofSuppliers.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the data from query
            Name = Convert.ToString(ListofSuppliers.SupplierList[Index].Name);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(Name);
            //add the new item to the list
            LstSupplier.Items.Add(NewItem);
            //set the data source to the list of suppliers in the collection
            LstSupplier.DataSource = ListofSuppliers.SupplierList;
            //set the name of the pk 
            LstSupplier.DataValueField = "SupplierNo";
            //set the data field to display
            LstSupplier.DataTextField = "Name";
            //bind the data to the list 
            LstSupplier.DataBind();
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
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
        Int32 RecordCount;
        //assign the results of the Filter Suppliers function to the record count var
        RecordCount = FilterAllSuppliers();
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
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
        //store -1 into the session oject to indicate this is a new record
        Session["SupplierNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AddSupplier.aspx");
    }

    protected void BtnEditSupplierPage_Click(object sender, EventArgs e)
    {
        //var to store the primary key vaule of the record to be deleted
        Int32 SupplierNo;
        //if a record has been selected from the list
        if (LstSupplier.SelectedIndex != -1)
        {
            //get the pk value of the record to edit
            SupplierNo = Convert.ToInt32(LstSupplier.SelectedValue);
            //store the data in the session object
            Session["SupplierNo"] = SupplierNo;
            //redirect to the edit page
            Response.Redirect("EditSupplier.aspx");

        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list.";
            lblError.Visible = true;
        }
    }

    protected void BtnDeleteSupplierPage_Click(object sender, EventArgs e)
    {
        //var to store the primary key vaule of the record to be deleted
        Int32 SupplierNo;
        //if a record has been selected from the list
        if (LstSupplier.SelectedIndex != -1)
        {
            //get the pk value of the record to delete
            SupplierNo = Convert.ToInt32(LstSupplier.SelectedValue);
            //store the data in the session object
            Session["SupplierNo"] = SupplierNo;
            //redirect to the delete page
            Response.Redirect("DeleteSupplier.aspx");

        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list.";
            lblError.Visible = true;
        }
    }
}
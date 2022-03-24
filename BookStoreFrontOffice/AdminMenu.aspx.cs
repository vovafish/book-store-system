using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect(".aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("book-templates/BookPage.aspx");
    }

    protected void btnDelivery_Click(object sender, EventArgs e)
    {
        Response.Redirect(".aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        Response.Redirect(".aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect(".aspx");
    }

    protected void btnSupplier_Click(object sender, EventArgs e)
    {
        Response.Redirect("supplier-templates/SupplierDefault.aspx");
    }

    protected void btnDefault_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
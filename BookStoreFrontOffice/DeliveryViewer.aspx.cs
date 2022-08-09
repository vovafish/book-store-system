using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
internal class clsDelivery
{
    internal string Delivery_ID;
}

public partial class DeliveryViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creat a new instance of clsDelivery
        clsDelivery ADelivery = new clsDelivery();
        //get the dtat from the session object
        ADelivery = (clsDelivery)Session["ADelivery"];
        //display the delivery number for this entry
        Response.Write(ADelivery.Delivery_ID);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
internal class clsDelivery
{
    internal string  Delivery_ID;
}



public partial class ADelivery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnTrack_Click(object sender, EventArgs e)
    {
        // creating a new instance of clsDelivery
        clsDelivery ADelivery = new clsDelivery();
        //capture delivery id 
        ADelivery.Delivery_ID = txtDelivery_ID.Text;
        //stpore the adresss in the session object
        Session["ADelivery"] = ADelivery;
        //redirect to the veiwer page 
        Response.Redirect("DeliveryViewer.aspx");
    }
}
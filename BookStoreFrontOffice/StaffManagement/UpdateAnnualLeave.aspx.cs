using System;
using BookStoreClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




public partial class StaffManagement_AnnualLeave : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }

 
  
    void Update()
    {
        //calling the clsStaffCollections Class
        clsStaffCollections Leave = new clsStaffCollections();
        ///taking user data 
        Leave.ThisLeave.StaffID = Convert.ToInt32(txtStaffID.Text);
        Leave.ThisLeave.AnnualLeaveRemainingDays = Convert.ToInt32(txtNoDays.Text);
        Leave.ThisLeave.NextAnnualLeave = txtLeaveStart.Text;
        //running the Add
        Leave.Update();

    }

    protected void txtStaffID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Update();
       
    }

    protected void txtNoDays_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStartDate_TextChanged1(object sender, EventArgs e)
    {

    }
}
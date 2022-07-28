using System;
using BookStoreClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffManagement_AddNewStaff : System.Web.UI.Page
{
    void Add()
    {
        clsStaffCollections AddStaff = new clsStaffCollections();
        AddStaff.ThisLeave.StaffFirstname = txtFristName.Text;
        AddStaff.ThisLeave.StaffLastname = txtLastName.Text;
        AddStaff.ThisLeave.StaffDoB = txtDoB.Text;
        AddStaff.ThisLeave.StaffAddress = txtAddress.Text;
        AddStaff.ThisLeave.StaffRole = txtRole.Text;
        AddStaff.ThisLeave.StaffContactNo = txtNo.Text;
        AddStaff.ThisLeave.StaffEmail = txtEmail.Text;
        AddStaff.ThisLeave.AnnualLeaveRemainingDays = Convert.ToInt32(txtLeave.Text);
        AddStaff.Add();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Add();
    }
}
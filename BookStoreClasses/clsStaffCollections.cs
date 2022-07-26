using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreClasses
{
    public class clsStaffCollections
    {
        clsDataConnection DC = new clsDataConnection();

        clsStaff mThisLeave = new clsStaff();
        //public attrabute for ThisLeave
       
           public clsStaff ThisLeave
        {
            get
            {
                //return the private data
                return mThisLeave;
            }

            set
            {
                //set the private data
                mThisLeave = value;
            }
        }
        public object StaffID { get; set; }

        public Int32 Add()
        {
            clsDataConnection NewDBStaff = new clsDataConnection();
            NewDBStaff.AddParameter("@StaffID", mThisLeave.StaffID);
            NewDBStaff.AddParameter("@StaffFirstname", mThisLeave.StaffFirstname);
            NewDBStaff.AddParameter("@StaffLastname", mThisLeave.StaffLastname);
            NewDBStaff.AddParameter("@StaffDoB ", mThisLeave.StaffDoB);
            NewDBStaff.AddParameter("@StaffAddress", mThisLeave.StaffAddress);
            NewDBStaff.AddParameter("@StaffRole", mThisLeave.StaffRole);
            NewDBStaff.AddParameter("@StaffContactNo", mThisLeave.StaffContactNo);
            NewDBStaff.AddParameter("@StaffEmail", mThisLeave.StaffEmail);
            NewDBStaff.AddParameter("@AnnualLeaveRemainingDays", mThisLeave.AnnualLeaveRemainingDays);
            return NewDBStaff.Execute("sproc_tblStaffDetails_Insert");


        }

        public void Update(clsStaff ExistingStaff)
        {
            clsDataConnection ExistingDBStaff = new clsDataConnection();
            //Adding the parameters
            ExistingDBStaff.AddParameter("@StaffID", ExistingStaff.StaffID);
            ExistingDBStaff.AddParameter("@StaffFirstname", ExistingStaff.StaffFirstname);
            ExistingDBStaff.AddParameter("@StaffLastname", ExistingStaff.StaffLastname);
            ExistingDBStaff.AddParameter("@StaffDoB ", ExistingStaff.StaffDoB);
            ExistingDBStaff.AddParameter("@StaffAddress", ExistingStaff.StaffAddress);
            ExistingDBStaff.AddParameter("@StaffRole", ExistingStaff.StaffRole);
            ExistingDBStaff.AddParameter("@StaffContactNo", ExistingStaff.StaffContactNo);
            ExistingDBStaff.AddParameter("@StaffEmail", ExistingStaff.StaffEmail);
            ExistingDBStaff.AddParameter("@AnnualLeaveRemainingDays", ExistingStaff.AnnualLeaveRemainingDays);
            //execute the stored procedure
            ExistingDBStaff.Execute("sproc_tblStaffDetails_Updates");

        }
        public Boolean Find(Int32 StaffID)
        {
            clsDataConnection DC = new clsDataConnection();
            DC.AddParameter("@StaffID", StaffID);
            //execute the query 
            DC.Execute("sproc_tblStaffDetail_FilterByStaffID");

        }

    }
}

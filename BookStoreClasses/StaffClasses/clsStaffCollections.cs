using System;
using System.Collections.Generic;
using BookStoreClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreClasses
{
    public class clsStaffCollections
    {
        //private data memberfor list
        List<clsStaff> mStaffList = new List<clsStaff>();

        clsStaff mThisLeave = new clsStaff();
        //public attrabute for ThisLeave

        public clsStaffCollections()
        {
            clsDataConnection DC = new clsDataConnection();
            DC.Execute("sproc_tblStaffDetails_SelectAll");
            //This populates the array list using the data from the table
            PopulateArray(DC);

        }
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;

            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        //puluic property for count
        public int Count
        {

            get
            {
                //return count of the list
                return mStaffList.Count;
            }
            set
            {
                
            }
        }
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
        //public object StaffID { get; set; }

        public int Add()
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

        public void Delete()
        {
            //deletes records by thisLeave
            //Database Connection
            clsDataConnection DC = new clsDataConnection();
            //setting the rules for the sproc
            DC.AddParameter("@StaffID", mThisLeave.StaffID);
            //executes
            DC.Execute("sproc_tblStaffDetails_Delete");

        }


        public void Update()
        {
            clsDataConnection ExistingDBStaff = new clsDataConnection();
            //Adding the parameters
            ExistingDBStaff.AddParameter("@StaffID", mThisLeave.StaffID);
            ExistingDBStaff.AddParameter("@StaffFirstname", mThisLeave.StaffFirstname);
            ExistingDBStaff.AddParameter("@StaffLastname", mThisLeave.StaffLastname);
            ExistingDBStaff.AddParameter("@StaffDoB ", mThisLeave.StaffDoB);
            ExistingDBStaff.AddParameter("@StaffAddress", mThisLeave.StaffAddress);
            ExistingDBStaff.AddParameter("@StaffRole", mThisLeave.StaffRole);
            ExistingDBStaff.AddParameter("@StaffContactNo", mThisLeave.StaffContactNo);
            ExistingDBStaff.AddParameter("@StaffEmail", mThisLeave.StaffEmail);
            ExistingDBStaff.AddParameter("@AnnualLeaveRemainingDays", mThisLeave.AnnualLeaveRemainingDays);
            ExistingDBStaff.AddParameter("@NextAnnualLeave", mThisLeave.NextAnnualLeave);
            //execute the stored procedure
            ExistingDBStaff.Execute("sproc_tblStaffDetails_Updates");

        }
      
        public void ReportByName(string StaffLastname)
        {
            //this part will filter the data based on similarities 
            clsDataConnection DC = new clsDataConnection();
            //sends the request to the DataBase
            DC.AddParameter("@StaffLastname", StaffLastname);
            //Executes
            DC.Execute("sproc_tblStaffDetails_FilterByStaffLastname");
            //populates
            PopulateArray(DC);

        }

        void PopulateArray(clsDataConnection DC)
        {
            //var index
            Int32 Index = 0;
            //var record the count
            Int32 RecordCount;
            //record count
            RecordCount = DC.Count;
            //clears the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                // sets the properties
                AStaff.StaffID = Convert.ToInt32(DC.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffFirstname = Convert.ToString(DC.DataTable.Rows[Index]["StaffFirstname"]);
                AStaff.StaffLastname = Convert.ToString(DC.DataTable.Rows[Index]["StaffLastname"]);
                AStaff.StaffDoB = Convert.ToString(DC.DataTable.Rows[Index]["StaffDoB"]);
                AStaff.StaffAddress = Convert.ToString(DC.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StaffRole = Convert.ToString(DC.DataTable.Rows[Index]["StaffRole"]);
                AStaff.StaffContactNo = Convert.ToString(DC.DataTable.Rows[Index]["StaffContactNo"]);
                AStaff.StaffEmail = Convert.ToString(DC.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.AnnualLeaveRemainingDays = Convert.ToInt32(DC.DataTable.Rows[Index]["AnnualLeaveRemainingDays"]);
                AStaff.NextAnnualLeave = Convert.ToString(DC.DataTable.Rows[Index]["NextAnnualLeave"]);
                //Adds an item to the test list 
                mStaffList.Add(AStaff);
                //Index to the next record
                Index++;
            }
            
        }
        public void FilterAllStaff()
        {
            //DataBase Connection
            clsDataConnection db = new clsDataConnection();

            //Adds the following parameter to the text box
            db.AddParameter("@StaffLastname", mThisLeave.StaffLastname);
            //execute
            db.Execute("sproc_tblStaffDetails_FilterByStaffLastname");
            //resultes populate the array 
            PopulateArray(db);


        }

    }
}

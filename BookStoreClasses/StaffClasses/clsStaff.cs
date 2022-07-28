using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BookStoreClasses
{

    public class clsStaff
    {
        //StaffID Private member variable
        private Int32 mStaffID;
        //StaffID public attribute
        public Int32 StaffID
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffID;
            }
            set
            {
                // this line grants data into the attribute
                mStaffID = value;
            }
        }
        //StaffFirstname Private member variable
        private String mStaffFirstname;
        //StaffFirstname public attribute
        public String StaffFirstname
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffFirstname;
            }
            set
            {
                // this line grants data into the attribute
                mStaffFirstname = value;
            }
        }
        //StaffLastname Private member variable
        private String mStaffLastname;
        //StaffLastname public attribute
        public String StaffLastname
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffLastname;
            }
            set
            {
                // this line grants data into the attribute
                mStaffLastname = value;
            }
        }

        //StaffDoB Private member variable
        private String mStaffDoB;
        //StaffDoB public attribute
        public String StaffDoB
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffDoB;
            }
            set
            {
                // this line grants data into the attribute
                mStaffDoB = value;
            }
        }


        //StaffAddress Private member variable
        private String mStaffAddress;
        //StaffAddress public attribute
        public String StaffAddress
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffAddress;
            }
            set
            {
                // this line grants data into the attribute
                mStaffAddress = value;
            }
        }

        //StaffRole Private member variable
        private String mStaffRole;
        //StaffRole public attribute
        public String StaffRole
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffRole;
            }
            set
            {
                // this line grants data into the attribute
                mStaffRole = value;
            }
        }

        //StaffContactNo Private member variable
        private String mStaffContactNo;
        //StaffContactNo public attribute
        public String StaffContactNo
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffContactNo;
            }
            set
            {
                // this line grants data into the attribute
                mStaffContactNo = value;
            }
        }

        //StaffEmail Private member variable
        private String mStaffEmail;
        //StaffEmail public attribute
        public String StaffEmail
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffEmail;
            }
            set
            {
                // this line grants data into the attribute
                mStaffEmail = value;
            }
        }

        //StaffEmail Private member variable
        private Int32 mAnnualLeaveRemainingDays;
        //StaffEmail public attribute
        public Int32 AnnualLeaveRemainingDays
        {
            get
            {
                // this line pushes data out of the attribute
                return mAnnualLeaveRemainingDays;
            }
            set
            {
                // this line grants data into the attribute
                mAnnualLeaveRemainingDays = value;
            }
        }
        //NextAnnualLeave Private member variable
        private String mNextAnnualLeave;
        //NextAnnualLeave public attribute
        public String NextAnnualLeave
        {
            get
            {
                // this line pushes data out of the attribute
                return mNextAnnualLeave;
            }
            set
            {
                // this line grants data into the attribute
                mNextAnnualLeave = value;
            }
        }
        public bool Find(int StaffID)
        {
            //database connection
            clsDataConnection DC = new clsDataConnection();
            DC.AddParameter("@StaffID", StaffID);
            //execute the query 
            DC.Execute("sproc_tblStaffDetail_FilterByStaffID");
            if (DC.Count == 1)
            {
                mStaffID = Convert.ToInt32(DC.DataTable.Rows[0]);
                mStaffFirstname = Convert.ToString(DC.DataTable.Rows[0]["StaffFirstname"]);
                mStaffLastname = Convert.ToString(DC.DataTable.Rows[0]["StaffLastname"]);
                mStaffDoB = Convert.ToString(DC.DataTable.Rows[0]["StaffDoB"]);
                mStaffAddress = Convert.ToString(DC.DataTable.Rows[0]["StaffAddress"]);
                mStaffRole = Convert.ToString(DC.DataTable.Rows[0]["StaffRole"]);
                mStaffContactNo = Convert.ToString(DC.DataTable.Rows[0]["StaffContactNo"]);
                mStaffEmail = Convert.ToString(DC.DataTable.Rows[0]["StaffEmail"]);
                mAnnualLeaveRemainingDays = Convert.ToInt32(DC.DataTable.Rows[0]["AnnualLeaveRemainingDays"]);
                mNextAnnualLeave = Convert.ToString(DC.DataTable.Rows[0]["NextAnnualLeave"]);


                return true;
            }
            //if not record is found
            else
            {
                //return false that there is a problem
                return false;
            }


        }
    }
}
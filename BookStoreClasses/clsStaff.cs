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
        private Int32 mStaffFirstname;
        //StaffFirstname public attribute
        public Int32 StaffFirstname
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
        private Int32 mStaffLastname;
        //StaffLastname public attribute
        public Int32 StaffLastname
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
        private Int32 mStaffDoB;
        //StaffDoB public attribute
        public Int32 StaffDoB
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
        private Int32 mStaffAddress;
        //StaffAddress public attribute
        public Int32 StaffAddress
        {
            get
            {
                // this line pushes data out of the attribute
                return mStaffAddress;
            }
            set
            {
                // this line grants data into the attribute
                mStaffAddress= value;
            }
        }

        //StaffRole Private member variable
        private Int32 mStaffRole;
        //StaffRole public attribute
        public Int32 StaffRole
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
        private Int32 mStaffContactNo;
        //StaffContactNo public attribute
        public Int32 StaffContactNo
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
        private Int32 mStaffEmail;
        //StaffEmail public attribute
        public Int32 StaffEmail
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
        private Int32 mNextAnnualLeave;
        //NextAnnualLeave public attribute
        public Int32 NextAnnualLeave
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

    }
}

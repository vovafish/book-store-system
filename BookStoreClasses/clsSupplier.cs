using System;

namespace BookStoreClasses
{
    public class clsSupplier
    {
        //private data memeber for properties
        private Int32  mSupplierNo;
        private string mName;
        private string mAddress;
        private string mPostcode;
        private double mCost;
        private string mDescription;
        private string mPhoneNumber;

        //public find property
        public bool Find(int SupplierNo)
        {
            //create instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Supplier No to search for
            DB.AddParameter("@SupplierNo", SupplierNo);
            //execute the sproc
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            //if one record is found (there should be 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the variable private data members
                mSupplierNo =  Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                mName =        Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mAddress =     Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostcode =    Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mCost =        Convert.ToDouble(DB.DataTable.Rows[0]["Cost"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                //return that everything is ok
                return true;
            }
            //if not record is found
            else
            {
                //return false that there is a problem
                return false;
            }
        }

        //public data memeber for address no property
        public int SupplierNo
        {
            get
            {
                //this line of code send data out of the property
                return mSupplierNo;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierNo = value;
            }

        }


        //public property for name
        public string Name 
            { 
                get 
                {

                    //this line of code send data out of the property
                    return mName;
                
                } 
                set 
                {

                    //this line of code allows data into the property
                    mName = value;
                
                }
            }

        //public property for cost
        public double Cost
        { 
            get
            {
                //this line of code send data out of the property
                return mCost;

            }

            set
            {
                //this line of code allows data into the property
                mCost = value;

            }

        }

        //public property for address
        public string Address 
        {
            get
            {
                //this line of code send data out of the property
                return mAddress;

            } 
            
            set
            {
                //this line of code allows data into the property
                mAddress = value;

            }
        
        }

        //public property for description
        public string Description
        {
            get
            {
                //this line of code send data out of the property
                return mDescription;

            }

            set
            {
                //this line of code allows data into the property
                mDescription = value;

            }

        }
        
        //public property for phone number
        public string PhoneNumber
        {
            get
            {
                //this line of code send data out of the property
                return mPhoneNumber;

            }

            set
            {
                //this line of code allows data into the property
                mPhoneNumber = value;

            }

        }
        
        //public property for postcode
        public string Postcode
        {
            get
            {
                //this line of code send data out of the property
                return mPostcode;

            }

            set
            {
                //this line of code allows data into the property
                mPostcode = value;

            }

        }

        public string Valid(string name, string address, string postcode, string cost, string description, string phoneNumber)
        {
            //create a string to store the error
            string Error = "";
            //variable for cost test
            Double CostTest;
            //if blank 
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The Name field must not be left blank : ";
            }
            //if name is greater than 20 character
            if (name.Length > 20)
            {
                Error = Error + "The Name field must not be more than 20 chararters : ";
            }
            //if
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address must not be left blank : ";

            }
            //if 
            if (address.Length > 50)
            {
                // record the error
                Error = Error + "The address length must not be longer than 50 characters : ";
            }
            //if
            if (postcode.Length == 0)
            {
                //record error
                Error = Error + "The postcode must not be left blank : ";
            }
            //if 
            if (postcode.Length > 7)
            {
                // record the error
                Error = Error + "The postcode must not be more than 7 characters including the space : ";
            }
            //if 
            if (description.Length > 200)
            {
                // record the error
                Error = Error + "The description must not be more than 200 characters : ";
            }
            //if 
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The Phone number must not be left blank : ";
            }
            //if 
            if (phoneNumber.Length > 11)
            {
                //reocrd the error
                Error = Error + "The Phone number must be exactly 11 characters : ";
            }
            //if
            if (phoneNumber.Length != 11)
            {
                //reocrd the error
                Error = Error + "This is not a valid phone number. The Phone number must be exactly 11 characters : ";
            }

            try
            {
                //convert to double
                CostTest = Convert.ToDouble(cost);
                //if
                if (CostTest < 0)
                {
                    Error = Error + "The cost cannot be a minus number : ";
                }
                //if 
                if (CostTest > 1000000)
                {
                    Error = Error + "The cost must not be larger than £1,000,000 : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The cost is not a valid number type";
            }
            //return any error messgaes
            return Error;
        }
    }
}
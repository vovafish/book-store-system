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
            //set the private data members to the test data value
            mSupplierNo = 5;
            mName = Convert.ToString("Book Depot");
            mAddress = Convert.ToString("Canada");
            mPostcode = Convert.ToString("OT4 5TH");
            mCost = Convert.ToDouble(5.23);
            mDescription = Convert.ToString("A Description");
            mPhoneNumber = Convert.ToString("07892938445");
            //set to always return true
            return true;
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


        
    }
}
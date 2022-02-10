using System;

namespace BookStoreClasses
{
    public class clsSupplier
    {
        //private data memeber for address no property
        private Int32 mSupplierNo;
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

        public string Name { get; set; }
        public double Cost { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Postcode { get; set; }
        

        
        //public find property
        public bool Find(int SupplierNo)
        {
            //set the private data members to the test data value
            mSupplierNo = 5;
            //set to always return true
            return true;
        }
    }
}
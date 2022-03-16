using System.Collections.Generic;

namespace BookStoreClasses
{
    public class clsSupplierCollection
    {
        //private data memeber for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        //public property for supplier list
        public List<clsSupplier> SupplierList
        {
            get 
            {
                //return private data
                return mSupplierList;
            }

            set 
            {
                //set the private data 
                mSupplierList = value;

            }

        }

        //puluic property for count
        public int Count 
        { 
            
            get 
            {
                //return count of the list
                return mSupplierList.Count;
            } 
            set 
            { 
                //tbc
            } 
        }
        public clsSupplier ThisSupplier { get; set; }
    }
}
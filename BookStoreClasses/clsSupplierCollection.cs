using System.Collections.Generic;
using System;

namespace BookStoreClasses
{
    public class clsSupplierCollection
    {
        //private data memeber for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        //contructor for class
        public clsSupplierCollection()
        {
            
            //var for index
            Int32 Index = 0;
            //var to store the count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                clsSupplier ASupplier = new clsSupplier();
                //set it's properties
                ASupplier.SupplierNo =  Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierNo"]);
                ASupplier.Name =        Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ASupplier.Address =     Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ASupplier.Postcode =    Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                ASupplier.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ASupplier.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                ASupplier.Cost =        Convert.ToInt32(DB.DataTable.Rows[Index]["Cost"]);
                //Add item to test list
                mSupplierList.Add(ASupplier);
                //index to next record
                Index++;
            }
            
            
        }

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
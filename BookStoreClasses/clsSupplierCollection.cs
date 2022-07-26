using System.Collections.Generic;
using System;

namespace BookStoreClasses
{
    public class clsSupplierCollection
    {
        //private data memeber for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private data member this supplier
        clsSupplier mThisSupplier = new clsSupplier();

        //contructor for class
        public clsSupplierCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the sproc 
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate arrary list with the data table
            PopulateArray(DB);
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

        //public property for ThisSupplier
        public clsSupplier ThisSupplier 
        { 
            get 
            {
                //return the private data
                return mThisSupplier; 
            }
            
            set 
            {
                //set the private data
                mThisSupplier = value; 
            } 
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisSupplier
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@Postcode", mThisSupplier.Postcode);
            DB.AddParameter("@PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("@Cost", mThisSupplier.Cost);
            DB.AddParameter("@Description", mThisSupplier.Description);
            //execute the sproc which returns the pk
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSupplier
            //contect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            //execute the sproc
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void Update()
        {
            //edits a record to the database based on the values of mThisSupplier
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("SupplierNo", mThisSupplier.SupplierNo);
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Address", mThisSupplier.Address);
            DB.AddParameter("@Postcode", mThisSupplier.Postcode);
            DB.AddParameter("@PhoneNumber", mThisSupplier.PhoneNumber);
            DB.AddParameter("@Cost", mThisSupplier.Cost);
            DB.AddParameter("@Description", mThisSupplier.Description);
            //execute the sproc which returns the pk
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void ReportByName(string Name)
        {
            //filters the records based on a full or partial Name
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the db
            DB.AddParameter("@Name", Name);
            //execute the sproc
            DB.Execute("sproc_tblSupplier_FilterByName");
            //populate array
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the arrary list based on the data table in the parameter DB
            //var for index
            Int32 Index = 0;
            //var to store the count
            Int32 RecordCount;
            //get the record count
            RecordCount = DB.Count;
            //clear private arrary list
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
              clsSupplier ASupplier = new clsSupplier();
              //set it's properties
              ASupplier.SupplierNo = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierNo"]);
              ASupplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
              ASupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
              ASupplier.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
              ASupplier.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
              ASupplier.Cost = Convert.ToInt32(DB.DataTable.Rows[Index]["Cost"]);
              ASupplier.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
              //Add item to test list
              mSupplierList.Add(ASupplier);
              //index to next record
              Index++;
            }

            

        }

        public void FilterAllSuppliers()
        {
            //connect to the db
            clsDataConnection Database = new clsDataConnection();
            //add the parameter from the text box
            Database.AddParameter("@Name", mThisSupplier.Name);
            //exevute the sproc
            Database.Execute("sproc_tblSupplier_FilterByName");
            //populate array with results
            PopulateArray(Database);
        }
    }
}
using System;

namespace BookStore_Testing.StaffManagement
{
    internal class clsStaffCollection
    {
        public string StaffInstance { get; internal set; }
        public bool Active { get; internal set; }
        public string Staff_Name { get; internal set; }

        internal string Valid(string name)
        {
            string Error;
            Error = "";
            if (name =="")
            {
                Error="Field must not be blank!";
            }
            if(name.Length>20)
            {
                Error = "Field must not exceed 20 characters";
            }
            return Error;
        }
    }
}
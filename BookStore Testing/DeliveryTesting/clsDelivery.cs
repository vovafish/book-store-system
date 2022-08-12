using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Testing.DeliveryTesting
{
    class clsDelivery
    {
        public string DeliveryStatus { get; internal set; }
        public bool Active { get; internal set; }
        //declaring variables
        private string mDelivery_status;
        public string Delivery_status
        {
            get
            {
                return mDelivery_status;
            }
            set
            {
                mDelivery_status = value;
            }
        }

        internal string Valid(string delivery)
        {
            string Error;
            Error = "";
            if (delivery == "")
            {
                Error = "Field must cannot be blank";
            }
            if (delivery.Length > 50)
            {
                Error = "Field must not exceed 50 characters";
            }
            return Error;
        }
        //private data memeber for the delivery id property
        private Int32 mDelivery_ID;
        // Dleivery_ID public Property
        public Int32 Delivery_ID
        {
            get
            {
                //sends data out of the property
                return mDelivery_ID;
            }

            set
            {
                //Allows data into the property
                mDelivery_ID = value;

            }
        
        }
        //Delivery_date private member variable 
        private DateTime mDelivery_date;
        public DateTime Delivery_date 
        { 
            get
            {
                return mDelivery_date;
            
            }

            set
            {
                mDelivery_date = value;
            }
        
        }

        private Int32 mFK_Order_ID;
        public Int32 FK_Order_ID 
        {
            get
            {
                //sends data out of the property
                return mFK_Order_ID;
            }

            set
            {
                //Allows data into the property
                FK_Order_ID = value;

            }



        }
        


        

        internal bool find(int Delivery_ID)
        {
            //set the private data members to the test data value

            return true;
        }

        internal bool Find(int delivery_ID)

        {
            //set the private data members to the test data value
            mDelivery_ID = 21;

            mFK_Order_ID = 2;

            mDelivery_date = Convert.ToDateTime("16/09/2021");

            mDelivery_status = "pending";

            //always true 
            return true;
        }
    }
}

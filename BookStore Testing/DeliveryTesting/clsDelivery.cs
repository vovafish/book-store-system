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
        public string Delivery_status { get; internal set; }
        public int Delivery_ID { get; internal set; }
        public DateTime Delivery_date { get; internal set; }
        public int FK_Order_ID { get; internal set; }

        internal string Valid(string name)
        {
            return "";
        }

        internal bool find(int Delivery_ID)
        {
            return true;
        }
    }
}

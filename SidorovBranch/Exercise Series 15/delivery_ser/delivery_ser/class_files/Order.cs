using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delivery_ser.class_files
{
    public class Order
    {
        public virtual int id { get; set; }
        public virtual string description { get; set; }
        public virtual int sender_id { get; set; }
        public virtual int recipient_id { get; set; }
        public virtual int recipient_store_id { get; set; }
        public virtual int sender_store_id { get; set; }
        public virtual string shipping_date { get; set; }
        public virtual string recieving_date { get; set; }
    }
}

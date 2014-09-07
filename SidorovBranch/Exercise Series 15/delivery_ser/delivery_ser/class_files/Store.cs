using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delivery_ser.class_files
{
    public class Store
    {
        public virtual int id { get; set; }
        public virtual int city_id { get; set; }
        public virtual string address { get; set; }
        public virtual int shedule_id { get; set; }
    }
}

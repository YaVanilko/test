using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delivery_ser.class_files
{
    public class Person
    {
        public virtual int id { get; set; }
        public virtual string last_name { get; set; }
        public virtual string first_name { get; set; }
        public virtual string middle_name { get; set; }
        
    }
}

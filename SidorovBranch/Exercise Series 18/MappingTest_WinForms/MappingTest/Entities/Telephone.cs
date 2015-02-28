using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingTest.Entities
{
    public class Telephone
    {
        public virtual int Id { get; set; }

        public virtual string TelephoneNumber { get; set; }
    }
}

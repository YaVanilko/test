using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingTest.Entities
{
    public class Person
    {
        public virtual int Id { get; set; }
        
        public virtual string LastName { get; set; }
        
        public virtual string FirstName { get; set; }

        public virtual string MiddleName { get; set; }

    }
}

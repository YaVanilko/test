using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonMapping
{
    public class Car
    {
        public virtual int Id { get; set; }

        public virtual string Description { get; set; }

        public virtual int PersonId { get; set; }
    }
}

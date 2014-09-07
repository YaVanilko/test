using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingTest.Entities
{
    public class Pack
    {
        public virtual int Id { get; set; }

        public virtual string Barcode { get; set; }

        public virtual string Weight{ get; set; }

        public virtual int OrderId { get; set; }

    }
}

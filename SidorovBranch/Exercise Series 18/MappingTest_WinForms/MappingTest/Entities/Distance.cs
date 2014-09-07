using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingTest.Entities
{
    public class Distance
    {
        public virtual int Id { get; set; }

        public virtual int CityFromId { get; set; }

        public virtual int CityToId { get; set; }
    }
}

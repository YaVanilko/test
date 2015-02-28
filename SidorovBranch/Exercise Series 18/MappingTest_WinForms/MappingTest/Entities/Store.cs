using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MappingTest.Entities
{
    public class Store
    {
        public virtual int Id { get; set; }

        public virtual int CityId { get; set; }

        public virtual string Address { get; set; }

        public virtual int ScheduleId { get; set; }

        public virtual Schedule Schedules { get; set; }

        public virtual IList<Telephone> Telephones { get; set; }

    }
}

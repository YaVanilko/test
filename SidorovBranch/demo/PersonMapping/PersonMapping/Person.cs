using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonMapping
{
    public class Person
    {
        public virtual int Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual int CityId { get; set; }

        public virtual IList<Telephone> Telephones { get; set; }

        public virtual IList<Car> Cars { get; set; }

        public virtual Extra Extra { get; set; }

        public virtual City City { get; set; }
    }
}

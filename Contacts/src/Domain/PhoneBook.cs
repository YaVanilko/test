using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class PhoneBook
    {
        public virtual int Id { get; set; }
        public virtual Abonent Abonent { get; set; }
        public virtual string Value { get; set; }
        public virtual TypeInfo Info { get; set; }
    }
}

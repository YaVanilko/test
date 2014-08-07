using System;

namespace Domain
{
    public class Abonent
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime BirtDay { get; set; }
    }
}

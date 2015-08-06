using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string fn, string ln, string mn, string ag)
        {
            FirstName = fn;
            LastName = ln;
            MiddleName = mn;
            Age = ag;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Age { get; set; }
    }
}

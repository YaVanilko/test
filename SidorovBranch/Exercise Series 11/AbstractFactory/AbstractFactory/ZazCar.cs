using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ZazCar : AbstractCar
    {
        public ZazCar(string model) : base("Zaz", model) { }
    }
}

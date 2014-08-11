using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractCarsFactory
    {
        abstract public AbstractCar CreateCar(string model);
        abstract public Part ProducePart(string model, int cost);
    }
}

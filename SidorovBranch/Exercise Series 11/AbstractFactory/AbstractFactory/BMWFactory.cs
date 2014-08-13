using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class BMWFactory : AbstractCarsFactory
    {
        public override AbstractCar CreateCar(string model)
        {
            return new BMWCar(model);
        }
        public override Part ProducePart(string model, int cost)
        {
            return new Part(model, cost, "BMW");
        }
    }
}

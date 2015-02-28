using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoTest2
{
    class Circle:Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetSquere()
        {
            return 3.14*radius*radius;
        }

    }
}

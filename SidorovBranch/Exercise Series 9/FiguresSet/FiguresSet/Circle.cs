using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresSet
{
    class Circle : Figure
    {
        private readonly double radius;
        private const double PI = 3.14159265359;

        public Circle(double radius) { this.radius = radius; }

        public override double GetSquare() { return PI * radius * radius; }
    }
}

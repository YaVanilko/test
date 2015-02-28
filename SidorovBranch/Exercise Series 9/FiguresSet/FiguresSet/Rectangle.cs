using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresSet
{
    class Rectangle : Figure
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height) { this.width = width; this.height = height; }

        public override double GetSquare() { return width * height; }

        public bool IsSquare() { return false; }
    }
}

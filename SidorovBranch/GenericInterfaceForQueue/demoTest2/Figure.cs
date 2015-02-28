using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoTest2
{
    abstract class Figure
    {
        public abstract double GetSquere();

        public static double CalculateSquare(List<Figure> F)
        {
            double sum = 0;

            foreach (Figure f in F)
            {
                sum += f.GetSquere();
            }
            return sum;
        }

        public static void AddSomeCircles(List<Circle> C)
        {

        }

    }
}

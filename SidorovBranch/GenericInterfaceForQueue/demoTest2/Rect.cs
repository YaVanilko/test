using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoTest2
{
    class Rect: Figure
    {
        private double wide;
        private double hig;

        public Rect(double wide, double hig)
        {
            this.wide = wide;
            this.hig = hig;
        }

        public override double GetSquere()
        {
            return wide * wide;
        }
    }
}

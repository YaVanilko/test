using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Part
    {
        private string model = "SomeModel";
        private int cost;
        private string brand = "SomeBrand";

        public Part(string model)
        {
            this.model = model;
        }
        public Part(string model, int cost)
            : this(model)
        {
            this.cost = cost;
        }
        public Part(string model, int cost, string brand)
            : this(model, cost)
        {
            this.brand = brand;
        }

        public string Model
        {
            get { return model; }
        }
        public int Cost
        {
            get { return cost; }
        }
        public string Brand
        {
            get { return brand; }
        }
    }
}

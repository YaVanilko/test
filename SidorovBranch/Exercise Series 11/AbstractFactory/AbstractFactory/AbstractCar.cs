using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractCar
    {
        public readonly string brend;
        public readonly string model;

        private List<Part> listCarsPart;

        private int direction;
        private int speed;
        private bool light;
        private int fuel;

        public AbstractCar(string brand, string model)
        {
            this.brend = brand;
            this.model = model;
        }
        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public bool Light
        {
            get { return light; }
            set { light = value; }
        }
        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public void SetPart(Part part)
        {
            listCarsPart.Add(part);
        }
        public bool RemovePart(int index)
        {
            if (index >= listCarsPart.Count)
            { 
                listCarsPart.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatsFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            // somewhere in Main
            IMother<Cat> motherCat = new BlackCatMother();
            Cat kitten = motherCat.Birth();
            Console.WriteLine(kitten.GetColor());

            Console.ReadKey();
        }
    }


    class Cat
    {
        public enum EColor
        {
            Black,
            Red,
            Blue,
            Purple,
            Green
        }

        protected readonly EColor color;

        public string GetColor() 
        {
            return color.ToString();
        }

        public Cat() { }

        public Cat(EColor color)
        {
            this.color = color;
        }
    }

    class BlackCat : Cat
    {
        public BlackCat() : base(EColor.Black) { }
    }

    class BlackCatMother : IMother<BlackCat>
    {
        public BlackCat Birth() { return new BlackCat(); }
    }

    interface IMother<out T>
    {
        T Birth();
    }
}

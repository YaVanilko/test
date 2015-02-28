using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HorseRacing
{
    class Subscriber
    {
        public string Name { get; private set; }

        public Subscriber(string name)
        {
            this.Name = name;
        }

        public void handler(string horseName)
        {
            Console.WriteLine("Я {0}, \nмоя лошадь: {1} - выиграла!", Name, horseName);
        }
    }
}

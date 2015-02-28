using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate void WinnerMessage(string horseName);

namespace HorseRacing
{
    class Horse
    {
        public event WinnerMessage WhoWins;

        public string Name { get; private set; }

        public Horse(string name)
        {
            this.Name = name;
        }

        public void IsWinner()
        {
            if (WhoWins != null)
                WhoWins(this.Name);
        }
    }
}

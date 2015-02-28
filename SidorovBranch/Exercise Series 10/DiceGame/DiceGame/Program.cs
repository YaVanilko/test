using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IRandom
    {
        void NextBytes(byte[] temp);

    }

    public class RandomDefault : Random, IRandom
    {
        void IRandom.NextBytes(byte[] temp)
        {
            base.NextBytes(temp);
        }
    }

    public class MyClassForGame
    {
        public static byte[] MoveDiceGame(byte diceCount, IRandom rand = null)
        {
            if (rand == null)
            {
                rand = new RandomDefault();
            }

            byte[] buffer = new byte[diceCount];

            rand.NextBytes(buffer);

            return buffer;
        }
    }
}
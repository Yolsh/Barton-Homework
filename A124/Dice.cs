using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class Dice
    {
        private int sidesCount;
        private Random rand = new Random();

        public Dice()
        {
            sidesCount = 6;
        }

        public Dice(int sides)
        {
            sidesCount = sides;
        }

        public int GetSideCount()
        {
            return sidesCount;
        }

        public int Roll()
        {
            return rand.Next(1, sidesCount + 1);
        }
    }
}

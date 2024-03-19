using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    public class Square : Drawable
    {
        private int width;

        public Square(int side)
        {
            width = side;
        }

        public override void draw()
        {
            for (int y = 0; y < width; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

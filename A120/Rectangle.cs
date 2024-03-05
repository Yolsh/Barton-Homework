using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120
{
    public class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int Width, int Height)
        {
            width = Width;
            height = Height;
        }

        public int CalculateArea()
        {
            return width * height;
        }
    }
}

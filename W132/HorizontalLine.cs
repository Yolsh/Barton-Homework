using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    public class HorizontalLine : Drawable
    {
        private int length;

        public HorizontalLine(int inLength)
        {
            length = inLength;
        }

        public override void draw()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write('*');
            }
        }
    }
}

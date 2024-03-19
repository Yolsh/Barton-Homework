using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Drawable> shapes = new List<Drawable>();

            shapes.Add(new Square(3));
            shapes.Add(new Square(5));

            shapes.Add(new VerticalLine(3));
            shapes.Add(new VerticalLine(5));

            shapes.Add(new Pyramid(5));
            shapes.Add(new Pyramid(2));

            shapes.Add(new HorizontalLine(3));
            shapes.Add(new HorizontalLine(5));

            foreach (Drawable shape in shapes)
            {
                shape.draw();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

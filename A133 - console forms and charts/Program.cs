using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A133___console_forms_and_charts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Xvals = new int[10];
            int[] Yvals = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter a new X value");
                Xvals[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a new Y value");
                Yvals[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Give a Description of the graph");
            string Desc = Console.ReadLine();

            Console.WriteLine("Left or Right hand mode?");
            bool LH;
            if (Console.ReadLine().ToUpper() == "L") LH = true;
            else LH = false;

            Console.Write("press a key to load form");
            while(!Console.KeyAvailable)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }

            MyConsoleForm form = new MyConsoleForm(Xvals, Yvals, Desc, LH);
            form.ShowDialog();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107
{
    internal class Program
    {
        static List<List<string>> College = new List<List<string>>();

        static void AddClass()
        {
            Console.WriteLine(Console.ReadKey().Key);
            Console.WriteLine("What is the name of the new class?");
            College.Add(new List<string>());
            College[College.Count-1].Add(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine("student " + i + "'s Name");
                College[College.Count-1].Add(Console.ReadLine());
                i++;
            } while (!Console.ReadKey().Equals("scape"));
            Main();
        }

        static void RemoveClass()
        {
            Console.WriteLine("What class would you like to delete?");
            string RmClass = Console.ReadLine();
            Console.WriteLine("are you sure you want to delete " + RmClass + " [Y/N]");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                for (int i = 0; i < College.Count; i++)
                {
                    if (College[i].Contains(RmClass))
                    {
                        College.RemoveAt(i);
                        break;
                    }
                }
            }
            Main();
        }

        static void AddStudent()
        {
            Console.WriteLine("Name of class?");
            string ClassName = Console.ReadLine();
            Console.WriteLine("Name of student?");
            string StudentName = Console.ReadLine();
            for (int i = 0; i < College.Count; i++)
            {
                (College[i].Contains(ClassName)) ? College[i].Add(StudentName) : Console.WriteLine("thats not a current class, perhaps try adding a new class")
                Main();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("would you like to do?");
            Console.WriteLine("1 - add a class");
            Console.WriteLine("2 - remove a class");
            Console.WriteLine("3 - add a student to a class");
            Console.WriteLine("4 - Remove a student from a class");
            Console.WriteLine("5 - show class");
            Console.WriteLine("6 - show all classes");
            Console.WriteLine("7 - Leave");
            string routine;
            do
            {
                routine = Console.ReadLine();
                switch (routine)
                {
                    case "1":
                        AddClass();
                        break;

                    case "2":
                        RemoveClass();
                        break;

                    case "3":

                        break;

                    case "7":
                        Environment.Exit(0);
                        break;
                }
            } while (routine != "1" && routine != "2" && routine != "3" && routine != "4" && routine != "5" && routine != "6" && routine != "7");
            Console.ReadKey();
        }
    }
}

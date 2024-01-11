using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace A107
{
    internal class A107
    {
        static List<List<string>> College = new List<List<string>>();

        static void Disp_College()
        {
            for (int i = 0; i < College.Count; i++)
            {
                for (int j = 0;  j < College[i].Count; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(College[i][j] + ": ");
                    }
                    else if (j < College[i].Count - 1)
                    {
                        Console.Write(College[i][j] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(College[i][j]);
                    }
                }
            }
            Console.ReadKey();
            menu();
        }
        static void Disp_Class()
        {
            Console.WriteLine("what class would you like to see ?");
            string Class = Console.ReadLine();
            for (int i = 0; i < College.Count; i++)
            {
                if (College[i][0] == Class)
                {
                    Console.WriteLine(Class + ": ");
                    for (int j = 0; j < College[i].Count; j++)
                    {
                        Console.WriteLine((j == College[i].Count) ? College[i][j] : College[i][j] + ", ");
                    }
                }
            }
        }

        static void AddClass()
        {
            Console.WriteLine("What is the name of the new class?");
            College.Add(new List<string>());
            College[College.Count-1].Add(Console.ReadLine());
            int i = 1;
            while(1 == 1)
            {
                Console.WriteLine("student " + i + "'s Name");
                string Name = Console.ReadLine();
                if (Name != "Exit")
                {
                    College[College.Count - 1].Add(Name);
                }
                else
                {
                    break;
                }
                i++;
            }
            menu();
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
            menu();
        }

        static void AddStudent()
        {
            Console.WriteLine("Name of class?");
            string ClassName = Console.ReadLine();
            Console.WriteLine("Name of student?");
            string StudentName = Console.ReadLine();
            for (int i = 0; i < College.Count; i++)
            {
                if (College[i].Contains(ClassName))
                {
                    College[i].Add(StudentName);
                }
                else
                {
                    Console.WriteLine("thats not a current class, perhaps try adding a new class");
                }
            }
            menu();
        }

        static void RemoveStudent()
        {
            Console.WriteLine("What Class would you like to remove them from");
            string Class = Console.ReadLine();
            Console.WriteLine("What student would you like to remove?");
            string Student = Console.ReadLine();
            for (int i = 0; i < College.Count; i++)
            {
                if (College[i].Contains(Student))
                {
                    College[i].Remove(Student);
                }
            }
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("would you like to do?");
            Console.WriteLine("1 - add a class");
            Console.WriteLine("2 - remove a class");
            Console.WriteLine("3 - add a student to a class");
            Console.WriteLine("4 - Remove a student from a class");
            Console.WriteLine("5 - show class");
            Console.WriteLine("6 - show whole college");
            Console.WriteLine("7 - Leave");
            string routine;
            do
            {
                routine = Console.ReadLine();
                switch (routine)
                {
                    case "1": AddClass(); break;
                    case "2": RemoveClass(); break;
                    case "3": AddStudent(); break;
                    case "4": RemoveStudent(); break;
                    case "5": Disp_Class(); break;
                    case "6": Disp_College(); break;
                    case "7": Environment.Exit(0); break;
                    default: Console.WriteLine("thats not a valid option, Try again"); break;
                }
            } while (routine != "1" && routine != "2" && routine != "3" && routine != "4" && routine != "5" && routine != "6" && routine != "7");
        }

        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }
    }
}

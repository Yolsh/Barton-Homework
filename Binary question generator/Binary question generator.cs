using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_question_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  //Create a random number generator variable.

            Console.WriteLine("How many questions would you like?");
            int iterator = int.Parse(Console.ReadLine());   //Ask how many questions they want.

            for (int i = 0; i < iterator; i++)
            {
                int selector = rnd.Next(0, 5);   //Select what kind of question we are giving them.
                int number = rnd.Next(1, 255);   //Select a random number between 1 and 255

                switch (selector)
                {
                    case 0:   //for each type of question have a switch case
                        string binary = Convert.ToString(number, 2);   //generate binary string

                        Console.WriteLine("convert the following Binary number to Denary: " + binary);
                        int ans0 = int.Parse(Console.ReadLine());   //Read answer

                        Console.WriteLine((ans0 == number)? "Correct" : "Incorrect; the answer was: " + number); //Check answer is right

                        break;

                    case 1:
                        string bin1 = Convert.ToString(number, 2);

                        Console.WriteLine("Convert the following Denary to Binary: " + number);
                        string ans1 = Console.ReadLine();

                        Console.WriteLine((ans1 == bin1)? "Correct" : "Incorrect; the answer was: " + bin1);

                        break;

                    case 2:
                        string bin2 = Convert.ToString(number, 2);
                        string hex2 = Convert.ToString(number, 16);

                        Console.WriteLine("Convert the following from Binary to Hexadecimal: " + bin2);
                        string ans2 = Console.ReadLine();

                        Console.WriteLine((ans2 == hex2) ? "Correct" : "Incorrect; the answer was: " + hex2);

                        break;

                    case 3:
                        string bin3 = Convert.ToString(number, 2);
                        string hex3 = Convert.ToString(number, 16);

                        Console.WriteLine("Convert the following from Hexadecimal to Binary: " + hex3);
                        string ans3 = Console.ReadLine();

                        Console.WriteLine((ans3 == bin3) ? "Correct" : "Incorrect; the answer was: " + bin3);

                        break;

                    case 4:
                        string hex4 = Convert.ToString(number, 16);

                        Console.WriteLine("Convert the following from Denary to Hexadecimal: " + number);
                        string ans4 = Console.ReadLine();

                        Console.WriteLine((ans4 == hex4) ? "Correct" : "Incorrect; the answer was: " + hex4);

                        break;

                    case 5:
                        string hex5 = Convert.ToString(number, 16);

                        Console.WriteLine("Convert the following from Hexadecimal to Denary: " + hex5);
                        int ans5 = int.Parse(Console.ReadLine());

                        Console.WriteLine((ans5 == number) ? "Correct" : "Incorrect; the answer was: " + number);

                        break;
                }
            }

            Console.ReadKey();
        }
    }
}

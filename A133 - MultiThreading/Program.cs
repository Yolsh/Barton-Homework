using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A133___MultiThreading
{
    internal class Program
    {
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int PrimesToCheck = 10;
            Task<bool>[] results = new Task<bool>[PrimesToCheck];

            Console.WriteLine(Task.Run(() => IsPrime(7)).Result);

            for (int i = 0; i < PrimesToCheck; i++)
            {
                results[i] = new Task<bool>(() => IsPrime(i));
                results[i].Start();
            }

            Task.WaitAll(results);

            //Console.WriteLine(results[7].Result);

            for (int i = 0; i < PrimesToCheck; i++)
            {
                Console.WriteLine(results[i].Result ? $"{i} is a Prime number" : $"{i} is not Prime");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 93, 46, 85, 90, 66, 57, 75, 5, 33, 45 };
            foreach (int i in ints)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            BubbleSort(ints);
            foreach (int i in ints)
            {
                Console.Write(i + ", ");
            }
            Console.ReadKey();
        }

        static void BubbleSort(int[] arr)
        {
            int count = 0;
            while (count < arr.Length)
            {
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;
                    }
                }
                count++;
            }
        }
    }
}

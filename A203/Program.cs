using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = {2, 6, 14, 24, 39, 57, 63, 88};
            Console.WriteLine(BinSearch(65, A, 0, A.Length-1, (A.Length-1)/2).ToString());
            Console.ReadKey();
        }

        static bool BinSearch(int find, int[] arr, int s, int e, int m)
        {
            if (arr[m] == find) return true;
            else if (m == s || m == e) return false;
            else if (arr[m] > find) return BinSearch(find, arr, s, m, s + m / 2);
            else if (arr[m] < find) return BinSearch(find, arr, m, e, m + e/m);
            return false;
        }
    }
}

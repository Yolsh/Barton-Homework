using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace A205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] checkArr = { 4, 16, 20, 37, 42, 58, 89};
            Console.WriteLine(IsHappyNumber(86, checkArr));
            Console.ReadKey();
        }

        static bool IsHappyNumber(int num, int[] checkArr) => checkArr.Contains(num) ? false : num.ToString().Length == 1 ? num == 1 ? true : IsHappyNumber(num * num, checkArr) : IsHappyNumber(num.ToString().Aggregate(0, (tot, cur) => tot += int.Parse(cur.ToString()) * int.Parse(cur.ToString())), checkArr);
    }
}

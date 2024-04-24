using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            Account ac1 = new Account(1000);
            accounts.Add(ac1);
            FixedAccount ac2 = new FixedAccount(1000, 100);
            accounts.Add(ac2);

            for (int i = 0; i < 10; i++)
            {
                foreach (Account account in accounts)
                {
                    account.MakeWithdrawal(110);
                    Console.WriteLine($"{accounts.IndexOf(account)}: {account.GetBalance()}");
                }
            }

            Console.ReadKey();
        }
    }
}

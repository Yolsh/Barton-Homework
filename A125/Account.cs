﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A125
{
    public class Account
    {
        protected int balance;

        public Account(int startBalance)
        {
            balance = startBalance;
        }
        public int GetBalance()
        {
            return balance;
        }
        public void MakeDeposit(int amount)
        {
            balance += amount;
        }
        public virtual bool MakeWithdrawal(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }
}

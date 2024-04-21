using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A125
{
    public class FixedAccount : Account
    {
        public int WithdrawalFee { get; private set; }

        public FixedAccount(int startBalance, int inWithdrawalFee) : base(startBalance)
        {
            WithdrawalFee = inWithdrawalFee;
        }

        public override bool MakeWithdrawal(int amount)
        {
            if (base.MakeWithdrawal(amount))
            {
                if (balance != 0)
                {
                    if (balance - WithdrawalFee <= 0) balance = 0;
                    else balance -= WithdrawalFee;
                }
                return true;
            }
            return false;
        }
    }
}

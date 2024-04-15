using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class DamagePlus : Item
    {
        public DamagePlus() 
        {
            Name = "D+";
        }

        public override void UseItem(Warrior UsedOn)
        {
            UsedOn.attackDamage *= 2;
        }
    }
}

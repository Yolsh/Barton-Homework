using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class HealingPotion : Item
    {
        public HealingPotion()
        {
            Name = "HP";
        }
        public override void UseItem(Warrior UsedOn)
        {
            if (UsedOn.GetMaxHealth() - 35 >= UsedOn.GetHealth()) UsedOn.currentHealth += 35;
            else UsedOn.currentHealth = UsedOn.GetMaxHealth();
        }
    }
}

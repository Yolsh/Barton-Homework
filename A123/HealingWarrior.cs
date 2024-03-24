using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A123
{
    public class HealingWarrior : Warrior
    {
        private bool haveHealed;

        public HealingWarrior(string myName) : base(myName)
        {
            haveHealed = false;
        }

        public bool getHaveHealed()
        {
            return haveHealed;
        }

        public void heal()
        {
            if (!haveHealed)
            {
                currentHealth = maxHealth;
                haveHealed = true;
            }
            else
            {
                throw new NotSupportedException("Your warrior has already healed");
            }
        }
    }
}

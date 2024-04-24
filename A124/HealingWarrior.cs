using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class HealingWarrior : Warrior
    {
        private bool haveHealed;

        public HealingWarrior(string myName, Random inRand) : base(myName, inRand)
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

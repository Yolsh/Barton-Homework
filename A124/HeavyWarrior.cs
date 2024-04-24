using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class HeavyWarrior : Warrior
    {
        protected int ArmourHealth;
        public HeavyWarrior(string myName, Random inRand) : base(myName, inRand)
        {
            ArmourHealth = 50;
            attackDamage += 5;
        }

        public int getArmorHealth() { return ArmourHealth;}

        public override void Attack(Warrior enemy, int diceRoll)
        {
            enemy.Attacked(diceRoll, attackDamage);
        }

        public override void Attacked(int diceRoll, int attackedDamage)
        {
            if (ArmourHealth > 0)
            {
                ArmourHealth -= (int) (diceRoll * attackedDamage * 80) /100;
                currentHealth -= (int) (diceRoll * attackedDamage * 20) /100;
            }
            else base.Attacked(diceRoll, attackedDamage);
        }
    }
}

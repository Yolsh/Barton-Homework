using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124
{
    public class Warrior
    {
        protected string name;
        public int currentHealth;
        protected int maxHealth;
        public int attackDamage;
        protected Item[] Inventory;
        private Random random;

        public Warrior(string myName, Random inRand)
        {
            name = myName;
            maxHealth = 100;
            currentHealth = maxHealth;
            attackDamage = 10;
            Inventory = new Item[3];
            random = inRand;
            FillInventory();
        }

        public int GetHealth()
        {
            return currentHealth;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }

        public string GetName()
        {
            return name;
        }

        public bool isAlive()
        {
            if (currentHealth > 0)
            {
                return true;
            }
            return false;
        }

        public virtual void Attack(Warrior enemy, int diceRoll)
        {
            enemy.Attacked(diceRoll, attackDamage);
        }

        public virtual void Attacked(int diceRoll, int attackedDamage)
        {
            currentHealth -= diceRoll * attackedDamage;
        }

        public virtual string[] GetInventory()
        {
            string[] ItemNames = new string[3];
            for(int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] is null) ItemNames[i] = "  ";
                else ItemNames[i] = Inventory[i].GetName();
            }
            return ItemNames;
        }

        public virtual void UseInventory(int slotNumber)
        {
            slotNumber -= 1;
            if (slotNumber > 3) throw new ArgumentOutOfRangeException();
            Inventory[slotNumber].UseItem(this);
            Inventory[slotNumber] = null;
        }

        private void FillInventory()
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (random.Next(2) == 0) Inventory[i] = new HealingPotion();
                else Inventory[i] = new DamagePlus();
            }
        }
    }
}

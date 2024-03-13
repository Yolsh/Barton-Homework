﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122
{
    public class Warrior
    {
        private string name;
        private int currentHealth;
        private int maxHealth;
        private int attackDamage;

        public Warrior(string myName)
        {
            name = myName;
            maxHealth = 100;
            currentHealth = maxHealth;
            attackDamage = 10;
        }

        public int GetHealth()
        {
            return currentHealth;
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

        public void Attack(Warrior enemy, int diceRoll)
        {
            enemy.Attacked(diceRoll, attackDamage);
        }

        public void Attacked(int diceRoll, int attackedDamage)
        {
            currentHealth -= diceRoll * attackedDamage;
        }
    }
}

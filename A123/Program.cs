using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many sides should the dice have.");
            Dice mydice = new Dice(int.Parse(Console.ReadLine()));

            HealingWarrior hero = new HealingWarrior("Josh");
            HealingWarrior enemy = new HealingWarrior("Joe");

            Console.WriteLine($"{hero.GetName()} has a starting health of {hero.GetHealth()}");
            Console.WriteLine($"{enemy.GetName()} has a starting health of {enemy.GetHealth()}\n");
            Console.ReadKey();
            Console.Clear();

            while (hero.isAlive() && enemy.isAlive())
            {
                enemy.Attack(hero, mydice.Roll());
                Console.WriteLine($"{enemy.GetName()} has a current health of {enemy.GetHealth()}\n");
                Heal(enemy);
                hero.Attack(enemy, mydice.Roll());
                Console.WriteLine($"{hero.GetName()} has a current health of {hero.GetHealth()}\n");
                Heal(hero);
            }

            Console.WriteLine((hero.isAlive()) ? $"{hero.GetName()} has won" : $"{enemy.GetName()} has won");
            Console.ReadKey();
        }

        static void Heal(HealingWarrior warrior)
        {
            Console.WriteLine($"{warrior.GetName()} would you like to heal?");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "yes")
            {
                try
                {
                    warrior.heal();
                }
                catch (NotSupportedException e)
                {
                    Console.WriteLine($"sorry {warrior.GetName()} {e.Message}");
                    return;
                }
                Console.WriteLine($"{warrior.GetName()} has healed back to {warrior.GetHealth()}");
            }
        }
    }
}

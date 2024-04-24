using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A124
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("how many sides should the dice have.");
            Dice mydice = new Dice(int.Parse(Console.ReadLine()));

            HeavyWarrior hero = new HeavyWarrior("Josh", rand);
            HealingWarrior enemy = new HealingWarrior("Joe", rand);

            Console.WriteLine($"{hero.GetName()} has a starting health of {hero.GetHealth()}");
            Console.WriteLine($"{enemy.GetName()} has a starting health of {enemy.GetHealth()}\n");
            Console.ReadKey();
            Console.Clear();

            Go(enemy, hero, mydice);

            Console.Clear();
            Center((hero.isAlive()) ? $"{hero.GetName()} has won" : $"{enemy.GetName()} has won");
            Console.ReadKey();
        }

        static void Heal(HealingWarrior warrior)
        {
            InputBar($"{warrior.GetName()} would you like to heal?");
            string ans = Console.ReadLine();
            if (ans.ToLower() == "yes")
            {
                try
                {
                    warrior.heal();
                }
                catch (NotSupportedException e)
                {
                    Center($"sorry {warrior.GetName()} {e.Message}");
                    return;
                }
                Center($"{warrior.GetName()} has healed back to {warrior.GetHealth()}");
            }
        }

        static void Names(Warrior enemy, Warrior hero)
        {
            Console.Clear();

            Console.Write(hero.GetName());
            Console.SetCursorPosition(Console.WindowWidth - enemy.GetName().Length, 0);
            Console.Write(enemy.GetName());
            Console.SetCursorPosition(0, 1);

            Console.Write(HealthString(hero));
            Console.SetCursorPosition(Console.WindowWidth - HealthString(enemy).Length, 1);
            Console.Write(HealthString(enemy));

            Console.SetCursorPosition(0, 2);
            Console.Write("__________");
            Console.SetCursorPosition(0, 3);
            foreach(string name in hero.GetInventory())
            {
                Console.Write($"|{name}");
            }
            Console.Write("|");
            Console.SetCursorPosition(0, 4);
            Console.Write("----------");

            Console.SetCursorPosition(Console.WindowWidth - 10, 2);
            Console.Write("__________");
            Console.SetCursorPosition(Console.WindowWidth - 10, 3);
            foreach (string name in enemy.GetInventory())
            {
                Console.Write($"|{name}");
            }
            Console.Write("|");
            Console.SetCursorPosition(Console.WindowWidth - 10, 4);
            Console.Write("----------");
        }

        static void Go(HealingWarrior enemy, HeavyWarrior hero, Dice mydice)
        {
            while (hero.isAlive() && enemy.isAlive())
            {
                Names(enemy, hero);

                enemy.Attack(hero, mydice.Roll());
                Center($"{enemy.GetName()} has a current health of {enemy.GetHealth()}");
                SelectItem(enemy);
                Heal(enemy);

                Names(enemy, hero);

                hero.Attack(enemy, mydice.Roll());
                Center($"{hero.GetName()} has a current health of {hero.GetHealth()} and his armour is at {hero.getArmorHealth()}");
                SelectItem(enemy);
                if (hero.getArmorHealth() <= 0)
                {
                    InputBar("your armour is destroyed.");
                    Console.ReadKey();
                }
                else
                {
                    InputBar("");
                    Console.ReadKey();
                }
            }
        }

        static string HealthString(Warrior person)
        {
            char[] healthbar = new char[(int)person.GetMaxHealth() / 5];
            healthbar[0] = '[';

            for (int i = 1; i < (int)person.GetHealth() / 5; i++)
            {
                healthbar[i] = '\u2588';
            }

            healthbar[healthbar.Length - 1] = ']';
            string healthstring = new string(healthbar);
            return healthstring;
        }

        static void Center(string inString)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2) - inString.Length / 2, Console.WindowHeight / 2);
            Console.Write(inString);
        }

        static void InputBar(string inString)
        {
            if (inString.Length < 36)
            {
                int l = inString.Length;
                for (int i = 0; i < 36 - l; i++) inString += " ";
            }
            Console.SetCursorPosition((Console.WindowWidth / 2) - (40 / 2), Console.WindowHeight - 3);
            Console.Write($"________________________________________");
            Console.SetCursorPosition((Console.WindowWidth / 2) - (40 / 2), Console.WindowHeight - 2);
            Console.Write($"| {inString} |");
            Console.SetCursorPosition((Console.WindowWidth / 2) - (40 / 2), Console.WindowHeight - 1);
            Console.Write("|                                      |");
            Console.SetCursorPosition((Console.WindowWidth / 2) - (40 / 2) + 1, Console.WindowHeight - 1);
        }

        static void SelectItem(Warrior person)
        {
            InputBar("Would you like to use an Item");
            string UseInventory = Console.ReadLine();
            Console.SetWindowPosition(0, 0);
            if (UseInventory.ToLower() == "yes")
            {
                InputBar("What Item would you like to use?");
                string Ans = Console.ReadLine();
                Console.SetWindowPosition(0, 0);
                try
                {
                    person.UseInventory(int.Parse(Ans));
                }
                catch (ArgumentOutOfRangeException)
                {
                    InputBar("That is Not a Valid inventory slot");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    InputBar("That is Not a Valid inventory slot");
                    Console.ReadKey();
                }
            }
        }
    }
}

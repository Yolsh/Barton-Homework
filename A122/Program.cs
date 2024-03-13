using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many sides should the dice have.");
            Dice mydice = new Dice(int.Parse(Console.ReadLine()));
            Warrior hero = new Warrior("Josh");
            Warrior enemy = new Warrior("Joe");
            Console.WriteLine($"{hero.GetName()} has a current health of {hero.GetHealth()}");
            Console.WriteLine($"{enemy.GetName()} has a current health of {enemy.GetHealth()}");
            while(hero.isAlive() && enemy.isAlive())
            {
                enemy.Attack(hero, mydice.Roll());
                Console.WriteLine($"{enemy.GetName()} has a current health of {enemy.GetHealth()}");
                hero.Attack(enemy, mydice.Roll());
                Console.WriteLine($"{hero.GetName()} has a current health of {hero.GetHealth()}");
            }
            Console.WriteLine((hero.isAlive())? $"{hero.GetName()} has won" : $"{enemy.GetName()} has won" );
            Console.ReadKey();
        }
    }
}

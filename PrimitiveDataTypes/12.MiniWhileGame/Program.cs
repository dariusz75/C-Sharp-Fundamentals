using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.MiniWhileGame
{
    class Program
    {
        static void Main()
        {
            Random randomDamage = new Random();

            string warrior1Name = "Red Worrior";
            string warrior2Name = "Black Worrior";
            int warrior1Damage = 0;
            int warrior2Damage = 0;
            int warrior1Health = 100;
            int warrior2Health = 100;
            bool gameOver = false;

            while (!gameOver)
            {
                warrior1Damage = randomDamage.Next(1, 10);
                warrior2Damage = randomDamage.Next(1, 10);

                warrior1Health = warrior1Health - warrior2Damage;
                warrior2Health = warrior2Health - warrior1Damage;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{warrior1Name} inflicted {warrior1Damage} damage upon {warrior2Name}. {warrior2Name} has {warrior2Health} health points left!");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{warrior2Name} inflicted {warrior2Damage} damage upon {warrior1Name}. {warrior1Name} has {warrior1Health} health points left!");

                if (warrior1Health <= 0)
                {
                    gameOver = true;
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The game is over and the Winner is {warrior2Name}!");
                }
                else if (warrior2Health <= 0)
                {
                    gameOver = true;
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The game is over and the Winner is {warrior1Name}!");
                }

            }
        }
    }
}

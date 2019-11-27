using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.WhileLoop
{
    class Program
    {
        static void Main()
        {
            int number = 0;
            int min = 20;
            int max = 30;
            bool numberInRange = false;

            while (!numberInRange)
            {
                Console.WriteLine($"Enter a number btween {min} and {max}:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number >= min && number <= max)
                {
                    numberInRange = true;
                    Console.WriteLine($"Perfect, your number is in the range!");
                }
                else
                {
                    Console.WriteLine($"Your number is not in the range!");
                    Console.WriteLine($"Please try again.");
                   
                }
            }
        }
    }
}

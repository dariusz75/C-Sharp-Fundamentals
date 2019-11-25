using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Switch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Please choose one of the folloing units: mm, cm or m");
            string unitsGiven = Console.ReadLine();

            switch (unitsGiven)
            {
                case "mm":
                    Console.WriteLine($"The units are milimeters");
                    break;
                case "cm":
                    Console.WriteLine($"The units are centimeters");
                    break;
                case "m":
                    Console.WriteLine($"The units are meters");
                    break;
                default:
                    Console.WriteLine($"The chosen units are not correct");
                    break;
            }
        }
    }
}

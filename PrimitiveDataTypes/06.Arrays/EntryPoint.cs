using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Arrays
{
    class EntryPoint
    {
        static void Main()
        {
            int[] myNumbers = {5, 2, 9, 33, 999};
            Console.WriteLine(myNumbers[1]); // outputs 2

            int[] myNewArray = new int[5]; // creates array with 5 values default to 0
            Console.WriteLine(myNewArray[2]); // outputs 0

            int[] myNewTestArray = new int[5];
            myNewTestArray[0] = 2;
            myNewTestArray[1] = 22;
            myNewTestArray[2] = 222;
            myNewTestArray[3] = 2222;
            myNewTestArray[4] = 22222;
            Console.WriteLine(myNewTestArray[4]); // outputs 22222

            string[] fruit = {"apple", "pear", "plum", "orange", "lemon"};
            Console.WriteLine(fruit[0]); // outputs apple
            fruit[0] = "banana";
            Console.WriteLine(fruit[0]); // outputs banana

        }
    }
}

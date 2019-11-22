using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IfElse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please antry a number");
            int givenNumber = Convert.ToInt32(Console.ReadLine());

            if (givenNumber %2 == 0)
            {
                Console.WriteLine($"The given number is {givenNumber} and it's even.");    
            }
            else
            {
                Console.WriteLine($"The given number is {givenNumber} and it's odd.");
            }

            Console.WriteLine("Please antry another number");
            int anotherGivenNumber = Convert.ToInt32(Console.ReadLine());

            string anotherGivenNumberResult = anotherGivenNumber % 2 == 0 ? $"The given number is {anotherGivenNumber} and it's even." : $"The given number is {anotherGivenNumber} and it's odd.";
            Console.WriteLine(anotherGivenNumberResult);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingStrings
{
    class EntryPoint
    {
        static void Main()
        {
            string firstName = "John";
            string surName = "Smith";
            int age = 80;

            string johnDetails = firstName + " " + surName + " is " + age + " years old.";
            System.Console.WriteLine(johnDetails);

            string johnDetails2 = string.Format("{0} {1} is {2} years old.", firstName, surName, age);
            System.Console.WriteLine(johnDetails2);

            string johnDetails3 = string.Format("{0} {1} is very old {0} and he is {2} years old {0}.", firstName, surName, age);
            System.Console.WriteLine(johnDetails3);

            string johnDetails4 = $"{firstName} {surName} is {age} years old.";
            System.Console.WriteLine(johnDetails4);
        }
    }
}

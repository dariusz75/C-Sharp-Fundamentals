using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SpecialCharacters
{
    class Program
    {
        static void Main()
        {
            string example1 = "C:\\Program Files\\Microsoft Programs\\VisualStudio";
            Console.WriteLine(example1);

            string example2 = @"C:\Program Files\Microsoft Programs\VisualStudio";
            Console.WriteLine(example2);
        }
    }
}

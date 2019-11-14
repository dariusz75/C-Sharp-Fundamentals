using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        char characterX = 'x';
        System.Console.WriteLine(characterX);

        char plusSymbol = '\u00F6';
        System.Console.WriteLine(plusSymbol);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateArea(5);
            calculateArea(5, 6);
            calculateArea(5, 5, 5);

        }

        static void calculateArea(int side)
        {
            int area = side * side;

            Console.WriteLine($"The area of the {side}cm side square is {area}cm.");
        }

        static void calculateArea(int side, int Bside)
        {
            int area = side * Bside;

            Console.WriteLine($"The area of rectangular with A side of {side}cm and B side of {Bside}cm is {area}cm.");
        }

        static void calculateArea(int side, int Bside, int Cside)
        {
            float halfDiameter = ((float)side + (float)Bside + (float)Cside) / 2;
            double area = Math.Round(Math.Sqrt(halfDiameter * (halfDiameter - side) * (halfDiameter - Bside) * (halfDiameter - Cside)), 2);

            Console.WriteLine($"halfDiameter is {halfDiameter}");
            Console.WriteLine($"The area of triangle with A side of {side}cm, B side of {Bside}cm and C side of {Cside}cm is {area}cm.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ArraysOutputting
{
    class Program
    {
        static void Main()
        {
            Random randomlyGeneratedNumber = new Random();

            double[] temperatures = new double[20];
            double[] lowTemperatures = new double[temperatures.Length];
            double[] mediumTemperatures = new double[temperatures.Length];
            double[] highTemperatures = new double[temperatures.Length];
            double[] outOfRangeTemperatures = new double[temperatures.Length];

            int lowTemperaturesIndex = 0;
            int mediumTemperaturesIndex = 0;
            int highTemperaturesIndex = 0;
            int outOfRangeTemperaturesIndex = 0;

            Console.Write("Range 1 to 10: " +
                          "\n" +
                          "\nLow range temperatures: " +
                          "\n" +
                          "\nMedium range temperatures: " +
                          "\n" +
                          "\nHigh range temperatures: " +
                          "\n" +
                          "\nOut of range temperatures: " +
                          "\n"
                          );

            for (int i = 0; i < temperatures.Length; i++)
            {                
                double temperature = randomlyGeneratedNumber.Next(0, 40);
                temperatures[i] = temperature;
                Console.WriteLine(temperatures[i]);
            }

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] <= 10)
                {
                    lowTemperatures[lowTemperaturesIndex] = temperatures[i];
                    lowTemperaturesIndex++;
                    Console.WriteLine(lowTemperatures[i]);
                }
                else if (temperatures[i] > 10 && temperatures[i] <= 20)
                {
                    mediumTemperatures[mediumTemperaturesIndex] = temperatures[i];
                    mediumTemperaturesIndex++;
                    Console.WriteLine(mediumTemperatures[i]);
                }
                else if (temperatures[i] > 20 && temperatures[i] <= 30)
                {
                    highTemperatures[highTemperaturesIndex] = temperatures[i];
                    highTemperaturesIndex++;
                    Console.WriteLine(highTemperatures[i]);
                }
                else if (temperatures[i] > 30)
                {
                    outOfRangeTemperatures[outOfRangeTemperaturesIndex] = temperatures[i];
                    outOfRangeTemperaturesIndex++;
                    Console.WriteLine(outOfRangeTemperatures[i]);
                }
            }
        }
    }
}

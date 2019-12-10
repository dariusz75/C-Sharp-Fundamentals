using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArraysClonning
{
    class Program
    {
        static void Main()
        {
            int[] array1 = {1, 2, 3, 4, 5};
            int[] array2 = (int[])array1.Clone();

            int[] array3 = new int[array1.Length];
            Array.Copy(array1, array3, array1.Length);

            CloneArray(array1, out int[] array4);

            Console.WriteLine(array1[1]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array3[1]);
        }

        static void CloneArray(int[] sourceArray, out int[] clonedArray)
        {
            clonedArray = new int[sourceArray.Length];

            for (int i = 0; i < sourceArray.Length; i++)
            {
                clonedArray[i] = sourceArray[i];
            }

        }
    }
}

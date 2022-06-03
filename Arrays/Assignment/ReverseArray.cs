using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays.Assignment
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40, 50, 60, 70,78, 80, 90 };
            int n = intArray.Length;
            Console.WriteLine("Original Array:");
            for (int i = 0; i <n; i++)

                Console.WriteLine(intArray[i] + "  ");

            Console.WriteLine();

            Console.WriteLine("Original Array printed in reverse order:");
            for (int i = n - 1; i >= 0; i--)
                Console.Write(intArray[i] + "  ");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class MinMaxArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int i, max, min, n;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr1[0];
            min = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", max);
            Console.Write("Minimum element is : {0}\n\n", min);
        }
    }
}

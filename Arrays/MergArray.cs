using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class MergArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[10];

            int i = 0;
            int j = 0;
            Console.WriteLine("Enter Array 1  : ");
            for (  i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter  Array 2 : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0, j = 0; i < 5; i++)
            {
                arr3[j++] = arr1[i];
            }
            for (i = 0; i < 5; i++)
            {
                arr3[j++] = arr2[i];
            }

            Console.WriteLine("Array 3  : ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr3[i]);

            }
        }
    }
}

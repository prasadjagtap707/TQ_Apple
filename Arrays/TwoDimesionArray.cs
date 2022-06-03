using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class TwoDimesionArray
    {
        static void Main(string[] args)
        {
            // int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[] a = new int[10];
            int[,] a2 = new int[3, 4];

            Console.WriteLine(a2.Length);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter elements on row :" + i);
                for (int j = 0; j < 4; j++)
                {
                    // Console.Write(a[i, j] + " ");
                    a2[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("");


            }
                Console.Write("Array Elements\n");
                for (int k = 0; k < 3; k++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(a2[k, j] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            
        }
    }
}

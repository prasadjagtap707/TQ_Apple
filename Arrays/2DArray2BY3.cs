using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class _2DArray2BY3
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[,] a2 = new int[2, 3];

            Console.WriteLine(a2.Length);
            int i=0, j=0;
            for ( i = 0; i < 2; i++)
            {
                Console.WriteLine("enter elements on row :" + i);
                for ( j = 0; j < 3; j++)
                {
                    // Console.Write(a[i, j] + " ");
                    a2[i, j] = int.Parse(Console.ReadLine());
                  
                }
                Console.WriteLine("");
                

            }
           
        }
    }
}

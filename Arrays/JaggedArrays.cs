using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            int[][] jagg = new int[4][];

            jagg[0] = new int[3] { 2, 3, 4 };
            jagg[1] = new int[5] { 12, 3, 4, 5, 6 };
            jagg[2] = new int[2] { 12, 4 };

            for (int n = 0; n < jagg.Length; n++)
            {
                System.Console.Write(n);

                for (int k = 0; k < jagg[n].Length; k++)
                {

                    System.Console.Write(jagg[n][k]);
                }
                System.Console.WriteLine();
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Arrays.Assignment
{
    class SumOfArrayPair
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 5, 7, -1, 5 };
            int sum = 10;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) == sum)
                    {
                        Console.WriteLine("[" + arr[i] + " " + arr[j] + "]");
                    }
                }
            }    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            int alphabet = 65;
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write ((char)(alphabet + j - 1) + " ");
                }
                Console.WriteLine();            }
        }
    }
}

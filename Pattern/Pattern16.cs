using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern16
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j >= i; j--)
                {
                    Console.Write (j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

/*
5 4 3 2 1 
5 4 3 2 
5 4 3 
5 4 
5

*/
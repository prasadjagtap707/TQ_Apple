using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern9
    {
        static void Main(string[] args)
        {
			int rows = 5;
			for (int i = rows; i >= 1; i--)
			{
				for (int j = 1; j < i; j++)
				{
                    Console.Write(" ");
				}
				for (int k = i; k <= rows; k++)
				{
                    Console.Write (k + " ");
				}
                Console.WriteLine();			}
		}
    }
}

/*
 
    5 
   4 5 
  3 4 5 
 2 3 4 5 
1 2 3 4 5

*/
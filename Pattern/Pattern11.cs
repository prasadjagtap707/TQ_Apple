using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern11
    {
        static void Main(string[] args)
        {
			int alphabet = 65;
			int rows = 5;
			for (int i = rows; i >= 1; i--)
			{
				for (int j = 1; j <= i; j++)
				{
                    Console.Write(" ");
				}
				for (int k = i; k <= 5; k++)
				{
                    Console.Write((char)(alphabet + k - 1) + " ");
				}
                Console.WriteLine();
			}
		}
    }
}
/*
     E 
    D E 
   C D E 
  B C D E 
 A B C D E

*/
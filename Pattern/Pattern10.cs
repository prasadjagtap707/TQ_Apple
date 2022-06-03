using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern10
    {
        static void Main(string[] args)
        {
			int alphabet = 65;
			int rows = 5;
			
			for (int i = 1; i <= rows; i++)
			{
				for (int j = rows; j >= i; j--)
				{
                    Console.Write(" ");
				}
				for (int k = 1; k <= i; k++)
				{
                    Console.Write((char)(alphabet + k - 1) + " ");
				}
                Console.WriteLine();
			}
		}
    }
}
/*
 *	 A 
    A B 
   A B C 
  A B C D 
 A B C D E

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern14
    {
        static void Main(string[] args)
        {
			int alphabet = 65;
			int rows = 5;
			for (int i = 1; i <= rows; i++)
			{
				for (int j = rows; j > i; j--)
				{
                    Console.Write(" ");
				}
				for (int k = 1; k <= i; k++)
				{
                    Console.Write((char)(alphabet + i - 1) + " ");
				}
                Console.WriteLine();
			}

		}
	}
}

/*
    A
   B B
  C C C
 D D D D
E E E E E

*/

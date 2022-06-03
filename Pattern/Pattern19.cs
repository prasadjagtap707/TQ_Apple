using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern19
    {
        static void Main(string[] args)
        {
			int alphabet = 65;
			int rows = 5;
			for (int i = rows; i >= 1; i--)
			{
				for (int j = 1; j <= i; j++)
				{
                    Console.Write((char)(alphabet + j - 1) + " ");
				}
                Console.WriteLine();
			}

		}
    }
}
/*
A B C D E 
A B C D 
A B C 
A B 
A

*/
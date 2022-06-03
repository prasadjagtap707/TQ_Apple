using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern17
    {
        static void Main(string[] args)
        {
			int rows = 5;
			for (int i = rows; i >= 1; i--)
			{
				for (int j = rows; j >= i; j--)
				{
                    Console.Write(j + " ");
				}
                Console.WriteLine();			}
		}
    }
}


/*
5 
5 4 
5 4 3 
5 4 3 2 
5 4 3 2 1
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern18
    {
        static void Main(string[] args)
        {
			int rows = 5;
			int temp = 1;
			for (int i = 1; i <= rows; i++)
			{
				for (int j = 1; j <= i; j++)
				{
                    Console.Write (temp + " ");
					temp++;
				}
                Console.WriteLine();			}
		}

    }
}

/*
 1 
2 3 
4 5 6 
7 8 9 10 
11 12 13 14 15

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern8
    {
        static void Main(string[] args)
        {
			int rows = 5;
			for (int i = 1; i <= rows; i++)
			{
				for (int j = rows; j > i; j--)
				{
                    Console.Write (" ");
				}
				for (int k = 1; k <= i; k++)
				{
                    Console.Write (k + " ");
				}
                Console.WriteLine();			}
		}
    }
}
/* OutPut
 * 
 *  1 
   1 2 
  1 2 3 
 1 2 3 4 
1 2 3 4 5

*/

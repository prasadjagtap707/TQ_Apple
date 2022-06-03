using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class RedBlue
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\nDivided by 3: ");
			for (int i = 1; i < 100; i++)
			{
				if (i % 3 == 0)
					Console.WriteLine("Red");
			}

			Console.WriteLine("\n\nDivided by 5: ");
			for (int i = 1; i < 100; i++)
			{
				if (i % 5 == 0)
					Console.WriteLine("Blue");
			}

			Console.WriteLine("\n\nDivided by 3 & 5: ");
			for (int i = 1; i < 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
					Console.WriteLine("RedBlue");
			}
			Console.WriteLine("\n");
		}
    }
}

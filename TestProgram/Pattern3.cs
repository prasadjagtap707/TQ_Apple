using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            int num = 5, r, c;
            char ch;
            for (r = 1; r <= num; r++)
            {
                if (r == 2 || r == 4)
                {
                    ch = 'A';
                    for (c = 1; c <= r; c++, ch++)
                        Console.Write(" "+ch);
                }
                else
                {
                    for (c = 1; c <= r; c++)
                        Console.WriteLine(" " +c);
                }
                Console.WriteLine("\n");
            }
            
        }
    }
    
}

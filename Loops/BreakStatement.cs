using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class BreakStatement
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}

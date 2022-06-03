using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class PrintSquare
    {
        static void Main(string[] args)
        {
            int n = 20;
            int square = 0, prev_x = 0;

            int x = 1;
            while (x < n)
            {
                square = (square + x + prev_x);
                Console.Write(square + " ");
                prev_x = x;
                x++;
            }

        } 
    }
}

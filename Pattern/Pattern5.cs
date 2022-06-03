using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write( i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

            /*   OutPut  
            1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5

            */
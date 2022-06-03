using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern6
    {
        static void Main(string[] args)
        {
            int alphabet = 65;
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine((char)(alphabet + i - 1) + " ");
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
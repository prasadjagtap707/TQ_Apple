﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.TestProgram
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

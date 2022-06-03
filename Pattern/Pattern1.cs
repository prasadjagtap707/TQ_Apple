using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
                for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

/*
        12345
        12345
        12345
        12345
        12345
        */
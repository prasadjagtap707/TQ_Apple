using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class Odd
    {
        static void Main(string[] args)
        {
            // 2.Write a program to print odd numbers from 521 to 229 using while loop.

            int i = 521;
            int number = 229;
                while (number<=i)
                {
                if(i%2!=0)
                    Console.WriteLine(i + " ");
                    i--;
                
                }
        }
    }
}

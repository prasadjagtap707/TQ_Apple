using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int n;
            int reversed = 0, remainder, original;
            Console.WriteLine ("Enter an integer: ");
             n= Convert.ToInt32(Console.ReadLine());
            
            original = n;

            while (n != 0)
            {
                remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n /= 10;
            }

            if (original == reversed)
                Console.WriteLine("palindrome." +original);
            else
                Console.WriteLine("not a palindrome." +original);
        }
    }
}

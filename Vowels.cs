using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character: ");
           char ch = Convert.ToChar(Console.ReadLine());


            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }

            //Console.ReadLine();
        }
    }
}

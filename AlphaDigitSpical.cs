using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class AlphaDigitSpical
    {
        static void Main(string[] args)
        {
            char input_char = '3';


            // Checking for Alphabet
            if ((input_char>= 65 && input_char <= 90)
                    || (input_char >= 97 && input_char <= 122))
                    Console.WriteLine(" Alphabet ");

                // Checking for Digits
                else if (input_char >= 48 && input_char <= 57)
                    Console.WriteLine(" Digit ");

                // Otherwise Special Character
                else
                    Console.WriteLine("Special Character");
            
        }
    }
}

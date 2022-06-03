using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int Year = 1995;
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year+" is a Leap Year.");
            }
            else
            {
                Console.WriteLine(Year+" is not a Leap Year.");
            }
                Console.ReadLine();
        }
    }
}

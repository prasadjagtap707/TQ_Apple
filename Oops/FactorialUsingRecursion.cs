using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class factorial
    {

        static long fact(int number)
        {

            if (number == 0)

            {

                return 1;

            }

            return number * fact(number - 1);

        }
        static void Main(string[] args)
            {
                Console.WriteLine("Enter a number");

                int number = Convert.ToInt32(Console.ReadLine());

                long f = fact(number);

                Console.WriteLine("{0} factorial is {1}", number, f);

                Console.ReadKey();
            }
        
    }
}

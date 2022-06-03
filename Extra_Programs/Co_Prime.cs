using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Extra_Programs
{
    class Co_Prime
    {
     
        static int __gcd(int a, int b)
        {
            // Everything divides 0
            if (a == 0 || b == 0)
                return 0;

            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return __gcd(a - b, b);

            return __gcd(a, b - a);
        }

        static void coprime(int a, int b)
        {

            if (__gcd(a, b) == 1)
                Console.WriteLine("Co-Prime");
            else
                Console.WriteLine("Not Co-Prime");
        }

        // Driver code
        public static void Main()
        {
            Console.WriteLine("Enter the 1st number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2st number ");

            int b = Convert.ToInt32(Console.ReadLine());
            coprime(a, b);
          
        }
    }
}

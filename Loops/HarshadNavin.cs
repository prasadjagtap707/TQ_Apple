using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class HarshadNavin
    {
        static bool checkHarshad(int n)
        {
            // calculate sum of digits
            int sum = 0;
            for (int temp = n; temp > 0; temp /= 10)
                sum += temp % 10;
             return (n % sum == 0);
        }
           // Driver program to test above functions
        public static void Main()
        {
            Console.WriteLine(checkHarshad(12) ? "Yes" : "No");

            Console.WriteLine(checkHarshad(15) ? "Yes" : "No");
        }
    }
}

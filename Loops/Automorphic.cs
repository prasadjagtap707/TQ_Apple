using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Loops
{
    class Automorphic
    {
        // Function to check Automorphic number
        static bool isAutomorphic(int N)
        {
            // Store the square
            int sq = N * N;
            // Start Comparing digits
            while (N > 0)
            {
                   if (N % 10 != sq % 10)
                    return false;

                // Reduce N and square
                N /= 10;
                sq /= 10;
            }

            return true;
        }

        // Driver Code
        public static void Main()
        {
            int N = 5;

            Console.Write(isAutomorphic(N) ? "Automorphic" : "Not Automorphic");
        }
    }
}

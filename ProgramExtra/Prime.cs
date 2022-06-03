using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ProgramExtra
{
    class Prime
    {
        static void Main(string[] args)
        {
            int n=121, count = 0;

            for (int i = 1; i <=n; i++)
            {
                if(n%i==0)
                {
                    count++;
                }

            }
            if (count == 2)
            {
                Console.WriteLine("Prime ");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}

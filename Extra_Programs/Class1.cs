using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Extra_Programs
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s = "Prasad Jagtap ";
            string rev = " ";

       

            for(int i=s.Length-1;i>=1;i--)
            {
                //Console.WriteLine(i);
                rev = rev + s[i];


            }
            Console.WriteLine(rev);
        }
    }
}

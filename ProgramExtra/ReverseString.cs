using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ProgramExtra
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "Prasad";
            string rev = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                rev = rev + str[i];
                

            }
            Console.WriteLine(  rev);
        }
    }
}

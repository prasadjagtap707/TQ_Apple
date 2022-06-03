using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.String
{
    class Trim
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name : ");
            string s = Console.ReadLine();
            Console.WriteLine("String Length "+s.Length);

            string ss = s.Trim();
            Console.WriteLine(" Trim string "+ss.Length);

            string s1 = s.Substring(2);
            Console.WriteLine(s1.Length);

            





        }
    }
}

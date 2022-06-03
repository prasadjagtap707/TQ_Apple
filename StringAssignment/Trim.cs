using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.StringAssignment
{
    class Trim
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name  : ");
            string str = Console.ReadLine();
            Console.WriteLine(str.Length);

            Console.WriteLine("After Trim function  : ");
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.Length);
        }
    }
}

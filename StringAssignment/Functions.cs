using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.StringAssignment
{
    class Functions
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String NAME : ");
            string str = Console.ReadLine();

           Console.WriteLine(str.IndexOf("a"));
            Console.WriteLine(str.ToLower());
            //Covert string into lower case

            Console.WriteLine(str.ToUpper());
            //Convert string into Upper case

            Console.WriteLine(str.Length+" Length of String");

            Console.WriteLine(str.Remove(2));


            string[] split = str.Split(new char[] { 'p' });
            Console.WriteLine(split[0]);
          

           // Console.WriteLine(str.Substring(2, 5));
            Console.WriteLine(str.ToCharArray());


            Console.WriteLine(str.Trim());
        }

    }
}

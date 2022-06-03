using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.String
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :  ");
            string s = Console.ReadLine();
            //s.Replace(char[s]);
            for (int i = 0; i <s.Length; i++)
            {
               // Console.Write(i);
                Console.Write((char)s[i]+1);
            }   
        }
      



    }
}

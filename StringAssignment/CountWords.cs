using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.StringAssignment
{
    class CountWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name  : ");
            string str = Console.ReadLine();
            int count = 0;
            for(int i =0;i<=str.Length-1;i++)
            {
                if(str[i] == ' ' && Char.IsLetter(str[i + 1]) && (i > 0))
                {
                    count++;
                }
            }
            count++;
            Console.WriteLine("Total count of Words : "+count);

        }
    }
}

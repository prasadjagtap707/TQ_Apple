using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.String
{
    class CountTheWord
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enetr the string ");
            string str = Console.ReadLine();
            char c = 'e';
            int res = 0;

            for (int i = 0; i < str.Length; i++)
            {

                // checking character in string
                if (str[i] == c)
                    res++;
            }
            Console.WriteLine(str);
        }
    }
}

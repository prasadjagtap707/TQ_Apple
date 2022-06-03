using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.StringAssignment
{
    class CountOccurence
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the Name :  ");
            string str = Console.ReadLine();
            char ch = 'p';

            int freq = str.Split(ch).Length - 1;
            Console.WriteLine(freq);
        }


    }
    
}

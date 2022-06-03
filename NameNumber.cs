using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple
{
    class NameNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            char digit = Convert.ToChar(Console.Read());
            switch (digit)
            {

                case '1':
                    Console.Write("One ");
                    break;

                case '2':
                    Console.Write("Two ");
                    break;

                case '3':
                    Console.Write("Three ");
                    break;

                case '4':
                    Console.Write("Four ");
                    break;

                case '5':
                    Console.Write("Five ");
                    break;


            }
        }
    }
}

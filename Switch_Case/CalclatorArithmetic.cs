using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Switch_Case
{
    class CalclatorArithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch = Convert.ToInt32(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                    break;
                case 2:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                    break;
                case 3:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Product = {0}", c);
                    break;
                case 4:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Quotient = {0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}

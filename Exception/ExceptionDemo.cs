using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TQ_Apple.Exception
{
    class ExceptionDemo
    {
        static string s = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division: " + a / b);
                Console.WriteLine("Try Ends");
                Console.WriteLine(s.ToLower());
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
         
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}

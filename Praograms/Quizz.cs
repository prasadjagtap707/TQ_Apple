using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Praograms
{
    class Quizz
    {
        static void Main(string[] args)
        {


            int choice, pin = 0, x = 0;
            string str;
            Console.WriteLine("Enter Your Name -:  ");
            str = (Console.ReadLine());
            while (true)
            {
                Console.WriteLine("WELCOME TO  "+str+" for playing Quize\n");
                Console.WriteLine("*****choice the Languange **********\n\n");

                Console.WriteLine("1. Java\n");
                Console.WriteLine("2. C# \n");
                Console.WriteLine("3. HTML \n");
                Console.WriteLine("4. JavaScript \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
            }
        }
    }
}

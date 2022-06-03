using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Praograms
{
    class Class1
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("Welcome to Stone Paper Scissor \n");
            int n = 1;
            int comp = 0, use = 0;
            while (n > 0)
            {
                Console.Write("1 - Stone 2 - Paper 3 - Scissor \n Your Choice : ");
                int? user = int.Parse(Console.ReadLine());
                Console.Write($"Computer Choice : ");
                int computer = r.Next(1, 3);
                Console.WriteLine(computer);
                if (user == 2 && computer == 3)
                    Console.WriteLine($"Computer Wins");
                else if (user == 1 && computer == 2)
                    Console.WriteLine($"Computer Wins");
                else if (user == 3 && computer == 1)
                    Console.WriteLine($"Computer Wins");
                else if (user == 3 && computer == 2)
                    Console.WriteLine($"User Win");
                else if (user == 2 && computer == 1)
                    Console.WriteLine($"User Win");
                else if (user == 1 && computer == 3)
                    Console.WriteLine($"User Win");
                else if (user == computer)
                {
                    Console.WriteLine("Withdraw \n");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Keyword \n");
                    continue;
                }
                Console.WriteLine("\nWanna Play Again 1. Yes 2. No");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 2)
                    n = 0;
            }
            Console.WriteLine("\nThank You !");

        }
    }
}

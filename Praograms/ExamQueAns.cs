using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Praograms
{
    class ExamQueAns
    {
        public static void Main()
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Default user name and password is :Prasad and 1234\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username != "Prasad" || password != "1234")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "Prasad" || password != "1234") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            else
                Console.Write("\nThe password entered successfully!\n\n");
        }

    }
}

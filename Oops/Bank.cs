using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    
        class bank
        {
            private double balance = 100000;


            public double bal
            {
                get
            {
                return balance; 
            }
                set 
            {
                balance = value; }
            }
        }
        class AccountBank
        {
            bank i = new bank();
            string name;
            int account;
            double withdraw, dep, tobal;

            public void deposit()
            {
                Console.WriteLine("Enter Name of the depositor :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number  :");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Deposit Amount :");
                dep = Convert.ToDouble(Console.ReadLine());
                tobal = i.bal + dep;

               
                Console.WriteLine("Name of the depositor : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("Total Balance amount in the account  : " + tobal);

            }
            public void Withdrow()
            {
                Console.WriteLine("Enter Account Name :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number  :");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Withdraw Amount :");
                withdraw = Convert.ToDouble(Console.ReadLine());
                if (withdraw <= i.bal)
                {
                    tobal = i.bal - withdraw;
                  
                    Console.WriteLine("Account Name : " + name);
                    Console.WriteLine("Account Number: " + account);
                    Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
                }
                else
                    Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
            }

        }
        class Bank
        {
            static void Main(string[] args)
            {
                char agn;
                do
                {
                AccountBank k = new AccountBank();
                    int num;
                    Console.WriteLine("Please Select Any Function.");
                    Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            k.deposit();
                            break;
                        case 2:
                            k.Withdrow();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection!!!");
                            break;
                    }
                    Console.WriteLine("continue this program? (y/n)");
                    agn = Convert.ToChar(Console.ReadLine());

                } while (agn == 'y');

                Console.ReadKey();
            }
        }
    
}

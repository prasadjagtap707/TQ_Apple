using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Account_2
    {
        public long accountno;
        public string customername;

        public Account_2()
        {
            Console.WriteLine("I Am In Default Constructor");
        }

        public Account_2(int a)
        {
            Console.WriteLine("I Am In Parameterized Constructor");
        }

        public void setAccountNo(long anumber)
        {
            accountno = anumber;
        }
        public long getAccountNo()
        {
            return accountno;

        }
        public void setCustmorName(string cname)
        {
            customername = cname;
        }
        public string getCustmorName()
        {
            return customername;
        }
        static void Main(string[] args)
        {
            Account_2 a = new Account_2();
            Console.WriteLine("Enter The Account Number");
            long anumber = Convert.ToInt32(Console.ReadLine());
            a.setAccountNo(anumber);

            Console.WriteLine("Enter The Customer Name");
            string cname = Console.ReadLine();
            a.setCustmorName(cname);

        }

    }

}

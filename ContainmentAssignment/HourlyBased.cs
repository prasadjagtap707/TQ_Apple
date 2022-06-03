using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ContainmentAssignment
{
    class HourlyBased : Teacher1
    {
        int hrs;
        int rate_pr_hr;

        public void Salary(int hrs, int rate_per_hr)
        {
            int sal = rate_per_hr * hrs;
            Console.WriteLine("Salary: " + sal);
        }

        public HourlyBased()
        {
            Console.WriteLine("In hour default constructor");
        }

        public HourlyBased(int hrs, int rate_pr_hr)
        {
            this.hrs = hrs;
            this.rate_pr_hr = rate_pr_hr;
        }

        public int Hrs
        {
            set { hrs = value; }
            get { return hrs; }
        }

        public int Rate_pr_hr
        {
            set { rate_pr_hr = value; }
            get { return rate_pr_hr; }
        }

    }
}

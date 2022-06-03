using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ContainmentAssignment
{
   class Teacher1
    {
        int tid;
        string tname;
        long mobile;

        public Teacher1()
        {
            Console.WriteLine("In Teacher default constructor");
        }

        public Teacher1(int tid,string tname,long mobile)
        {
            this.tid = tid;
            this.tname = tname;
            this.mobile = mobile;
        }

        public int Tid
        {
            set { tid = value; }
            get { return tid; }
        }

        public string Tname
        {
            set { tname = value; }
            get { return tname; }
        }

        public long Mobile
        {
            set { mobile = value; }
            get { return mobile; }
        } 
    }
}

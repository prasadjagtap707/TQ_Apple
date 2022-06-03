using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Chain
    {
        private int empid;
        private string empname;
        private long mobileno;
        private string address;
        private int salary;

        public Chain(int id, string nm)
        {
            empid = id;
            empname = nm;
        }
        public Chain(int id, string nm, long mb) : this(id, nm)
        {
            empid = id;
            empname = nm;
            mobileno = mb;
        }
        public Chain(int id, string nm, long mb, string add) : this(id, nm, mb)
        {
            empid = id;
            empname = nm;
            mobileno = mb;
            address = add;
        }
        public Chain(int id, string nm, long mb, string add, int sal) : this(id, nm, mb, add)
        {
            empid = id;
            empname = nm;
            mobileno = mb;
            address = add;
            salary = sal;
        }
        static void Main(string[] args)
        {
            Chain c = new Chain(1, "Prasad", 9970089707, "Baramati");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.CollectionAssignment
{
    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("Prasad", 101);
            sl.Add("rohan", 132);
            sl.Add("Kiran", 3231);

            foreach(KeyValuePair<string,int> ss in sl)
                Console.WriteLine(ss.Key+ " " +ss.Value );

         

        }
    }
    class student
    {
        string name;
        int rollnum;

        public student(string name, int rollnum)
        {
            this.Name = name;
            this.Rollnum = rollnum;
        }

        public string Name { get => name; set => name = value; }
        public int Rollnum { get => rollnum; set => rollnum = value; }
    }
}

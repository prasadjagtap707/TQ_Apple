using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{

    class Constructor
    {
       
        internal Constructor()
        {
            Console.WriteLine("Hii i am simple constructor");
        }

        internal Constructor(int i, string s)
        {
            Console.WriteLine(i+ " " +s);
        }
        static Constructor()
        {
            Console.WriteLine("Hii I am Static Constructor");
        }

       

    }
    class Program
    {
        static void Main(string[] args)
        {

            Constructor c = new Constructor();

            Constructor c1 = new Constructor(10,"Prasad");



        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{

    class parent
    {
        public void study()
        {
            Console.WriteLine("I Am Parent Method");
        }

    }

    class child : parent
    {
        
    }


    class ClassOverride
    {
        static void Main(string[] args)
        {
            child p = new child();
            p.study();
        }
    }
}

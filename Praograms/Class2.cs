using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Praograms
{
    class Class2
    {

        static void cal(int a, int b, out int sum, out int multi, out int div)
        {
            sum = a + b;
            multi = a * b;
            div = a / b;

        }
        static void Main(string[] args)
        {
            int a = 29, b = 9;
            int sum, multi, div;
            cal(a, b, out sum, out multi, out div);
            Console.WriteLine("add "+sum+ " multiplication "+multi+ " division "+div);
        }
    }

    class Multi__delegates
    {
        static void Main(string[] args)
        {
            mydel d = new mydel();
            //d="prasad";
        }
	}
    class mydel
    {
        public static void upper(string name)
        {
            Console.WriteLine("To upper Case " +name.ToUpper());
        }
        public static void lower(string name)
        {
            Console.WriteLine("To Lower Case " + name.ToLower());
        }
    }


    class dele
    {
        static void Main(string[] args)
        {
            
        }
    }

}


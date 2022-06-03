using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Area
    {
        public void area(float x)
        {
            Console.WriteLine("The Area Of Square" + x * x);
        }
        public void reactangle(float x, float y)
        {

            Console.WriteLine("The Area Of Square" + x * y);
        }
        public void circle(float r)
        {
            double a = 3.14 * r * r;
            Console.WriteLine("The Area Of Circle" + a);
        }
        static void Main(string[] args)
        {
            Area obj = new Area();
            obj.area(4);
            obj.reactangle(3, 2);
            obj.circle(2);


        }
    }

}

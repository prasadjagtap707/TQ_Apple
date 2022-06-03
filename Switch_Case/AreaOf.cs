using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Switch_Case
{
    class AreaOf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1.Area of a Circle");
            Console.WriteLine("2.Area of a Square");
            Console.WriteLine("3.Area of a Right Angled Triangle");
            Console.WriteLine("4.Area of a Rectangle");
            Console.WriteLine("5.Circumference of a Circle");
            Console.WriteLine("6.Perimeter of a Square");
            Console.WriteLine("7.Exit");

            Console.WriteLine("Enter your option:");
            int op = Convert.ToInt32(Console.ReadLine()); 

            switch (op)
            {
                case 1:
                    Console.WriteLine("Enter radius:");
                    float r = Convert.ToInt64(Console.ReadLine());
                    float ac = 3.14f * r * r;
                    Console.WriteLine("Area:" + ac);
                    break;

                case 2:
                    Console.WriteLine("Enter side:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    int AS = x * x;
                    Console.WriteLine("Area:" +AS);
                    break;

                case 3:
                    Console.WriteLine ("Enter height and base:");
                    float h = Convert.ToInt64(Console.ReadLine());
                    float bs = Convert.ToInt64(Console.ReadLine());
                    float art = 0.5f * h * bs;
                    Console.WriteLine("Area:" + art);
                    break;

                case 4:
                    Console.WriteLine("Enter length and breadth:");
                    int l = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int ar = l * b;
                    Console.WriteLine("Area:" + ar);
                    break;

                case 5:
                    Console.WriteLine("Enter radius:");
                    float R = Convert.ToInt64(Console.ReadLine());
                    float C = 3.14f * 2f * R;
                    Console.WriteLine("Circumference:" + C);
                    break;


                case 6:
                    Console.WriteLine("Enter side:");
                    int X = Convert.ToInt32(Console.ReadLine());
                    int p = 4 * X;
                    Console.WriteLine("Perimeter:" + p);
                    break;

               
            }

        }
    }
}

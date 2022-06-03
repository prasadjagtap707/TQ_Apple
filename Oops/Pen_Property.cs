using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Pen_Property
    {
        string brand;
        string colour;
        int price;


        public Pen_Property()
        {
            Console.WriteLine("In Default Constructor");
        }

        public Pen_Property(int a)
        {
            Console.WriteLine("In Parameterics Constructor");
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        static void Main(string[] args)
        {
            Pen_Property p = new Pen_Property();

            p.Brand = "Cello";
            p.Colour = "Black";
            p.Price = 40;

            Console.WriteLine(p.Brand);
            Console.WriteLine(p.Colour);
            Console.WriteLine(p.Price);


        }


    }
}

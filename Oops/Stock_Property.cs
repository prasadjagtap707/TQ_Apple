using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Stock_Property
    {
        float openingprice;
        float closeprice;
        string stockname;

        public float OpeningPrice
        {
            get { return openingprice; }
            set { openingprice = value; }
        }
        public float ClosePrice
        {
            get { return closeprice; }
            set { closeprice = value; }
        }

        public string StockName
        {
            get { return stockname; }
            set { stockname = value; }
        }

        static void Main(string[] args)
        {
            Stock_Property sp = new Stock_Property();
            sp.OpeningPrice = 30000;
            sp.ClosePrice = 7800;
            sp.StockName = "Brandd";

            Console.WriteLine(sp.OpeningPrice);
            Console.WriteLine(sp.ClosePrice);
            Console.WriteLine(sp.StockName);
        }
    }
}

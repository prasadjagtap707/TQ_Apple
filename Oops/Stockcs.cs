using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Oops
{
    class Stockcs
    {
        float openingprice;
        float closeprice;
        string stockname;

        public void setOpen(float op)
        {
            openingprice = op;
        }

        public float getOpen()
        {
            return openingprice;

        }

        public void setClose(float cp)
        {
            closeprice = cp;

        }
        public float getClose()
        {
            return closeprice;
        }
        public void setStockName(string sname)
        {
            stockname = sname;
        }
        public string getStockName()
        {
            return stockname;
        }

        static void Main(string[] args)
        {
            Stockcs s = new Stockcs();
            s.setOpen(12.34f);
            s.setClose(56.89f);
            s.setStockName("Brand");

            Console.WriteLine("-----------------");


        }

    }
}


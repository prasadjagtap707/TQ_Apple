using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.ProgramExtra
{
    class Param
    {

        // User defined function  
        public void Shows(params int[] val) // Params Paramater  
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
    
        static void Main(string[] args)
        {
            Param p = new Param();   
            p.Shows(2, 4, 6, 8, 10, 12, 14); // Passing arguments of variable length  
        }
    }
}



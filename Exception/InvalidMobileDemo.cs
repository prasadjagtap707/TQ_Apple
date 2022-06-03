using System;
using System.Collections.Generic;
using System.Text;

namespace TQ_Apple.Exception
{
    class InvalidMobileException : ApplicationException
    {
        public InvalidMobileException(string m) : base(m)
        {

        }
        public override string ToString()
        {
            return "Errooooor";
        }
    }
    class InvalidMobileDemo
    {
        static void ValidateMobile(long mb)
        {
            string m = Convert.ToString(mb);
            int c = m.Length;
            if (c != 10)
                throw new InvalidMobileException("Mobile should be exact 10 digits");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mobile number");
            long mobi = Convert.ToInt64(Console.ReadLine());
            try
            {
                ValidateMobile(mobi);
            }
            catch (InvalidMobileException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

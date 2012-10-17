using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 0;
            long l = integer;

            double d = 0.0d;
            int i = (int)d;

            DateTime time = new DateTime(2012, 10, 17);
            Console.WriteLine( time.ToShortDateString());
            Console.Read();
        }
    }
}

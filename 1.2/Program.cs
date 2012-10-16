using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi bro, What's your name ?");
            string name = Console.ReadLine();

            Console.WriteLine(string.Format("Hi {0} !", name));
            Console.Read();
        }
    }
}

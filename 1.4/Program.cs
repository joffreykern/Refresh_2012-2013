using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a price : ");
            string priceentry = Console.ReadLine();

            // convert string entry in float
            float price = float.Parse(priceentry);

            Console.WriteLine("Enter tax rate : ");
            string taxentry = Console.ReadLine();

            // convert string entry in float
            float tax = float.Parse(taxentry);

            // the result
            float result = price * (1 + tax);
            Console.WriteLine(string.Format("Total = {0} or {0:C} in currency format", result));

            Console.Read();
        }
    }
}

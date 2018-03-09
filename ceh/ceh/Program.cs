using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceh
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = a / 2;
            double area = (a+0.6) * (b+0.6);
            double area1 = c * c;
            
            double price = (area * 7)*number;
            double price1 = (area1 * 9)*number;

            double totalprice = price + price1;

            double priceinleva = totalprice * 1.85;

            Console.WriteLine("{0} USD",Math.Round(totalprice,2));
            Console.WriteLine("{0} BGN",Math.Round(priceinleva,2));

        }
    }
}

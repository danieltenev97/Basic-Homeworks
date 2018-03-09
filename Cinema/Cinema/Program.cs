using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string projection = Console.ReadLine();
            int redove = int.Parse(Console.ReadLine());
            int koloni = int.Parse(Console.ReadLine());

            double sum = 0;
            double price = 0;

            if(projection.Equals("Normal"))
            {
                price = 7.50;
                sum = (redove * koloni) * price;
            }

            else if(projection.Equals("Premiere"))
            {
                price = 12.00;
                sum = (redove * koloni) *price;
            }

            else if(projection.Equals("Discount"))
            {
                price = 5;
                sum = (redove * koloni) * price;
            }



            Console.WriteLine("{0} leva",Math.Round(sum,2));




        }
    }
}

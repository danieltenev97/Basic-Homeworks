using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double sredenyspeh = double.Parse(Console.ReadLine());
            double minimalwage = double.Parse(Console.ReadLine());

            double socialscholarship = minimalwage * 0.35; ;
            double excellentscholarship = sredenyspeh * 25; 
          

            if(socialscholarship>excellentscholarship&&dohod<minimalwage&&sredenyspeh>4.50)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN",socialscholarship);
            }

            else if(excellentscholarship>=socialscholarship&&sredenyspeh>=5.50)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN",Math.Floor(excellentscholarship));
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}

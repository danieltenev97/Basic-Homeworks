using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double comissions = 0;

            if(city.Equals("Sofia"))
            {
                if(sales<=500)
                {
                    comissions = sales * 0.05;
                }

                else if(sales>500&&sales<=1000)
                {
                    comissions = sales * 0.07;
                }
                else if(sales>1000&&sales<=10000)
                {
                    comissions = sales * 0.08;
                }
                else if(sales>10000)
                {
                    comissions = sales * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }

            else if(city.Equals("Varna"))
            {
                if (sales <= 500)
                {
                    comissions = sales * 0.045;
                }

                else if (sales > 500 && sales <= 1000)
                {
                    comissions = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comissions = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if(city.Equals("Plovdiv"))
            {
                if (sales <= 500)
                {
                    comissions = sales * 0.055;
                }

                else if (sales > 500 && sales <= 1000)
                {
                    comissions = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comissions = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine(Math.Round(comissions,2));
        }
    }
}

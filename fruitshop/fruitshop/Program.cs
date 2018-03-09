using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string day = Console.ReadLine();
          
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            if(day=="Monday"||day=="Tuesday"||day=="Wednesday"||day=="Thursday"||day=="Friday")
            {
                if(product.Equals("banana"))
                {
                    price = quantity * 2.50;
                }
                else if (product.Equals("kiwi"))
                        {
                    price = quantity * 2.70;
                }
                else if(product.Equals("orange"))
                {
                    price = quantity * 0.85;
                }

                else if(product.Equals("apple"))
                {
                    price = quantity * 1.20;
                }
                else if(product.Equals("grapes"))
                {
                    price = quantity * 3.85;
                }
                else if(product.Equals("pineapple"))
                {
                    price = quantity * 5.50;
                }
                else if(product.Equals("grapefrui"))
                {
                    price = quantity * 1.45;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if(day=="Saturday"||day=="Sunday")
            {
                if (product.Equals("banana"))
                {
                    price = quantity * 2.70;
                }
                else if (product.Equals("kiwi"))
                {
                    price = quantity * 3.00;
                }
                else if (product.Equals("orange"))
                {
                    price = quantity * 0.90;
                }

                else if (product.Equals("apple"))
                {
                    price = quantity * 1.25;
                }
                else if (product.Equals("grapes"))
                {
                    price = quantity * 4.20;
                }
                else if (product.Equals("pineapple"))
                {
                    price = quantity * 5.60;
                }
                else if (product.Equals("grapefrui"))
                {
                    price = quantity * 1.60;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            Console.WriteLine(Math.Round(price,2));

        }
    }
}

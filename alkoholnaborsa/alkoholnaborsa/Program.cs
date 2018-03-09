using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alkoholnaborsa
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string b = Console.ReadLine();
                if (b.Equals("STOP")) break;
                decimal whiskyprice = decimal.Parse(Console.ReadLine());
                decimal quantitiybira = decimal.Parse(Console.ReadLine());
                decimal quantityvino = decimal.Parse(Console.ReadLine());
                decimal quantityrakiq = decimal.Parse(Console.ReadLine());
                decimal quantitywhisky = decimal.Parse(Console.ReadLine());
                decimal priceofrakiq = whiskyprice / 2;

                decimal priceofvino = priceofrakiq - priceofrakiq * 2 / 5;

                decimal priceofbira = priceofrakiq - priceofrakiq * 4 / 5;

                decimal biraprice = quantitiybira * priceofbira;
                decimal rakiqprice = quantityrakiq * priceofrakiq;
                decimal vinoprice = quantityvino * priceofvino;
                decimal priceofwhisky = quantitywhisky * whiskyprice;

                decimal neededmoney = biraprice + rakiqprice + vinoprice + priceofwhisky;

                Console.WriteLine(Math.Round(neededmoney, 2));

            }
            
        }
    }
}

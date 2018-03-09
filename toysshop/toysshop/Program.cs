using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toysshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripprice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingdolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());

            int orderedproducts = puzzles + talkingdolls + teddybears + minions + tracks;
            double puzzlesprice = puzzles * 2.60;
            int dollsprice = talkingdolls * 3;
            double teddybearsprice = teddybears * 4.10;
            double minionsprice = minions * 8.20;
            int tracksprice = tracks * 2;

            double price = puzzlesprice + dollsprice + teddybearsprice + minionsprice + tracksprice;

            if(orderedproducts>=50)
            {
                price =price- price * 0.25;
            }

            price = price-price * 0.10;

            if(price>tripprice)
            {
                double moneyleft = price - tripprice;
                Console.WriteLine("Yes! {0} lv left.",Math.Round(moneyleft,2));
            }

            else
            {
                double moneyneeded = tripprice - price;
                Console.WriteLine("Not enough money! {0} lv needed",Math.Round(moneyneeded,2));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double productsmade = ((((cakes * 45) + (gofreti * 5.80) + (pancakes * 3.20))*bakers)*days);
            double totalmoney =productsmade - productsmade/8;

            Console.WriteLine(Math.Round(totalmoney,2));
           
        }
    }
}

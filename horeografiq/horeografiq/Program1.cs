using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horeografiq
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double dailylearningsteps = n / days;
            double dailypercent = (dailylearningsteps / n)*100;

            double learningsteps1 = dailypercent / dancers;
            Console.WriteLine(Math.Ceiling(dailypercent));

            
            if (dailypercent<=13)
            {
               
                Console.WriteLine("Yes,they will seed in that goal!{0}%",Math.Round(learningsteps1,2));
            }

       else
           {

       Console.WriteLine("No,They will not succeed in that goal! Required {0}% steps to be learned per day.",Math.Round(learningsteps1,2));
          }

    

        }
    }
}

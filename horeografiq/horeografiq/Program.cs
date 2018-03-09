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

            double dailylearningsteps = Math.Ceiling(n * 0.13);
            double m = n / days;

            if(m<=dailylearningsteps)
            {
                double learningsteps1 = (n*0.13);
                Console.WriteLine("Yes,they will seed in that goal!{0}%",Math.Round(learningsteps1,2));
            }

      //  else
        //    {

          //  }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            if(time1>50||time2>50||time3>50)
            {
                return;
            }
            if(time1<1||time2<1||time3<1)
            {
                Console.WriteLine("Error");
            }

            int totalseconds = time1 + time2 + time3;
            int minutes = totalseconds / 60;
            int seconds = totalseconds % 60;

            if(seconds>10)
            {
                Console.WriteLine("{0}:{1}",minutes,seconds);

            }
            else
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
        }
    }
}

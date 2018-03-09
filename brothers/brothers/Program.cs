using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstbrother = decimal.Parse(Console.ReadLine());
            decimal secondbrother = decimal.Parse(Console.ReadLine());
            decimal thirdbrother = decimal.Parse(Console.ReadLine());
            decimal away = decimal.Parse(Console.ReadLine());
            decimal timeforcleaning=0;
           if(firstbrother>=secondbrother&&firstbrother>=thirdbrother)
            {
                timeforcleaning = firstbrother;
            }
else if(secondbrother>=firstbrother&&secondbrother>=thirdbrother)
            {
                timeforcleaning = secondbrother;
            }
           else
            {
                timeforcleaning = thirdbrother;
            }
            decimal totaltime = timeforcleaning + timeforcleaning * 15 / 100;

            decimal timeleft = away - totaltime;
            decimal neededtime = totaltime - away;

            Console.WriteLine("“Cleaning time:{0}",Math.Round(totaltime,2));

            if(timeleft>0)
            {
                Console.WriteLine("Yes, there is a surprise - time left {0} -hours.",Math.Floor(timeleft));
            }

            else
            {
                Console.WriteLine("No, there isn’t a surprise - shortage of time - {0} hours.",Math.Ceiling(neededtime));
            }


        }
    }
}

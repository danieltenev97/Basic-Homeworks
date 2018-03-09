using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plus15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 15;
            if(minutes>=60)
            {
                hours++;
                minutes = minutes - 60;
            }
            
            if(hours<=23)
            {
                if(minutes>=10)
                {
                    Console.WriteLine("{0}:{1}",hours,minutes);
                }
                else
                {
                    Console.WriteLine("{0}:0{1}", hours, minutes);
                }
            }

            else if(hours>23)
            {
                hours = 0;
               if(minutes >=10)
                {
                    Console.WriteLine("{0}:{1}", hours, minutes);
                }
                else
                {
                    Console.WriteLine("{0}:0{1}", hours, minutes);
                }
            } 
        }
    }
}

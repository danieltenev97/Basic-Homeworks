using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimmingrecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeforonemeter = double.Parse(Console.ReadLine());

            double ivanchotime = timeforonemeter * distance;

            double a =Math.Floor(distance/15);

            double R = a * 12.5;
            double totaltime = ivanchotime + R;

            if(record>totaltime)
            {
                Console.WriteLine("Yes, he succeeded!The new world record is {0} seconds.",Math.Round(totaltime,2));
            }

            else
            {
                double timeneeded = totaltime - record;

                Console.WriteLine("No,he failed! He was {0} seconds slower.",Math.Round(timeneeded,2));
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paralepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int v = (a * b) * h;
            double z = v * percentage / 100;

            double obem = v - z;

            double leters = obem / 1000;
            Console.WriteLine(Math.Round(leters,3));

        }
    }
}

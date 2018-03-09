using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dancerhall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            if(A<2||A>20)
            {
                return;
            }

            double area = L * W;
            double benchArea = (L * W) / 10;
            double wardrobeArea = A * A;

            double totalarea = area - benchArea - wardrobeArea;

            double areafor1dancer = 0.004 + 0.7;

            double dancersarea = totalarea / areafor1dancer;
            Console.WriteLine(Math.Floor(dancersarea));





        }
    }
}

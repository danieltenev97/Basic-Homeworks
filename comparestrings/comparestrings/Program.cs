using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparestrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();

            if(name==name1)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Dateandtime
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            DateTime date= DateTime.ParseExact(input, "ddMMyyyy", CultureInfo.InvariantCulture);
            DateTime result = date.AddDays(999);

            Console.WriteLine(result.ToString("dd.MM.yyyy"));



        }
    }
}

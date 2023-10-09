using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class Temp
    {
        public static void Main(string[] args)
        {
            int celsius, faren;

            Console.WriteLine("Enter the Temperature in Celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            faren = (celsius * 9) / 5 + 32;

            Console.WriteLine("Temperature in Fahrenheit is: " + faren);
            Console.ReadLine();
        }
    }
}

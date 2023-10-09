using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year
{
    public class Check_Year
    {
        public static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter any year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine(year +" is a leap year.\n");

            else if ((year % 100) == 0)
                Console.WriteLine(year + " is not a leap year.\n");

            else if ((year % 4) == 0)
                Console.WriteLine(year + " is a leap year.\n" );

            else
                Console.WriteLine(year + " is not a leap year.\n");
        }
    }
}

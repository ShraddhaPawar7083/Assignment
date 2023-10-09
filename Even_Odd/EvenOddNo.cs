using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    public class EvenOddNo
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter any number: ");
            a= Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine(a + " is even number");
            else
                Console.WriteLine(a + " is odd number");

            Console.ReadLine();
        }
    }
}
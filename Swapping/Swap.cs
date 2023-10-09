using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    public class Swap
    {
        static void Main(String[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("Before swapping:");
            Console.WriteLine("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter swapping");
            Console.WriteLine("First number is: " + num1);
            Console.WriteLine("Second number is: " + num2);
            Console.ReadKey();
        }
    }
}

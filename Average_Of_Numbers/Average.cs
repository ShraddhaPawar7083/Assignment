using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Of_Numbers
{
    public class Average
    {
        static void Main(String[] args)
        {
            double num1, num2, num3, num4, num5;

            Console.Write("Enter the First number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
 
            Console.Write("Enter the Second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
 
             Console.Write("Enter the third number: ");
             num3 = Convert.ToDouble(Console.ReadLine());
 
             Console.Write("Enter the fourth number: ");
             num4 = Convert.ToDouble(Console.ReadLine());

             Console.Write("Enter the fifth number: ");
             num5 = Convert.ToDouble(Console.ReadLine());

            double result = (num1 + num2 + num3 + num4 + num5) / 5;
             Console.WriteLine("The average of {0}, {1}, {2}, {3}, {4} is: {5} ",
  num1, num2, num3, num4, num5, result);
        }
    }
}

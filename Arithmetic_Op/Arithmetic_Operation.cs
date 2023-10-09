using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Arithmetic_Operation
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int add, sub, mul;
            float div;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;

            Console.WriteLine(add + "\n Addition: ");
            Console.WriteLine(sub + "\n Subtraction: ");
            Console.WriteLine(mul + "\n Multiplication: ");
            Console.WriteLine(div + "\n Division: ");

            Console.ReadLine();
        }
    }
}


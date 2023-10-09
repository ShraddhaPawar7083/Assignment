using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Interest
{
    public class SimpleInterest
    {
        public static void Main(string[] args)
        {
            int amount, time;
            float rate, SI;
            Console.Write("Enter Amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate: ");
            rate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Time : ");
            time = Convert.ToInt32(Console.ReadLine());

            SI = amount * rate * time / 100;
     
            Console.WriteLine("Simple interest is: " + SI);
            Console.ReadLine();
        }
    }
}

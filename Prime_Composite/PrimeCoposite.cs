using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Composite
{
    public class PrimeCoposite
    {
        public static void Main(string[] args) 
        {
            int a, b;
            Console.WriteLine("Enter any number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i <= a; i++) 
            {
                if(a %i == 0) 
                {
                    b++;
                }
            }


        }
    }
}

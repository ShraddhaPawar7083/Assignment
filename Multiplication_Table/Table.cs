using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    public class Table
    {
        public static void Main(string[] args)
        { 
            int j, n;  

            Console.Write("Enter any number: ");
            n= Convert.ToInt32(Console.ReadLine());   

            Console.Write("\n Table is\n");
            for(j=1;j<=10;j++)
            {
                Console.Write("{0} X {1} = {2} \n",n,j,n* j);
            }
        }

    }
}

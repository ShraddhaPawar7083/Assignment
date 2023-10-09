using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet_Code
{
    public class Snippet
    {
        public static void Main(string[] args)
        {
            int i=18, j=20, k;

            k = i-- - i++ + --j - ++j + --i - j-- + ++i - j++;
            
            Console.WriteLine("i="+i);
            Console.WriteLine("j=" + j);
            Console.WriteLine("k=" + k);
        }
    }
}

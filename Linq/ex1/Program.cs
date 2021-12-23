using System;
using System.Linq;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

            // select numero * 10 from valores where numero % 2 = 0
            var result = valores.Where( item => item % 2 == 0 ).Select(item => item * 10);

            foreach(int x in result)
                Console.WriteLine(x);


        }
    }
}

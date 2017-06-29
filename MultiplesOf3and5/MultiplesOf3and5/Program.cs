using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for(int idx = 0; idx < 1000; idx++ )
            {
                if(idx%3==0 || idx%5==0)
                {
                    result += idx;
                }
            }


            Console.WriteLine("Answer: " + result);
            Console.ReadKey();
        }
    }
}

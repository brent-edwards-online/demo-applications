using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {


        static void Main(string[] args)
        {
            int f = 2;
            int fminus1 = 1;
            int sum = 2;
            int newF = 0;

            while ( newF < 4000000)
            {
                newF = f + fminus1;

                if(newF%2==0)
                {
                    sum += newF;
                }

                fminus1 = f;
                f = newF;
            }

            Console.WriteLine("Answer: " + sum);
            Console.ReadKey();
        }
    }
}

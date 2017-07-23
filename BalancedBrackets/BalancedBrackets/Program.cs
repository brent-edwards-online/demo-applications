using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var data = "]";


            var bal = new BalancedBrackets();
            var result = bal.Check(data);
            if(result)
            {
                Console.WriteLine(data + " is balanced");
            }
            else
            {
                Console.WriteLine(data + " is not balanced");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huffman
{
    public class Program
    {
        const string message = @"Donec dolor libero, molestie et orci id, vestibulum commodo risus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean commodo tempor eleifend. Duis luctus dapibus nibh, ac commodo dui condimentum vel. Donec iaculis aliquet bibendum. Aliquam erat volutpat. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque vestibulum lacus orci. In molestie gravida ex ac pulvinar. Sed semper at ipsum nec imperdiet. Curabitur viverra vestibulum faucibus. Vivamus accumsan, ante eget dapibus rutrum, felis lacus cursus metus, quis faucibus diam mi non est. Nam in ligula lectus. Etiam venenatis dolor a leo pharetra, eget luctus sapien tempor.";
        public static void Main(string[] args)
        {
            var keepGoing = true;
            while(keepGoing)
            {
                var histogram = HuffmanCodec.CreateHistogram(message);

                foreach (KeyValuePair<char, int> entry in histogram)
                {
                    if(entry.Key<32)
                        Console.WriteLine(" " + " : " + entry.Key + " : " + entry.Value);
                    else
                        Console.WriteLine(entry.Key + " : " + entry.Key + " : " + entry.Value);
                }


                Console.WriteLine("Press enter to exit");
                var key = Console.ReadKey();
                if(key.Key == ConsoleKey.Enter)
                {
                    keepGoing = false;
                }
            }
            
        }
    }
}

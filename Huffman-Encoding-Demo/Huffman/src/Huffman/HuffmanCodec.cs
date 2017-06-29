using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Huffman
{
    public static class HuffmanCodec
    {
        public static Dictionary<char, int> CreateHistogram(string input)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int idx = 0; idx < input.Length; idx++)
            {
                char currentCharacter = input[idx];

                if(result.ContainsKey(currentCharacter))
                {
                    result[currentCharacter]++;
                }
                else
                {
                    result.Add(currentCharacter, 1);
                }

                
            }

            return result;
        }

        public static Dictionary<char, int> InsertionSort(Dictionary<char, int> input)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (var idx = 0; idx < input.Count; idx++ )
            {
                var value = input.ElementAt(idx);


                for ( var idx2 = idx + 1; idx2 < input.Count; idx2++ )
                {
                    var value = input.ElementAt(idx2);

                    if (input[idx2] > value)
                    {
                        
                    }
                }

                
            }
            

            return result;
        }
    }

    
}

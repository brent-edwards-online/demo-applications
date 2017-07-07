using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoComplete_Trie
{
    interface ITrie
    {
        void Create(string[] dictionary);
        List<string> AutoComplete(string prefix);
    }
}

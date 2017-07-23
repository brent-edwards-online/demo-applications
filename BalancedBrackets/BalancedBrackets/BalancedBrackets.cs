using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BalancedBrackets
{
    public class BalancedBrackets
    {
        readonly Regex r = new Regex("(\\[|\\{|\\()");

        public bool Check(string command)
        {
            Stack<char> brackets = new Stack<char>();

            foreach(var bracket in command)
            {
                if(r.IsMatch("" + bracket) ==  true)
                {
                    brackets.Push(bracket);
                }
                else
                {
                    if(brackets.Count)
                    var top = brackets.Pop();
                    switch(top)
                    {
                        case '{':
                            if (bracket != '}')
                                return false;
                            break;
                        case '(':
                            if (bracket != ')')
                                return false;
                            break;
                        case '[':
                            if (bracket != ']')
                                return false;
                            break;
                    }
                }
            }

            if (brackets.Count != 0)
                return false;

            return true;
        }
    }
}

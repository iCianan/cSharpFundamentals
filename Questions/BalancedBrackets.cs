using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class BalancedBrackets
    {
        /*
        Let’s consider the following task: we have an expression, in which we would like to check whether the brackets are put correctly.
        This means to check if the count of the opening brackets is equal to the count of the closing brackets and all opening brackets match their respective closing brackets.
        */
        public bool ParenthesisOnly(string expression)
        {
            Stack<char> opening = new Stack<char>();
            char openBracket = '(';
            char closingBracket = ')';

            foreach (var item in expression)
            {
                if (item == openBracket)
                {
                    opening.Push(item);
                }
                if (item == closingBracket)
                {
                    if (opening.Count == 0)
                    {
                        return false;
                    }
                    opening.Pop();
                }
            }
            if (opening.Count != 0)
            {
                return false;
            }
            return true;   
        }

        // Not working 

        public bool BunchOfBrackets(string expression)
        {
            Stack<char> resultStack = new Stack<char>();            
            var openBrackets = new Dictionary<char, bool>
            {
                { '{', true},
                { '[', true},
                { '(', true},
            };
            
            var closeBrackets = new Dictionary<char, bool>
            {
                { '}', true},
                { ']', true},
                { ')', true},
            };

            var completeBracket = new Dictionary<string, bool>
            {
                { "{}", true},
                { "[]", true},
                { ")", true},
            };

            foreach (var item in expression)
            {

                if (openBrackets.ContainsKey(item))
                {
                    resultStack.Push(item);
                }

                if (closeBrackets.ContainsKey(item))
                {
                    if (resultStack.Count == 0)
                    {
                        return false;
                    }

                    string possibleMatch = string.Concat(resultStack.Pop(), item);

                    if (completeBracket.ContainsKey(possibleMatch))
                    {
                        resultStack.Pop();

                    }
                }
            }
            if (resultStack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}

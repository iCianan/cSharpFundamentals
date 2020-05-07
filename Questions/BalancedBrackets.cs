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

        /*
        Write a function that takes in a string made up of brackets ([{ }]) and other optional characters.
        The function should return a boolean representing whether the string is balanced with regards to brackets.

        A string is said to be balanced if it has as many opening brackets of a certain type as it has closing 
        brackets of that type and if no bracket is unmatched.Note that an opening bracket can't match a corresponding 
        closing bracket that comes before it, and similarly, a closing bracket can't match a corresponding opening 
        bracket that comes after it.Also, brackets can't overlap each other as in [(])
        */

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

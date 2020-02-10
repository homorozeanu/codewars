using System;
using System.Collections.Generic;

namespace ValidBraces
{
    public class ValidBraces
    {
        public bool ValidBracesWithStack(String braces)
        {
            var stack = new Stack<char>();
            foreach (var brace in braces)
            {
                if (IsClosingBrace(brace))
                {
                    if (!stack.TryPop(out var prevBrace)) return false;
                    if (IsAPairBrace(brace, prevBrace)) continue;
                    return false;
                }

                stack.Push(brace);
            }

            return stack.Count == 0;
            
            bool IsClosingBrace(char chr) => chr == ')' || chr == ']' || chr == '}';
            bool IsAPairBrace(char leftBrace, char rightBrace) => (leftBrace == ')' && rightBrace == '(') || (leftBrace == ']' && rightBrace == '[') || (leftBrace == '}' && rightBrace == '{');
        }

        public bool ValidBracesWithStringReplace(String braces)
        {
            while (braces.Length != 0)
            {
                int lengtBefore = braces.Length;
                braces = braces.Replace("()", "");
                braces = braces.Replace("[]", "");
                braces = braces.Replace("{}", "");
                int lengthsAfter = braces.Length;
                if (lengtBefore == lengthsAfter) break;
            }

            return braces.Length == 0;
        }
    }
}
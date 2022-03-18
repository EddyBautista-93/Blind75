using System.Collections;
using System.Linq;
using System.Reflection.Emit;
using System;
using System.Collections.Generic;

public class ValidParen
{
    /*
      Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

      An input string is valid if:

      Open brackets must be closed by the same type of brackets.
      Open brackets must be closed in the correct order.


      Example 1:

      Input: s = "()"
      Output: true
      Example 2:

      Input: s = "()[]{}"
      Output: true
      Example 3:

      Input: s = "(]"
      Output: false
    */

    public static bool IsValid(string s)
    {
        // Odd count cant have equal pairs 
        if (s.Length % 2 != 0)
            return false;

        Stack st = new Stack();

        foreach (var c in s)
        {
            if (c == '(' || c == '{' || c == '[') st.Push(c);

            if (c == ')' || c == '}' || c == ']')
            {
                if (st.Count == 0) return false;
                char val = (char)st.Pop();
                if (c == ')' && val != '(') return false;
                if (c == '}' && val != '{') return false;
                if (c == ']' && val != '[') return false;
            }
        }
        return st.Count == 0;
    }
}

using System;
using System.Collections.Generic;



namespace LeetCode
{
    static class P20_ValidParentheses
    {
       

        public static bool IsValid(string s)
        {
            // Initialize a Dictionary and a stack to be used in the algorithm.
            var dic = new Dictionary<char,char>();
            dic.Add(')', '(');
            dic.Add('}', '{');
            dic.Add(']', '[');

            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var num = (i >= s.Length) || (i < 0) ? "" : s.Substring(i, 1);

                var c = Convert.ToChar(num);              

                // If the current character is a closing bracket.
                if (dic.ContainsKey(c))
                {

                    // Get the top element of the stack. If the stack is empty, set a dummy value of '#'
                    char topElement = stack.Count==0 ? '#' : stack.Pop();

                    // If the mapping for this bracket doesn't match the stack's top element, return false.                  
                    dic.TryGetValue(c, out char v);
                    if (topElement != v )
                    {
                        return false;
                    }
                }
                else
                {
                    // If it was an opening bracket, push to the stack.
                    stack.Push(c);
                }
            }

            // If the stack still contains elements, then it is an invalid expression.
            return stack.Count==0;
        }



    }
}

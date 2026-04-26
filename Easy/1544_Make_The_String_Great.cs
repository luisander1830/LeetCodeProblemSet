using System.Collections.Generic;
using System.Text;

public class Solution {
    public string MakeGood(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (stack.Count > 0 && Math.Abs(stack.Peek() - c) == 32) {
                stack.Pop();
            } else {
                stack.Push(c);
            }
        }
        StringBuilder res = new StringBuilder();
        foreach (char c in stack) res.Insert(0, c);
        return res.ToString();
    }
}

using System.Collections.Generic;
using System.Text;

public class Solution {
    public string RemoveStars(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (c == '*') stack.Pop();
            else stack.Push(c);
        }
        StringBuilder sb = new StringBuilder();
        foreach (char c in stack) sb.Insert(0, c);
        return sb.ToString();
    }
}

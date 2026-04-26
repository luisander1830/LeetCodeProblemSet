using System.Collections.Generic;

public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> result = new List<string>();
        int current = 1;
        foreach (int num in target) {
            while (current < num) {
                result.Add("Push");
                result.Add("Pop");
                current++;
            }
            result.Add("Push");
            current++;
        }
        return result;
    }
}

using System.Collections.Generic;

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in arr) {
            if (counts.ContainsKey(num)) counts[num]++;
            else counts[num] = 1;
        }
        HashSet<int> occurrences = new HashSet<int>(counts.Values);
        return counts.Count == occurrences.Count;
    }
}

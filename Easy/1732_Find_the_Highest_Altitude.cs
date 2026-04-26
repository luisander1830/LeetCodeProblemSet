public class Solution {
    public int LargestAltitude(int[] gain) {
        int maxAlt = 0;
        int currentAlt = 0;
        foreach (int g in gain) {
            currentAlt += g;
            if (currentAlt > maxAlt) maxAlt = currentAlt;
        }
        return maxAlt;
    }
}

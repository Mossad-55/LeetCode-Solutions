namespace Medium;

public class LongestRepeatingCharacterReplacement{
    public static int Solve(string s, int k){
        // Base Case
        if(s.Length == 1) return 1;
        
        int[] map = new int[26];
        int l = 0, r = 0, maxFreq = 0, res = 0;
        while(r < s.Length){
            map[s[r] - 'A']++;
            maxFreq = Math.Max(maxFreq, map[s[r] - 'A']);
            if((r - l + 1) - maxFreq > k){
                map[s[l] - 'A']--;
                l++;
            }
            res = Math.Max(res, r - l + 1);
            r++;
        }

        return res;
    }
}
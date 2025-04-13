namespace Medium;

public class LongestSubStringWithoutRepeating{
    public static int Solve(string s){
        // Base Case
        if(s.Length == 1) return 1;
        
        HashSet<char> set = new();
        int l = 0, r = 0, res = 0;
        
        while(r < s.Length){
            if(set.Contains(s[r]))
                set.Remove(s[l++]);
            else{
                res = Math.Max(res, r - l + 1);
                set.Add(s[r++]);
            }
        }
        return res;
    }
}
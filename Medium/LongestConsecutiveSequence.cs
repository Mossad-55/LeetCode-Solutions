namespace Medium;

public class LongestConsecutiveSequence{
    public static int Solve(int[] nums){
        // Base Case
        if(nums.Length < 2) return nums.Length;

        HashSet<int> hash = new(nums);
        int res = 0;
        foreach(var n in hash){
            int left = n - 1;
            int right = n + 1;

            while(hash.Remove(left)) left--;
            while(hash.Remove(right)) right++;

            res = Math.Max(res, right - left - 1);

            if(hash.Count == 0) break;
        }

        return res;
    }
}
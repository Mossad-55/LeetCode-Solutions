namespace Medium;

public class ThreeSum{
    public static List<List<int>> Solve(int[] nums){
        var res = new List<List<int>>();
        // Base Case
        if(nums.Length <= 2) return res;

        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++){
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int l = i + 1, r = nums.Length - 1;
            while(l < r){
                if(nums[i] + nums[l] + nums[r] > 0) 
                    r--;
                else if(nums[i] + nums[l] + nums[r] < 0) 
                    l++;
                else{
                    res.Add([nums[i], nums[l], nums[r]]);
                    l++;
                    r--;

                    while(l < r && nums[l] == nums[l - 1]) 
                        l++;
                }
            }
        }

        return res;
    }
}
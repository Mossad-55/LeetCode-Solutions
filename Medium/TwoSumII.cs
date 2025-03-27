namespace Medium;

public class TwoSumII{
    public static int[] Solve(int[] nums, int target){
        int left = 0, right = nums.Length - 1;
        while(left < right){
            if(nums[left] + nums[right] == target)
                break;
            else if(nums[left] + nums[right] < target)
                left++;
            else
                right--;
        }

        return [left + 1, right + 1];
    }
}
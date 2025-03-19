namespace Medium;

public class ProductOfArrayExceptSelf{
    public static int[] Solve(int[] nums){
        int[] res = new int[nums.Length];
        int helper = 1;

        // Prefix
        for(int i = 0; i < nums.Length; i++){
            res[i] = helper;
            helper *= nums[i];
        }

        helper = 1;
        // Postfix
        for(int i = nums.Length - 1; i >= 0; i--){
            res[i] *= helper;
            helper *= nums[i];
        }

        return res;
    }
}
namespace Hard;

public class TrappingRainWater{
    public static int Solve(int[] height){
        // Base Case
        if(height is null || height.Length <= 2) return 0;

        int l = 0, r = height.Length - 1;
        int leftMax = height[l], rightMax = height[r];
        int res = 0;

        while(l < r){
            if(leftMax < rightMax){
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                res += leftMax - height[l];
            }
            else{
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                res += rightMax - height[r];
            }
        }

        return res;
    }
}
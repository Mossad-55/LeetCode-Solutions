namespace Medium;

public class ContainerWithMostWater{
    public static int Solve(int[] heights){
        int res = 0;
        int l = 0, r = heights.Length - 1;

        while(l < r){
            res = Math.Max(res, (r - 1) * Math.Min(heights[l], heights[r]));

            if(heights[l] > heights[r])
                r--;
            else
                l++;
        }

        return res;
    }
}
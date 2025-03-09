namespace Easy;

public class ContainsDuplicate{
    public static bool Solution(int[] nums){
        HashSet<int> hash = new(nums);

        return hash.Count == nums.Length ? false : true;
    }
}
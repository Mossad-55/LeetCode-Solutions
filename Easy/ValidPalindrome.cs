namespace Easy;

public class ValidPalindrome{
    public static bool Solve(string s){
        // Base Case 
        if(s.Length == 1) return true;

        int left = 0, right = s.Length - 1;
        while(left < right){
            if(!char.IsLetterOrDigit(s[left])){
                left++;
                continue;
            }

            if(!char.IsLetterOrDigit(s[right])){
                right--;
                continue;
            }

            if(char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }

        return true;
    }
}
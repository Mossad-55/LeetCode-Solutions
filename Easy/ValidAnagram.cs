namespace Easy;

public class ValidAnagram{
    public static bool Solution(string s, string t){
        // Base Case
        if(s.Length != t.Length)
            return false;

        int[] s_map = new int[26];
        int[] t_map = new int[26];

        for(int i = 0; i < s.Length; i++){
            s_map[s[i] - 'a']++;
            t_map[s[i] - 'a']++;
        }

        for(int i = 0; i < 26; i++){
            if(s_map[i] != t_map[i])
                return false;
        }

        return true;
    }
}
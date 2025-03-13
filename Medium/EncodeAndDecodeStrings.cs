namespace Medium;

public class EncodeAndDecodeStrings{
    public static string Encode(IList<string> strs){
        string res = "";
        foreach(var s in strs)
            res += s.Length + "#" + s;
        
        return res;
    }

    public static List<string> Decode(string s){
        var res = new List<string>();
        int i = 0;
        
        while(i < s.Length){
            int j = i;

            while(s[j] != '#')
                j++;
            
            int len = int.Parse(s.Substring(i, j - i));
            i = j + 1;

            res.Add(s.Substring(i, len));
            i += len;
        }

        return res;
    }
}
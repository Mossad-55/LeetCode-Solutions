namespace Medium;

public class GroupAnagrams{
    public static IList<IList<string>> Solve(string[] strs){
        var dic = new Dictionary<string, List<string>>();
        var res = new List<IList<string>>();

        foreach(var s in strs){
            var key = string.Concat(s.OrderBy(c => c));

            if(dic.ContainsKey(key))
                dic[key].Add(s);
            else
                dic[key] = new List<string>() { s };
        }
        
        foreach(var key in dic)
            res.Add(key.Value);

        return res;
    }
}
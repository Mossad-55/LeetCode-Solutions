namespace Medium;

public class TopKFrequentElements{
    public static int[] Solve(int[] nums, int k){
        Dictionary<int, int> freqMap = new();
        var res = new int[k];

        for(int i = 0; i < nums.Length; i++){
            if(freqMap.ContainsKey(nums[i]))
                freqMap[nums[i]]++;
            else
                freqMap[nums[i]] = 1;
        }

        PriorityQueue<int, int> pq = new();
        foreach(var key in freqMap.Keys){
            pq.Enqueue(key, freqMap[key]);
            if(pq.Count > k)
                pq.Dequeue();
        }

        int j = k;
        while(pq.Count > 0)
            res[--j] = pq.Dequeue();

        return res;
    }
}
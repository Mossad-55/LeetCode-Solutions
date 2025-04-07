namespace Easy;

public class BestTimeToBuyAnsSell{
    public static int Solve(int[] prices){
        // Base Case 
        if(prices.Length <= 1) return 0;

        int maxProfit = 0, minBuy = prices[0];
        for(int i = 1; i < prices.Length; i++){
            maxProfit = Math.Max(maxProfit, prices[i] - minBuy);
            minBuy = Math.Min(minBuy, prices[i]);
        }

        return maxProfit;
    }
}
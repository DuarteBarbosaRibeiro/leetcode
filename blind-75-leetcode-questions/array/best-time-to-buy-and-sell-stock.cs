public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int min_price = int.MaxValue;
        
        for (int index = 0; index < prices.Length; index++) {
            if (prices[index] < min_price)
                min_price = prices[index];
            if (prices[index] - min_price > result)
                result = prices[index] - min_price;
        }

        return result;
    }
}
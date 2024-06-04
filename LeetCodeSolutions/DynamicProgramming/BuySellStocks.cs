namespace LeetCodeSolutions.DynamicProgramming
{
    public class BuySellStocks
    {
        public int MaxProfit(int[] prices)
        {
            int l = 0, r = 1, maxProfit = 0;

            while (r < prices.Length)
            {
                if (prices[l] < prices[r])
                    maxProfit = int.Max(maxProfit, prices[r] - prices[l]);
                else
                    l = r;
                r++;
            }

            return maxProfit;

        }
    }
}

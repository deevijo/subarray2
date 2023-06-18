using System;
using System.Linq;
using System.Collections;

namespace subarray2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] prices = { 7, 6, 4, 3, 1 };
            int daytosell = MaxProfit(prices); //leetcode 121
            Console.WriteLine(daytosell);
        }

        static int MaxProfit(int[] prices)
        {
            int smallint = prices[0];
            int maxdiff = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (smallint > prices[i])
                {
                    smallint = prices[i];
                }
                else
                    maxdiff = Math.Max(prices[i] - smallint, maxdiff);
            }

            return maxdiff;
        }
    }
}

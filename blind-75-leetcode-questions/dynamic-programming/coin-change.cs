public class Solution {
    public int CoinChange(int[] coins, int amount) {
        /*
            I had to look the solution to this one
            up, but I actually learned about dynamic
            programming. The idea is to optimize
            recursion by storing previous results of
            the problem to avoid recomputing it.

            Here the smaller amounts of amount are
            computed so that for any amount, you look
            up for each coin the amount of coins for
            amount - coin and add 1, then take the
            minimum value.
        */
        int[] amounts = new int[amount + 1];
        amounts[0] = 0;
        for (int i = 1; i < amounts.Length; i++)
            amounts[i] = int.MaxValue;
        for (int i = 1; i < amounts.Length; i++) {
            foreach (int coin in coins) {
                if (coin <= i) {
                    if (amounts[i - coin] == int.MaxValue)
                        continue;
                    int temp = amounts[i - coin] + 1;
                    if (temp < amounts[i])
                        amounts[i] = temp;
                }
            }
        }
        return amounts[amount] == int.MaxValue ? -1 : amounts[amount];
    }
}
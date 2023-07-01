public class Solution {
    public int HammingWeight(uint n) {
        Console.WriteLine(n);
        int result = 0;
        while (n > 0) {
            result += (int) (n % 2);
            n = n >> 1;
        }
        return result;
    }
}
public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        int bits = 0;
        while (n > 0) {
            result = (result << 1) + (n % 2);
            n = n >> 1;
            bits++;
        }
        return result << (32 - bits);
    }
}
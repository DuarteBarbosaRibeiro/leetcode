public class Solution {
    bool ValidInt(string s) {
        if (s == string.Empty)
            return false;
        bool result = true;
        int i = 0;
        if (s[i] == '+' || s[i] == '-')
            i++;
        if (i == s.Length)
            return false;
        while (i < s.Length) {
            if (s[i] < '0' || s[i] > '9') {
                result = false;
                break;
            }
            i++;
        }
        return result;
    }

    bool ValidDecimal(string s) {
        float num;
        bool result = float.TryParse(s, out num);
        if (num == float.PositiveInfinity || num == float.NegativeInfinity)
            return false;
        return result;
    }

    public bool IsNumber(string s) {
        char[] delimeters = { 'e', 'E' };
        string[] split = s.Split(delimeters);
        
        if (split.Length > 2)
            return false;
        
        if (!ValidDecimal(split[0]))
            return false;
        if (split.Length == 1)
            return true;
        return ValidInt(split[1]);
    }
}
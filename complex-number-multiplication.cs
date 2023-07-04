public class Solution {
    (int, int) StringToInt(string num) {
        string[] split = num.Split("+");
        return (
            int.Parse(split[0]),
            int.Parse(split[1].Substring(0, split[1].Length - 1))
        );
    }

    public string ComplexNumberMultiply(string num1, string num2) {
        (int, int) a = StringToInt(num1);
        (int, int) b = StringToInt(num2);
        (int, int) result = (0, 0);
        result.Item1 = (a.Item1 * b.Item1) - (a.Item2 * b.Item2);
        result.Item2 = (a.Item1 * b.Item2) + (a.Item2 * b.Item1);
        return string.Format("{0}+{1}i", result.Item1, result.Item2);
    }
}
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, bool> uniques = new Dictionary<int, bool>();

        foreach (int num in nums) {
            if (uniques.ContainsKey(num))
                return true;
            uniques.Add(num, true);
        }
        return false;
    }
}
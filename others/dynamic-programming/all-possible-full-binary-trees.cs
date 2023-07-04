/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    /*
        dp[i] represents all the possible full binary trees
        with i nodes. To get dp[i + 2] (since i cannot be
        even), you just need to use all full binary trees
        that add up to i - 1.
        Example: i = 7. The head node can have 1 node on
        the left and 5 on the right, 3 and 3 or 5 and 1.
    */
    public IList<TreeNode> AllPossibleFBT(int n) {
        if (n % 2 == 0)
            return new List<TreeNode>();
        IList<TreeNode>[] dp = new List<TreeNode>[n + 1];
        dp[1] = new List<TreeNode> { new TreeNode(0) };
        for (int i = 3; i <= n; i += 2) {
            dp[i] = new List<TreeNode>();
            for (int j = 1; j < i; j += 2)
                foreach (TreeNode left in dp[j])
                    foreach (TreeNode right in dp[i - j - 1])
                        dp[i].Add(new TreeNode(0, left, right));
        }
        return dp[n];
    }
}
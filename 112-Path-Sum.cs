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
    bool Sol(TreeNode root,int Target,int Sum)
    {
        if(root == null)
         return false;

        Sum += root.val;

        if (root.left == null && root.right == null)
            return Sum == Target;

        bool left = Sol(root.left,Target,Sum);
        bool right = Sol(root.right,Target,Sum);

        return left || right;
    }
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        return Sol(root,targetSum,0);
    }
}
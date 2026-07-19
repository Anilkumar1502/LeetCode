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

    int cnt=0;
    public int CountDominantNodes(TreeNode root) {

        DFS(root);
        return cnt;
    }

    private int DFS(TreeNode r){
        if(r==null)
        return 0;

        int val=r.val;
        int lt=DFS(r.left);
        int rt=DFS(r.right);

        int max=Math.Max(lt,rt);
        if(val>=max){
            cnt+=1;
            return val;
        }
        return max;
    }
    
}

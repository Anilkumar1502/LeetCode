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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        Dictionary<int,(TreeNode n,bool isCld)> exist=new(2*descriptions.Length);


        foreach(int[] node in descriptions){
            int p=node[0];
            int c=node[1];
            int l=node[2];

            TreeNode pn=new(p);
            if(exist.ContainsKey(p)){
                pn=exist[p].n;
            }
            else{
                exist[p]=(pn,false);
            }

            TreeNode cn=new(c);
            if(exist.ContainsKey(c)){
                cn=exist[c].n;               
            }
            exist[c]=(cn,true);

            if(l==1){
                pn.left=cn;
            }
            else{
                pn.right=cn;
            }
           
        }

        foreach(var kv in exist){
            if(!kv.Value.isCld)
            return kv.Value.n;
        }
        return null;
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int PairSum(ListNode head) {
        
        ListNode sptr=head;
        ListNode fptr=head;
        ListNode nxt=null;

        while(fptr!=null&&fptr.next!=null){
            fptr=fptr.next.next;

            ListNode s=sptr.next;
            sptr.next=nxt;
            nxt=sptr;
            sptr=s;
        }

        ListNode t1=nxt;
        ListNode t2=sptr;
        if(t1==null){
            return head.val+head.next.val;
        }

        
        int max=int.MinValue;
        while(t2!=null){
            max=Math.Max(t1.val+t2.val,max);
            t2=t2.next;
            t1=t1.next;
        }
        return max;


    }
}

public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode slowPtr=head;
        ListNode fastPtr=head;

        while(fastPtr!=null&&fastPtr?.next!=null){
            slowPtr=slowPtr.next;
            fastPtr=fastPtr?.next?.next;
        }
        return slowPtr;
    }
}

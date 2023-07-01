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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        List<ListNode> nodes = new();
        ListNode node = head;
        while (node is not null) {
            nodes.Add(node);
            node = node.next;
        }
        if (n == nodes.Count) {
            head = head.next;
            return head;
        }
        nodes[nodes.Count - n - 1].next = nodes[nodes.Count - n].next;
        return head;
    }
}
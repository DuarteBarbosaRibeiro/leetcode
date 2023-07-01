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
    public void ReorderList(ListNode head) {
        List<ListNode> nodes = new();
        ListNode node = head;
        while (node is not null) {
            nodes.Add(node);
            node = node.next;
        }
        if (nodes.Count == 1)
            return;
        node = head;
        node.next = nodes.Last();
        node = node.next;
        int i = 1;
        while (i < nodes.Count / 2) {
            node.next = nodes[i];
            node = node.next;
            node.next = nodes[nodes.Count - i - 1];
            node = node.next;
            i++;
        }
        if (nodes.Count % 2 == 1) {
            node.next = nodes[i];
            node = node.next;
        }
        node.next = null;
    }
}
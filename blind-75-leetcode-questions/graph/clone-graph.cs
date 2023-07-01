/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    void AddNodes(IList<Node> nodes_list, Dictionary<int, Node> nodes_table) {
        foreach (Node node in nodes_list) {
            if (!nodes_table.ContainsKey(node.val)) {
                nodes_table.Add(node.val, node);
                AddNodes(node.neighbors, nodes_table);
            }
        }
    }

    public Node CloneGraph(Node node) {
        if (node is null)
            return null;

        // Recursively add nodes to table
        Dictionary<int, Node> nodes = new();
        AddNodes(new List<Node>() { node }, nodes);

        // Copy node values
        Dictionary<int, Node> nodes_copy = new();
        foreach (int val in nodes.Keys)
            nodes_copy.Add(val, new Node(val));
        Node result = nodes_copy[1];

        // Copy node neighbors
        foreach (Node node_copy in nodes_copy.Values)
            foreach (Node neighbor in nodes[node_copy.val].neighbors) 
                node_copy.neighbors.Add(nodes_copy[neighbor.val]);

        return result;
    }
}
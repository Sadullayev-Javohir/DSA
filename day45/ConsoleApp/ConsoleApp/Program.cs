// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }
//
// class Program
// {
//     static bool HasPathSum(TreeNode root, int targetSum)
//     {
//         if (root == null) return false;
//
//         var stack = new Stack<(TreeNode root, int sum)>();
//         stack.Push((root, root.val));
//
//         while (stack.Count > 0)
//         {
//             var (node, sum) = stack.Pop();
//             if (node.left == null && node.right == null && sum == targetSum) return true;
//             if (node.right != null) stack.Push((node.right, sum + node.right.val));
//             if (node.left != null) stack.Push((node.left, sum + node.left.val));
//             Console.WriteLine(sum);
//         }
//
//         return false;
//     }
//
//     static void Main()
//     {
//         TreeNode root = new TreeNode(5);
//         root.left = new TreeNode(4);
//         root.left.left = new TreeNode(11);
//         root.left.left.left = new TreeNode(7);
//         root.left.left.right = new TreeNode(2);
//         
//         root.right = new TreeNode(8);
//         root.right.left = new TreeNode(13);
//         root.right.right = new TreeNode(4);
//         root.right.right.right = new TreeNode(1);
//         // TreeNode root = new TreeNode();
//         // root.left = new TreeNode(2);
//         // root.right = new TreeNode(3);
//         Console.Write(HasPathSum(root, 22));
//         
//         
//     }
// }

class Node
{
    public int val;
    public Node left;
    public Node right;
    public int height;

    public Node(int value)
    {
        val = value;
        height = 1;
    }
}

class AVL
{
    int Height(Node n) => n == null ? 0 : n.height;
    int GetBalance(Node n) => n == null ? 0 : Height(n.left) - Height(n.right);

    // LL case
    Node RightRotation(Node y)
    {
        Node x = y.right;
        Node T2 = x.right;

        x.right = y;
        y.left = T2;

        y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
        x.height = Math.Max(Height(x.left), Height(y.right)) + 1;
        return x;
    }

    // rr case
    Node LeftRotation(Node x)
    {
        Node y = x.right;
        Node T2 = y.right;

        y.right = x;
        x.right = T2;

        x.height = Math.Max(Height(x.left), Height(x.right)) + 1;
        y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
        return y;
    }

    public Node Insert(Node node, int key)
    {
        if (node == null) return new Node(key);
        if (key < node.val) node.left = Insert(node.left, key);
        if (key > node.val) node.right = Insert(node.right, key);
        else return node;

        node.height = 1 + Math.Max(Height(node.left), Height(node.right));
        int balance = GetBalance(node);

        if (balance > 1 && key < node.left.val) return RightRotation(node);
        if (balance < -1 && key > node.right.val) return LeftRotation(node);
    }
        
}

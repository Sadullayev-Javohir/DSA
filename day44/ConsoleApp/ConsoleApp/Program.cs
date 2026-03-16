// using System.Collections;
//
// public class Node
// {
//     public int Value;
//     public Node Right;
//     public Node Left;
//     public Node (int value) => Value = value;
// }
//
// public class Program
// {
//     static void Main()
//     {
//         Node root = new Node(10);
//         root.Left = new Node(5);
//         root.Left.Left = new Node(3);
//         root.Left.Right = new Node(7);
//
//         root.Right = new Node(20);
//         root.Right.Left = new Node(15);
//         
//         // DFSIterative( root);
//         Queue<Node> queue = new Queue<Node>();
//         queue.Enqueue(root);
//         BFSRecursive(queue);
//         
//     }
//     
//
//     public static void BFSRecursive(Queue<Node> queue)
//     {
//         if (queue.Count == 0) return;
//         var node = queue.Dequeue();
//         Console.Write(node.Value + " ");
//         
//         if (node.Left != null) queue.Enqueue(node.Left);
//         if (node.Right != null) queue.Enqueue(node.Right);
//         BFSRecursive(queue);
//     }
//     public static void DFSIterative(Node root)
//     {
//         if (root == null) return;
//         Stack<Node> stack = new Stack<Node>();
//         stack.Push(root);
//
//         while (stack.Count > 0)
//         {
//             var node = stack.Pop();
//             
//             Console.WriteLine(node.Value + " ");
//             if (node.Right != null) stack.Push(node.Right);
//             if (node.Left != null) stack.Push(node.Left);
//         }
//     }
//     public static void DFSRecursive(Node root)
//     {
//         if (root == null) return;
//         Console.Write(root.Value + " ");
//         DFSRecursive(root.Left);
//         DFSRecursive(root.Right);
//     }
// }

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

// public class Solution {
//     public int MaxDepth(TreeNode root)
//     {
//         if (root == null) return 0;
//         int max1 = 0, max2 = 0, max = 0;
//         max1 = MaxDepth(root.left) + 1;
//         max2 = MaxDepth(root.right) + 1;
//
//         return max = Math.Max(max1, max2);
//     }
// }
// public class Solution
// {
//     public static TreeNode InvertTree(TreeNode root)
//     {
//         if (root == null) return null;
//
//         (root.left, root.right) = (root.right, root.left);
//
//         InvertTree(root.left);
//         InvertTree(root.right);
//         return root;
//     }
//     public static void BFSRecursive(Queue<TreeNode> queue)
//      {
//          if (queue.Count == 0) return;
//          var node = queue.Dequeue();
//          Console.Write(node.val + " ");
//          
//          if (node.left != null) queue.Enqueue(node.left);
//          if (node.right != null) queue.Enqueue(node.right);
//          BFSRecursive(queue);
//      }
//     public static bool IsSameTree(TreeNode p, TreeNode q)
//     {
//         if (p == null && q == null) return true;
//         if (p == null || q == null) return false;
//         
//         if (p.val != q.val) return false;
//         return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         TreeNode root1 = new TreeNode(1);
//         root1.left = new TreeNode(2);
//         root1.right = new TreeNode(3);
//     
//         TreeNode root2 = new TreeNode(1);
//         root2.left = new TreeNode(2);
//         root2.right = new TreeNode(3);
//         
//         Console.WriteLine(Solution.IsSameTree(root1, root2));
//         
//         // TreeNode root = new TreeNode(4);
//         // root.left = new TreeNode(7);
//         // root.left.left = new TreeNode(9);
//         // root.left.right = new TreeNode(6);
//         //
//         // root.right = new TreeNode(2);
//         // root.right.left = new TreeNode(3);
//         // root.right.right = new TreeNode(1);
//         //
//         // Queue<TreeNode> queue = new Queue<TreeNode>();
//         // Solution sol = new Solution();
//         // TreeNode root1 = Solution.InvertTree(root);
//         // queue.Enqueue(root1);
//         //
//         // Solution.BFSRecursive(queue);
//         // TreeNode root = new TreeNode(3);
//         // root.left = new TreeNode(9);
//         // root.right = new TreeNode(20);
//         // root.right.left = new TreeNode(15);
//         // root.right.right = new TreeNode(7);
//
//         // TreeNode root = new TreeNode(1);
//         // root.right = new TreeNode(2);
//         //
//         // Solution sol = new Solution();
//         // Console.WriteLine(sol.MaxDepth(root));
//     }
// }



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
//     static void Main()
//     {
//         var root = new TreeNode(1);
//         root.left = new TreeNode(2);
//         root.left.right = new TreeNode(5);
//         root.right = new TreeNode(3);
//
//         var result = BinaryTreePaths(root);
//         Console.WriteLine(string.Join(", ", result));
//     }
//     
//     static IList<string> BinaryTreePaths(TreeNode root)
//     {
//         var list = new List<string>();
//         if (root == null) return list;
//
//         if (root.left == null && root.right == null)
//         {
//             list.Add(root.val.ToString());
//             return list;
//         }
//
//         foreach (var path in BinaryTreePaths(root.left))
//         {
//             list.Add(root.val + "=>" + path);
//         }
//
//         foreach (var path in BinaryTreePaths(root.right))
//         {
//             list.Add(root.val + "=>" + path);   
//         }
//
//         return list;
//     }
// }

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Program
{
    static void DFS(TreeNode root)
    {
        if (root == null) return;
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            Console.Write(node.val + " ");
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }
    }
    static void Main()
    {
        TreeNode root = new TreeNode(5);
        root.left = new TreeNode(4);
        root.left.left = new TreeNode(11);
        root.left.left.left = new TreeNode(7);
        root.left.left.right = new TreeNode(2);

        root.right = new TreeNode(8);
        root.right.left = new TreeNode(13);
        root.right.right = new TreeNode(4);
        root.right.right.right = new TreeNode(1);
        DFS(root);
    }
}
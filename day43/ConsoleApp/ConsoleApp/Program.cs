// class Node
// {
//     public int Value;
//     public Node Right;
//     public Node Left;
//     
//     public Node(int value) => Value = value;
// }
//
// class Program
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
//         root.Right.Right = new Node(25);
//         BFS(root);
//     }
//     
//     
//     // Breadth First Search
//     // static void BFS(Node root)
//     // {
//     //     if (root == null) return;
//     //
//     //     var queue = new Queue<Node>();
//     //     queue.Enqueue(root);
//     //
//     //     while (queue.Count > 0)
//     //     {
//     //         var curr = queue.Dequeue();
//     //         Console.Write(curr.Value + " ");
//     //         if (curr.Left != null) queue.Enqueue(curr.Left);
//     //         if (curr.Right != null) queue.Enqueue(curr.Right);
//     //     }
//     // }
// }

using System.Reflection.Metadata;

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
    static void Main()
    {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        // var result = LevelOrder(root);
        // foreach (var level in result)
        // {
        //     foreach (var value in level)
        //     {
        //         Console.WriteLine(value + " ");
        //     }
        //     Console.WriteLine();
        // }
        var result = RightSideView(root);
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }

    public static IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();
        if (root == null) return result;
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++)
            {
                var curr = queue.Dequeue();
                if (i == levelSize - 1) result.Add(curr.val);

                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            }
        }

        return result;
    }

    // static IList<double> AverageOfLevels(TreeNode root)
    // {
    //     var result = new List<double>();
    //     var queue = new Queue<TreeNode>();
    //     queue.Enqueue(root);
    //
    //     while (queue.Count > 0)
    //     {
    //         int levelSize = queue.Count;
    //         var level = new List<int>();
    //         double Average = 0;
    //         for (int i = 0; i < levelSize; i++)
    //         {
    //             var curr = queue.Dequeue();
    //             Average += curr.val;
    //             if (curr.left != null) queue.Enqueue(curr.left);
    //             if (curr.right != null) queue.Enqueue(curr.right);
    //         }
    //         result.Add(Average / levelSize);
    //     }
    //
    //     return result;
    // }


    // static IList<IList<int>> LevelOrder(TreeNode root)
    // {
    //     var result = new List<IList<int>>();
    //     if (root == null) return result;
    //     var queue = new Queue<TreeNode>();
    //     queue.Enqueue(root);
    //
    //     while (queue.Count > 0)
    //     {
    //         int levelSize = queue.Count;
    //         var level = new List<int>();
    //
    //         for (int i = 0; i < levelSize; i++)
    //         {
    //             var node = queue.Dequeue();
    //             level.Add(node.val);
    //             
    //             if (node.left != null) queue.Enqueue(node.left);
    //             if (node.right != null) queue.Enqueue(node.right);
    //         }
    //         result.Insert(0, level);
    //     }
    //
    //     return result;
    // }
}
// using System.ComponentModel;
//
// class TreeNode
// {
//     public string Value;
//     public TreeNode Parent;
//     public List<TreeNode> Children = new List<TreeNode>();
//
//     public TreeNode(string value) => Value = value;
//
//     public void AddChild(TreeNode child)
//     {
//         child.Parent = this;
//         Children.Add(child);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         TreeNode A = new TreeNode("A");
//         TreeNode B = new TreeNode("B");
//         TreeNode C = new TreeNode("C");
//         TreeNode D = new TreeNode("D");
//         TreeNode E = new TreeNode("E");
//         TreeNode F = new TreeNode("F");
//         TreeNode G = new TreeNode("G");
//         
//         A.AddChild(B);
//         A.AddChild(C);
//         A.AddChild(D);
//         
//         B.AddChild(E);
//         B.AddChild(F);
//         
//         D.AddChild(G);
//         
//         Console.WriteLine($"Root: {A.Value}");
//         Console.WriteLine($"B ning parenti: {B.Parent.Value}");
//         Console.WriteLine($"A ning childreni:");
//         foreach (var child in A.Children)
//         {
//             Console.WriteLine(child.Value);
//         }
//         
//         Console.WriteLine("LeafNodes: ");
//         LeafNodes(A);
//         
//         Console.WriteLine("Depth(E): " + GetDepth(E));
//         
//         Console.WriteLine("Height(A): " + GetHeight(A));
//         
//         Console.WriteLine("A childlari soni: " + A.Children.Count );
//
//         PrintTree(D);
//     }
//
//     static void PrintTree(TreeNode node, int value = 0)
//     {
//         Console.WriteLine(new string(' ', value * 4) + node.Value);
//         foreach (var child in node.Children)
//         {
//             PrintTree(child, value +  1);
//         }
//     }
//
//     static int GetDepth(TreeNode node)
//     {
//         int depth = 0;
//
//         while (node.Parent != null)
//         {
//             depth++;
//             node = node.Parent;
//         }
//
//         return depth;
//     }
//
//     static int GetHeight(TreeNode node)
//     {
//         if (node.Children.Count == 0) return 0;
//         int maxHeight = 0;
//
//         foreach (var child in node.Children)
//         {
//             int height = GetHeight(child);
//             maxHeight = (height > maxHeight) ? height : maxHeight;
//         }
//
//         return maxHeight + 1;
//     }
//     static void LeafNodes(TreeNode node)
//     {
//         if (node.Children.Count == 0)
//         {
//             Console.WriteLine(node.Value);
//             return;
//         }
//
//         foreach (var child in node.Children)
//         {
//             LeafNodes(child);
//         }
//     }
//     
// }
//
// class BinaryTree
// {
//     public string Value;
//     public BinaryTree Left;
//     public BinaryTree Right;
//     public BinaryTree Parent;
//
//     public BinaryTree(string value) => Value = value;   
// }
//
// class Program
// {
//     static void Main()
//     {
//         BinaryTree root = new BinaryTree("A");
//         root.Left  = new BinaryTree("B");
//         root.Left.Parent = root;
//         root.Right = new BinaryTree("C");
//         root.Left.Left = new BinaryTree("D");
//         root.Left.Right = new BinaryTree("E");
//         root.Right.Right = new BinaryTree("F");
//         PrintBinaryTree(root);
//         Console.WriteLine(IsLeaf(root.Left.Left));
//         Console.WriteLine(CountNodes(root));
//         Console.WriteLine(CountLeafNodes(root));
//         Console.WriteLine(GetHeight(root.Left.Left));
//         // Console.WriteLine(GetDepth(root.Parent));
//         // PreOrder(root);
//         // InOrder(root);
//         PostOrder(root);
//     }
//
//     static void PostOrder(BinaryTree node)
//     {
//         if (node == null) return;
//         
//         PostOrder(node.Left);
//         PostOrder(node.Right);
//         Console.Write(node.Value + " ");
//     }
//
//     static void InOrder(BinaryTree node)
//     {
//         if (node == null) return;
//         InOrder(node.Left);
//         Console.Write(node.Value + " ");
//         InOrder(node.Right);
//     }
//
//     static void PreOrder(BinaryTree node)
//     {
//         if (node == null) return;
//         
//         Console.WriteLine(node.Value + " ");
//         PreOrder(node.Left);
//         PreOrder(node.Right);
//     }
//     
//     static int GetDepth(BinaryTree node)
//     {
//         int depth = 0;
//
//         while (node.Parent != null)
//         {
//             depth++;
//             node = node.Parent;
//         }
//
//         return depth;
//     }
//
//     static int GetHeight(BinaryTree node)
//     {
//         if (node == null) return -1;
//         int leftHeight = GetHeight(node.Left);
//         int rightHeight = GetHeight(node.Right);
//         
//         return Math.Max(leftHeight, rightHeight) + 1;
//     }
//
//     static int CountLeafNodes(BinaryTree node)
//     {
//         if (node == null) return 0;
//         if (node.Left == null && node.Right == null) return 1;
//         
//         return CountLeafNodes(node.Left) + (CountLeafNodes(node.Right));
//     }
//     static int CountNodes(BinaryTree node)
//     {
//         if (node == null) return 0;
//         return 1 + (CountNodes(node.Left) + (CountNodes(node.Right)));
//     }
//
//     static bool IsLeaf(BinaryTree node) => node != null && node.Left == null && node.Right == null;
//     static void PrintBinaryTree(BinaryTree node, int level = 0)
//     {
//         if (node == null) return;
//         
//         Console.WriteLine(new string(' ', level * 4) + node.Value);
//         
//         PrintBinaryTree(node.Left, level + 1);
//         PrintBinaryTree(node.Right, level + 1);
//         
//     }
//     
//     
// }

class BinaryTree
{
    public string Value;
    public BinaryTree Left;
    public BinaryTree Right;

    public BinaryTree(string value)
    {
        Value = value;
    }
}

class Program
{
    static void Main()
    {
        var root = new BinaryTree("A");
        root.Left = new BinaryTree("B");

        root.Right = new BinaryTree("C");
        root.Left.Left = new BinaryTree("D");
        root.Left.Right = new BinaryTree("E");
        root.Right.Right = new BinaryTree("F");

        PrintTree(root);
        Console.WriteLine(IsLeaf(root.Left.Right.Right));
        Console.WriteLine(NodeCount(root));
        Console.WriteLine(LeafNodesCount(root));
        Console.WriteLine(GetHeight(root));
        PreOrder(root);
        InOrder(root);
        PostOrder(root);
    }

    static void PostOrder(BinaryTree node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Value + " ");
    }
    static void InOrder(BinaryTree node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Value + " ");
        InOrder(node.Right);
    }
 
    static void PreOrder(BinaryTree node)
    {
        if (node == null) return;
        
        Console.Write(node.Value + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    static int GetHeight(BinaryTree node)
    {
        if (node == null) return -1;
        int leftHeight = GetHeight(node.Left);
        int rightHeight = GetHeight(node.Right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    static int LeafNodesCount(BinaryTree node)
    {
        if (node == null) return 0;
        if (node.Left == null && node.Right == null) return 1;
        return LeafNodesCount(node.Left) + LeafNodesCount(node.Right);
    }

    static int NodeCount(BinaryTree node)
    {
        if (node == null) return 0;
        return 1 + NodeCount(node.Left) + NodeCount(node.Right);
    }

    static bool IsLeaf(BinaryTree node) => node != null && node.Left == null && node.Right == null;


    static void PrintTree(BinaryTree node, int level = 0)
    {
        if (node == null) return;
        Console.WriteLine(new string(' ', level * 4) + node.Value);
        PrintTree(node.Left, level + 1);
        PrintTree(node.Right, level + 1);
    }
}
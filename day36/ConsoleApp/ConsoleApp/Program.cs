// class TreeNode
// {
//     public string Value;
//     public TreeNode Parent;
//     public List<TreeNode> Children;
//
//     public TreeNode(string value)
//     {
//         Value = value;
//         Children = new List<TreeNode>();
//     }
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
//         // 3. Root
//         Console.WriteLine("Root: " + A.Value);
//
//         // 4. Parent va child
//         Console.WriteLine("A ning childlari: ");
//         foreach (var child in A.Children)
//         {
//             Console.WriteLine("  -  " + child.Value);
//         }
//
//         Console.WriteLine("\nB ning parenti: " + B.Parent.Value);
//         Console.WriteLine("\nE ning parenti: " + E.Parent.Value);
//
//         // 5. Leaf Nodelar
//         Console.WriteLine("\n Leaf nodelar: ");
//         PrintLeafNodes(A);
//
//         // 6. Degree
//         Console.WriteLine("\nDegree(A): " + A.Children.Count);
//         Console.WriteLine("Degree(B): " + B.Children.Count);
//         Console.WriteLine("Degree(C): " + C.Children.Count);
//         Console.WriteLine("Degree(D): " + D.Children.Count);
//
//         //7. Depth
//         Console.WriteLine("\nDepth(A): " + GetDepth(A));
//         Console.WriteLine("Depth(B): " + GetDepth(B));
//         Console.WriteLine("Depth(E): " + GetDepth(E));
//         Console.WriteLine("Depth(G): " + GetDepth(G));
//
//         // 8. Height
//         Console.WriteLine("\nHeight(A): " + GetHeight(A));
//         Console.WriteLine("Height(B): " + GetHeight(B));
//         Console.WriteLine("Height(C): " + GetHeight(C));
//         Console.WriteLine("Height(D): " + GetHeight(D));
//         
//         // 9. SubTree
//         Console.WriteLine("\nB subtree: ");
//         PrintTree(B, 0);
//         
//         Console.WriteLine("\n Butun tree: ");
//         PrintTree(A, 0);
//     }
//
//     static void PrintLeafNodes(TreeNode node)
//     {
//         if (node.Children.Count == 0)
//         {
//             Console.WriteLine(node.Value);
//             return;
//         }
//
//         foreach (var child in node.Children)
//         {
//             PrintLeafNodes(child);
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
//
//         int maxChildHeight = 0;
//         foreach (var child in node.Children)
//         {
//             int childHeight = GetHeight(child);
//             if (childHeight > maxChildHeight) maxChildHeight = childHeight;
//         }
//
//         return maxChildHeight + 1;
//     }
//
//     static void PrintTree(TreeNode node, int level)
//     {
//         Console.WriteLine(new string(' ', level * 4) + node.Value);
//
//         foreach (var child in node.Children)
//         {
//             PrintTree(child, level + 1);
//         }
//     }
//
// }

// class  TreeNode
// {
//     public string Value;
//     public TreeNode Parent;
//     public List<TreeNode> Children;
//
//     public TreeNode(string value)
//     {
//         Value = value;
//         Children = new List<TreeNode>();
//     }
//
//     public void AddChild(TreeNode node)
//     {
//         node.Parent = this;
//         Children.Add(node); 
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
//         B.AddChild(E);
//         B.AddChild(F);
//         D.AddChild(G);
//
//         // 1. Root
//         Console.WriteLine("Root: " + A.Value);
//
//         // 2. Parent va Child
//         Console.WriteLine("A ning childlari :");
//         foreach (var child in A.Children)
//         {
//             Console.WriteLine("-  " + child.Value);
//         }
//
//         Console.WriteLine("\n B ning parenti: " + B.Parent.Value);
//         Console.WriteLine("\n E ning parenti: " + E.Parent.Value);
//
//         Console.WriteLine("G ning parenti: " + G.Parent.Value);
//
//         // 3. Leaf nodelar
//         Console.WriteLine("\nLeaf nodelar: ");
//         PrintLeafNodes(A);
//
//         // 4. Degree
//         Console.WriteLine("Degree A: " + A.Children.Count);
//
//         // 5. Depth
//         Console.WriteLine("\nDegree(E): " + GetDepth(E));
//
//         // 6. Height
//         Console.WriteLine("\nHeight(A): " + GetHeight(A));
//         
//         // 7. Butun Tree
//         Console.WriteLine("\n Butun tree: ");
//         PrintTree(A, 0);
//         
//
//     }
//
//     static void PrintTree(TreeNode node, int level)
//     {
//         Console.WriteLine(new string(' ', level * 4) + node.Value);
//
//         foreach (var child in node.Children)
//         {
//             PrintTree(child, level + 1);
//         }
//     }
//     static int GetHeight(TreeNode node)
//     {
//         if (node.Children.Count == 0) return 0;
//
//         int maxChildHeight = 0;
//
//         foreach (var child in node.Children)
//         {
//             int childHeight = GetHeight(child);
//             maxChildHeight = (childHeight > maxChildHeight) ? childHeight : maxChildHeight;
//         }
//
//         return maxChildHeight + 1;
//     }
//
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
//     static void PrintLeafNodes(TreeNode node)
//     {
//         if (node.Children.Count == 0)
//         {
//             Console.WriteLine(node.Value);
//             return;
//         }
//
//         foreach (var child in node.Children)
//         {
//             PrintLeafNodes(child);
//         }
//     }
// }

class TreeNode
{
    public string Value;
    public TreeNode Parent;
    public List<TreeNode> Children;

    public TreeNode(string value)
    {
        Value = value;
        Children = new List<TreeNode>();
    }

    public void AddChildren(TreeNode child)
    {
        child.Parent = this;
        Children.Add(child);
    }
}

class Program
{
    static void Main()
    {
        TreeNode A = new TreeNode("A");
        TreeNode B = new TreeNode("B");
        TreeNode C = new TreeNode("C");
        TreeNode D = new TreeNode("D");
        TreeNode E = new TreeNode("E");
        TreeNode F = new TreeNode("F");
        TreeNode G = new TreeNode("G");
        
        A.AddChildren(B);
        A.AddChildren(C);
        A.AddChildren(D);
        
        B.AddChildren(E);
        B.AddChildren(F);
        G.AddChildren(G);
        
        Console.WriteLine("Root A: " + A.Value);
        Console.WriteLine("A ning childlari: ");
        foreach (var child in A.Children)
        {
            Console.WriteLine(" -  " + child.Value);
        }
        
        Console.WriteLine("Leaf Nodelar: ");
        PrintLeafNodes(A);
        
        Console.WriteLine("Degree (A): " + A.Children.Count);
        
        Console.WriteLine("Depth(D): " + GetDepth(D));
        
        Console.WriteLine("Height(A): " + GetHeight(A));
        
        Console.WriteLine("Butun tree: ");
        PrintTree(A, 0);
    }

    static void PrintTree(TreeNode node, int level)
    {
        Console.WriteLine(new string(' ', level * 4) + node.Value);
        foreach (var child in node.Children)
        {
            PrintTree(child, level + 1);
        }
    }

    static int GetHeight(TreeNode node)
    {
        if (node.Children.Count == 0) return 0;
        int maxGetHeight = 0;

        foreach (var child in node.Children)
        {
            int height = GetHeight(child);
            if (height > maxGetHeight) maxGetHeight = height;
        }

        return maxGetHeight + 1;
    }

    static int GetDepth(TreeNode node)
    {
        int depth = 0;

        while (node.Parent != null)
        {
            depth++;
            node = node.Parent;
        }

        return depth;
    }

    static void PrintLeafNodes(TreeNode node)
    {
        if (node.Children.Count == 0)
        {
            Console.WriteLine(node.Value);
            return;
        }
        foreach (var child in node.Children)
        {
            PrintLeafNodes(child);
        }
    }
}


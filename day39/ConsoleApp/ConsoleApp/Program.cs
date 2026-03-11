// class BinaryTree
// {
//     public int Value;
//     public BinaryTree Left;
//     public BinaryTree Right;
//
//     public BinaryTree(int value) => Value = value;
// }
//
// class Program
// {
//     static BinaryTree Insert(BinaryTree node, int value)
//     {
//         if (node == null) return new BinaryTree(value);
//
//         else if (node.Value > value) node.Left = Insert(node.Left, value);
//         else node.Right = Insert(node.Right, value);
//         return node;
//     }
//
//     static void PrintTree(BinaryTree node, int level = 0)
//     {
//         if (node == null) return;
//         PrintTree(node.Left, level + 1);
//         Console.WriteLine(new string(' ', 4 * level) + "|--" + node.Value);
//         // Console.Write(node.Value + " ");
//         PrintTree(node.Right, level + 1);
//     }
//
//     static BinaryTree Search(BinaryTree root, int value)
//     {
//         if (root == null || root.Value == value) return root;
//         if (root.Value > value) return Search(root.Left, value);
//         return Search(root.Right, value);
//     }
//
//     static void LevelOrder(BinaryTree node)
//     {
//         if (node == null) return;
//         Queue<BinaryTree> queue = new Queue<BinaryTree>();
//         queue.Enqueue(node);
//
//         while (queue.Count > 0)
//         {
//             var current = queue.Dequeue();
//             Console.Write(current.Value + " ");
//             if (current.Left != null) queue.Enqueue(current.Left);
//             if (current.Right != null) queue.Enqueue(current.Right);
//         }
//     }
//
//     static BinaryTree Delete(BinaryTree node, int value)
//     {
//         if (node == null) return null;
//
//         if (value < node.Value) node.Left = Delete(node.Left, value);
//         else if (value > node.Value) node.Right = Delete(node.Right, value);
//         else
//         {
//             if (node.Left == null) return node.Right;
//             if (node.Right == null) return node.Left;
//
//             BinaryTree min = FindMin(node.Right);
//             node.Value = min.Value;
//             node.Right = Delete(node.Right, min.Value);
//         }
//
//         return node;
//     }
//
//     static BinaryTree FindMin(BinaryTree node)
//     {
//         while (node.Left != null) node = node.Left;
//         return node;
//     }
//     static void Main()
//     {
//         BinaryTree node = null;
//
//         node = Insert(node, 50);
//         node = Insert(node, 30);
//         node = Insert(node, 70);
//         node = Insert(node, 20);
//         node = Insert(node, 40);
//         node = Insert(node, 60);
//         node = Insert(node, 80);
//
//         PrintTree(node);
//
//         // Console.WriteLine(Search(node, 20) != null ? "Topildi" : "Topilmadi");
//         Console.WriteLine(Delete(node, 20) != null ? "O'chirildi" : "topilmadi");
//
//         LevelOrder(node);
//     }
// }

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
//         Node root = new Node(4);
//         root.Left = new Node(2);
//         root.Right = new Node(6);
//         root.Left.Left = new Node(1);
//         root.Left.Right = new Node(3);
//         root.Right.Left = new Node(5);
//         root.Right.Right = new Node(7);
//
//         InOrder(root);
//         Console.WriteLine();
//         PreOrder(root);
//         Console.WriteLine();
//         PostOrder(root);
//     }
//
//     static void PreOrder(Node root)
//     {
//         if (root == null) return;
//         
//         Console.Write(root.Value + "  ");
//         PreOrder(root.Left);
//         PreOrder(root.Right);
//     }
//
//     static void InOrder(Node root)
//     {
//         if (root == null) return;
//         InOrder(root.Left);
//         Console.Write(root.Value + " ");
//         InOrder(root.Right);
//     }
//
//     static void PostOrder(Node root)
//     {
//         if (root == null) return;
//         PostOrder(root.Left);
//         PostOrder(root.Right);
//         Console.Write(root.Value + " ");
//     }
// }

// class Node
// {
//     public int Value;
//     public Node Left;
//     public Node Right;
//
//     public Node(int value) => Value = value;
// }
//
// class Program
// {
//     static Node Insert(Node root, int value)
//     {
//         if (root == null) return new Node(value);
//
//         if (root.Value > value) root.Left = Insert(root.Left, value);
//         if (root.Value < value) root.Right = Insert(root.Right, value);
//         
//         return root;
//     }
//
//     static void PrintTree(Node root, int level = 0)
//     {
//         if (root == null) return;
//         
//         PrintTree(root.Left, level + 1);
//         Console.WriteLine(new string(' ', 4 * level) + "|--" + root.Value);
//         PrintTree(root.Right, level + 1);
//     }
//
//     static Node Search(Node root, int value)
//     {
//         if (root == null || root.Value == value) return root;
//
//         if (root.Value > value) return Search(root.Left, value);
//         return Search(root.Right, value);
//     }
//
//     static void LevelOrder(Node root)
//     {
//         if (root == null) return;
//
//         Queue<Node> queue = new Queue<Node>();
//         queue.Enqueue(root);
//
//         while (queue.Count > 0)
//         {
//             var current = queue.Dequeue();
//             Console.Write(current.Value + " ");
//             if (current.Left != null) queue.Enqueue(current.Left);
//             if (current.Right != null) queue.Enqueue(current.Right);
//         }
//     }
//     
//     
//     
//     static void Main()
//     {
//         Node root = null;
//         root = Insert(root, 4);
//         root = Insert(root, 2);
//         root = Insert(root, 6);
//         root = Insert(root, 1);
//         root = Insert(root, 3);
//         root = Insert(root, 5);
//         root = Insert(root, 7);
//
//         PrintTree(root);
//         
//         Console.WriteLine(Search(root, 2) != null ? "Topildi" : "Topilmadi");
//
//         LevelOrder(root);
//     }
// }

class Program
{
    static void Main()
    {
        int[] arr = { 6, 2, 3, 1 };
        MergeSort(arr, 0, arr.Length - 1);
        
        Console.WriteLine(string.Join(", ", arr));
    }


    // static void MergeSort(int[] arr, int left, int right)
    // {
    //     if (left >= right) return;
    //
    //     int mid = (left + right) / 2;
    //     
    //     MergeSort(arr, 0, mid);
    //     MergeSort(arr, mid + 1, right);
    //     
    //     Merge(arr, left, mid, right);
    // }
    //
    // static void Merge(int[] arr, int left, int mid, int right)
    // {
    //     int n1 = mid - left + 1;
    //     int n2 = right - mid;
    //
    //     int[] L = new int[n1], R = new int[n2];
    //     
    //     Array.Copy(arr, left, L, 0, n1);
    //     Array.Copy(arr, mid + 1, R, 0, n2);
    //     int i = 0, j = 0, k = left;
    //
    //     while (i < n1 && j < n2)
    //     {
    //         if (L[i] < R[j]) arr[k++] = L[i++];
    //         else arr[k++] = R[j++];
    //     }
    //
    //     while (i < n1) arr[k++] = L[i++];
    //     while (j < n2) arr[k++] = R[j++];
    // }
}
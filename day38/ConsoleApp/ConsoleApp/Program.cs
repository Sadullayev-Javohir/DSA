// using System.ComponentModel.Design.Serialization;
// using System.Runtime.Serialization;
//
// class BinaryTree
// {
//     public string Value;
//     public BinaryTree Left;
//     public BinaryTree Right;
//
//     public BinaryTree(string value) => Value = value;
// }
//
// class Program
// {
//     static void Main()
//     {
//         BinaryTree root = new BinaryTree("A");
//         root.Left = new BinaryTree("B");
//         root.Right = new BinaryTree("C");
//         root.Left.Left = new BinaryTree("D");
//         root.Left.Right = new BinaryTree("E");
//         root.Right.Left = new BinaryTree("F");
//
//         PrintBinaryTree(root);
//         Console.WriteLine(IsLeaf(root.Left.Left));
//         Console.WriteLine(CountNodes(root));
//         Console.WriteLine(CountLeafNodes(root));
//         Console.WriteLine(GetHeight(root));
//
//         PreOrder(root);
//         InOrder(root);
//         Console.WriteLine();
//         PostOrder(root);
//
//     }
//
//     static void PostOrder(BinaryTree node)
//     {
//         if (node != null)
//         {
//             PostOrder(node.Left);
//             PostOrder(node.Right);
//             Console.Write(node.Value + ", ");
//         }
//     }
//     static void InOrder(BinaryTree node)
//     {
//         if (node == null) return;
//         InOrder(node.Left);
//         Console.WriteLine();
//         Console.Write(node.Value + ", ");
//         InOrder(node.Right);
//     }
//
//     static void PreOrder(BinaryTree node)
//     {
//         if (node == null) return;
//         
//         
//         Console.Write(node.Value + ", ");
//         PreOrder(node.Left);
//         PreOrder(node.Right);
//     }
//     static int GetHeight(BinaryTree node)
//     {
//         if (node == null) return -1;
//         
//         int leftHeight = (GetHeight(node.Left));
//         int rightHeight = (GetHeight(node.Right));
//         return Math.Max(leftHeight, rightHeight) + 1;
//     }
//
//     static int CountLeafNodes(BinaryTree node)
//     {
//         if (node == null) return 0;
//         if (node.Left == null && node.Right == null) return 1;
//         return CountLeafNodes(node.Left) + CountLeafNodes(node.Right);
//     }
//     static int CountNodes(BinaryTree node)
//     {
//         if (node == null) return 0;
//
//         return 1 + CountNodes(node.Left) + CountNodes(node.Right);
//     }
//     
//     static bool IsLeaf(BinaryTree node) => node != null && node.Left == null && node.Right == null;
//
//     static void PrintBinaryTree(BinaryTree node, int level = 0)
//     {
//         if (node == null) return;
//         Console.WriteLine(new string(' ', level * 4) + node.Value);
//         PrintBinaryTree(node.Left, level + 1);
//         PrintBinaryTree(node.Right, level + 1);
//     }
// }

//

using System.ComponentModel.Design.Serialization;

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
    //         if (value < root.Value) root.Left = Insert(root.Left, value);
    //         else if (value > root.Value) root.Right = Insert(root.Right, value);
    //
    //         return root;
    //     }
    //
    //     static void PrintTree(Node root, int level = 0)
    //     {
    //         if (root == null) return;
    //
    //         PrintTree(root.Left, level + 1);
    //         Console.WriteLine(new string(' ', level * 4) + "|--" + root.Value);
    //         PrintTree(root.Right, level + 1);
    //     }
    //
    //     static Node Search(Node root, int value)
    //     {
    //         if (root == null || root.Value == value) return root;
    //
    //         if (value < root.Value) return Search(root.Left, value);
    //         return Search(root.Right, value);
    //     }
    //
    //     static void InOrder(Node root)
    //     {
    //         if (root == null) return;
    //
    //         InOrder(root.Left);
    //         Console.Write(root.Value + " ");
    //         InOrder(root.Right);
    //     }
    //
    //     static void PreOrder(Node root)
    //     {
    //         if (root == null) return;
    //         Console.Write(root.Value + " ");
    //         PreOrder(root.Left);
    //         PreOrder(root.Right);
    //     }
    //
    //     static void PostOrder(Node root)
    //     {
    //         if (root == null) return;
    //         PostOrder(root.Left);
    //         PostOrder(root.Right);
    //         Console.Write(root.Value + " ");
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
    //     static Node Delete(Node root, int value)
    //     {
    //         if (root == null) return null;
    //
    //         if (value < root.Value) root.Left = Delete(root.Left, value);
    //         else if (value > root.Value) root.Right = Delete(root.Right, value);
    //
    //         else
    //         {
    //             if (root.Left == null) return root.Right;
    //             if (root.Right == null) return root.Left;
    //
    //             Node min = FindMin(root.Right);
    //             root.Value = min.Value;
    //             root.Right = Delete(root.Right, min.Value);
    //         }
    //
    //         return root;
    //     }
    //
    //
    //     static Node FindMin(Node node)
    //     {
    //         while (node.Left != null) node = node.Left;
    //         return node;
    //     }
    //
    //     static void Main()
    //     {
    //         Node root = null;
    //
    //         root = Insert(root, 50);
    //         root = Insert(root, 30);
    //         root = Insert(root, 70);
    //         root = Insert(root, 20);
    //         root = Insert(root, 40);
    //
    //         PrintTree(root);
    //
    //         var node = Search(root, 42);
    //         Console.WriteLine(node != null ? "Topildi" : "Topilmadi");
    //
    //         InOrder(root);
    //         Console.WriteLine();
    //         PreOrder(root);
    //         Console.WriteLine();
    //         PostOrder(root);
    //         Console.WriteLine();
    //         LevelOrder(root);
    //     }
    // }
    class Node
    {
        public int Value;
        public Node Right;
        public Node Left;
        
        public Node(int value) => Value = value;    
    }

    class Program
    {
        static void Main()
        {
            Node root = null;

            root = Insert(root, 50);
            root = Insert(root, 30);
            root = Insert(root, 70);
            root = Insert(root, 20);
            root = Insert(root, 40);
            
            Console.WriteLine("Tree: ");
            PrintTree(root);
            
            Console.WriteLine(Search(root, 10) != null ? "Topildi" : "Topilmadi");
            
            Console.WriteLine("LevelOrder: ");
            LevelOrder(root);
        }
        
        static Node Insert(Node root, int value)
        {
            if (root == null) return new Node(value);

            if (value < root.Value) root.Left = Insert(root.Left, value);
            else if (value > root.Value) root.Right = Insert(root.Right, value);
            return root;
        }

        static void PrintTree(Node root, int level = 0)
        {
            if (root == null) return;
            PrintTree(root.Right, level + 1);
            Console.WriteLine(new string(' ', level * 4) + "|-- " + root.Value);
            PrintTree(root.Left, level + 1);
        }

        static Node Search(Node root, int value)
        {
            if (root == null || root.Value == value) return root;

            if (root.Value > value) return Search(root.Left, value);
            return Search(root.Right, value);
        }

        static void LevelOrder(Node node)
        {
            if (node == null) return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write(current.Value + " ");
                if (current.Left != null) queue.Enqueue(current.Left);
                if (current.Right != null) queue.Enqueue(current.Right);
            }
        }

        static Node Delete(Node root, int value)
        {
            if (root == null) return null;

            if (value < root.Value) root.Left = Delete(root.Left, value);
            else if (value > root.Value) root.Right = Delete(root.Right, value);
            else
            {
                if (root.Left == null) return root.Right;
                if (root.Right == null) return root.Left;

                Node min = FindMin(root.Right);
                root.Value = min.Value;
                root.Right = Delete(root.Right, min.Value);
            }

            return root;
        }

        static Node FindMin(Node node)
        {
            while (node.Left != null) node = node.Left;
            return node;
        }
    }
    
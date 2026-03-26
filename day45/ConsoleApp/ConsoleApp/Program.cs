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
//
// class Node
// {
//     public int val;
//     public Node left;
//     public Node right;
//     public int height;
//
//     public Node(int value)
//     {
//         val = value;
//         height = 1;
//     }
// }
//
// class AVL
// {
//     int Height(Node n) => n == null ? 0 : n.height;
//     int GetBalance(Node n) => n == null ? 0 : Height(n.left) - Height(n.right);
//
//     // LL case
//     Node RightRotation(Node y)
//     {
//         Node x = y.right;
//         Node T2 = x.right;
//
//         x.right = y;
//         y.left = T2;
//
//         y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
//         x.height = Math.Max(Height(x.left), Height(y.right)) + 1;
//         return x;
//     }
//
//     // rr case
//     Node LeftRotation(Node x)
//     {
//         Node y = x.right;
//         Node T2 = y.right;
//
//         y.right = x;
//         x.right = T2;
//
//         x.height = Math.Max(Height(x.left), Height(x.right)) + 1;
//         y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
//         return y;
//     }
//
//     public Node Insert(Node node, int key)
//     {
//         if (node == null) return new Node(key);
//         if (key < node.val) node.left = Insert(node.left, key);
//         if (key > node.val) node.right = Insert(node.right, key);
//         else return node;
//
//         node.height = 1 + Math.Max(Height(node.left), Height(node.right));
//         int balance = GetBalance(node);
//
//         if (balance > 1 && key < node.left.val) return RightRotation(node);
//         if (balance < -1 && key > node.right.val) return LeftRotation(node);
//     }
//         
// }

// class Node
// {
//     public int val;
//     public Node right;
//     public Node left;
//     public int height;
//
//     public Node(int value)
//     {
//         val = value;
//         height = 1;
//     }
// }
//
// class AVL
// {
//     int Height(Node n) => n == null ? 0 : n.height;
//     int GetBalance(Node n) => n == null ? 0 : Height(n.left) - Height(n.right);
//
//     Node RightRotation(Node y)
//     {
//         Node x = y.left;
//         Node T2 = x.right;
//
//         x.right = y;
//         y.left = T2;
//
//         y.height = Math.Max(Height(y.left), Height(y.right) + 1);
//         x.height = Math.Max(Height(x.left), Height(x.right) + 1);
//         
//         return x;
//     }
//
//     Node LeftRotation(Node x)
//     {
//         Node y = x.right;
//         Node T2 = y.left;
//
//         y.left = x;
//         x.right = T2;
//
//         y.height = Math.Max(Height(y.left), Height(y.right) + 1);
//         x.height = Math.Max(Height(x.left), Height(x.right) + 1);
//         return y;
//     }
//
//     public Node Insert(Node node, int key)
//     {
//         if (node == null) return new Node(key);
//         if (key < node.val) node.left = Insert(node.left, key);
//         else if (key > node.val) node.right = Insert(node.right, key);
//         else return node;
//
//         node.height = Math.Max(Height(node.left), Height(node.right) + 1);
//
//         int balance = GetBalance(node);
//
//         if (balance > 1 && key < node.left.val) return RightRotation(node);
//         if (balance < -1 && key > node.right.val) return LeftRotation(node);
//         if (balance > 1 && key > node.left.val)
//         {
//             node.left = LeftRotation(node.left);
//             return RightRotation(node);
//         }
//
//         if (balance < -1 && key < node.left.val)
//         {
//             node.right = RightRotation(node.right);
//             return LeftRotation(node);
//         }
//
//         return node;
//     }
//
//     public void InOrder(Node root)
//     {
//         if (root != null)
//         {
//             InOrder(root.left);
//             Console.Write(root.val + " ");
//             InOrder(root.right);
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         AVL tree = new AVL();
//         Node root = null;
//
//         root = tree.Insert(root, 10);
//         root = tree.Insert(root, 20);
//         root = tree.Insert(root, 30);
//         root = tree.Insert(root, 40);
//         root = tree.Insert(root, 50);
//         root = tree.Insert(root, 25);
//         
//         tree.InOrder(root);
//     }
// }


using System.Buffers;
using System.Collections;
using System.Net.NetworkInformation;

// class Node
// {
//     public int val;
//     public Node right;
//     public Node left;
//     public int height;
//
//     public Node(int val)
//     {
//         this.val = val;
//         height = 1;
//     }
// }
//
// class AVl
// {
//     public int Height(Node node) => node == null ? 0 : node.height;
//     public int GetBalance(Node node) => node == null ? 0 : Height(node.left) - Height(node.right);
//
//     public Node RightRotation(Node y)
//     {
//         Node x = y.left;
//         Node T2 = x.right;
//
//         x.right= y;
//         y.left = T2;
//
//         x.height = Math.Max(Height(x.left), Height(x.right)) + 1;
//         y.height = Math.Max(Height(y.right), Height(y.left)) + 1;
//
//         return x;
//     }
//
//     public Node LeftRotation(Node x)
//     {
//         Node y = x.right;
//         Node T2 = y.left;
//
//         y.left = x;
//         x.right = T2;
//
//         x.height = Math.Max(Height(x.left), Height(x.right)) + 1;
//         y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
//         
//         return y;
//     }
//
//     public Node Insert(Node root, int key)
//     {
//         if (root == null) return new Node(key);
//         if (key < root.val) root.left = Insert(root.left, key);
//         else if (key > root.val) root.right = Insert(root.right, key);
//         else
//         {
//             return root;
//         }
//
//         root.height = Math.Max(Height(root.left), Height(root.right)) + 1;
//         int balance = GetBalance(root);
//
//         // ll case
//         if (balance > 1 && root.left.val > key) return RightRotation(root);
//         
//         // rr case
//         if (balance < -1 && root.right.val < key) return LeftRotation(root);
//
//         if (balance > 1 && root.left.val < key)
//         {
//             root.left = LeftRotation(root.left);
//             return RightRotation(root);
//         }
//
//         if (balance < -1 && root.right.val > key)
//         {
//             root.right = RightRotation(root.right);
//             return LeftRotation(root);
//         }
//
//         return root;
//     }
//
//     public Node Delete(Node root, int key)
//     {
//         if (root == null) return root;
//
//         if (root.val > key) root.left = Delete(root.left, key);
//         else if (root.val < key) root.right = Delete(root.right, key);
//         else
//         {
//             if (root.left == null || root.right == null)
//             {
//                 Node temp = root.left ?? root.right;
//                 if (temp == null)
//                 {
//                     temp = root;
//                     root = null;
//                 }
//                 else root = temp;
//             }
//             else
//             {
//                 Node temp = MinValueNode(root.right);
//                 root.val = temp.val;
//                 root.right = Delete(root.right, temp.val);
//             }
//         }
//
//         if (root == null) return root;
//
//         root.height = Math.Max(Height(root.left), Height(root.right)) + 1;
//
//         int balance = GetBalance(root);
//         
//         // ll case
//         if (balance > 1 && GetBalance(root.left) >= 0) return RightRotation(root);
//         
//         // lr case
//         if (balance > 1 && GetBalance(root.left) < 0)
//         {
//             root.left = LeftRotation(root.left);
//             return RightRotation(root);
//         }
//         
//         // rr case
//         if (balance < -1 && GetBalance(root.right) <= 0) return LeftRotation(root);
//         if (balance < -1 && GetBalance(root.right) > 0)
//         {
//             root.right = RightRotation(root.right);
//             return LeftRotation(root);
//         }
//
//         return root;
//     }
//
//     public Node MinValueNode(Node root)
//     {
//         while (root.left != null) root = root.left;
//         return root;
//     }
//     public void PreOrder(Node root)
//     {
//         if (root != null)
//         {
//             Console.Write(root.val + " ");
//             PreOrder(root.left);
//             PreOrder(root.right);
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Node root = null;
//         AVl tree = new AVl();
//         root = tree.Insert(root, 10);
//         root = tree.Insert(root, 20);
//         root = tree.Insert(root, 30);
//         root = tree.Insert(root, 40);
//         root = tree.Insert(root, 50);
//         root = tree.Insert(root, 60);
//         root = tree.Delete(root, 10);
//         tree.PreOrder(root);
//     }
// }

class TreeNode
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

// class Program
// {lass Program
// {
// static TreeNode SortedArrayToBST(int[] nums)
// {
//     return Build(nums, 0, nums.Length - 1);
// }
//
// private static TreeNode Build(int[] nums, int left, int right)
// {
//     if (left > right) return null;
//     int mid = left + (right - left) / 2;
//     TreeNode root = new TreeNode(nums[mid]);
//     root.left = Build(nums, left, mid - 1);
//     root.right = Build(nums, mid + 1, right);
//     
//     return root;
// }

//     public class ListNode
//     {
//         public int val;
//         public ListNode next;
//
//         public ListNode(int val = 0, ListNode next = null)
//         {
//             this.val = val;
//             this.next = next;
//         }
//     }
//     
//     public static TreeNode SortedArrayToBST(ListNode head)
//     {
//         if (head == null) return null;
//         return BuildBST(head, null);
//     }
//
//     private static TreeNode BuildBST(ListNode left, ListNode right)
//     {
//         if (left == right) return null;
//         ListNode slow = left;
//         ListNode fast = left;
//
//         while (fast != right && fast.next != right)
//         {
//             slow = slow.next;
//             fast = fast.next.next;
//         }
//
//         TreeNode root = new TreeNode(slow.val);
//         root.left = BuildBST(left, slow);
//         root.right = BuildBST(slow.next, right);
//         
//         return root;
//         
//
//     }
//     static void BSTPrint(TreeNode root)
//     {
//         if (root == null) return; 
//         BSTPrint(root.left);
//         Console.Write(root.val + " ");
//         BSTPrint(root.right);
//     }
//     static void Main()
//     {
//         // int[] nums = {-10, -4, 0, 4, 9};
//         ListNode list = new ListNode(-10);
//         list.next = new ListNode(-3);
//         list.next.next = new ListNode(0);
//         list.next.next.next = new ListNode(5);
//         list.next.next.next.next = new ListNode(9);
//         var result = SortedArrayToBST(list);
//         BSTPrint(result);
//         // Console.WriteLine(SortedArrayToBST(nums));
//     }
// }

// class Program
// {
//     public static bool IsValidBST(TreeNode root)
//     {
//         return Validate(root, long.MinValue, long.MaxValue);
//     }
//
//     private static bool Validate(TreeNode node, long min, long max)
//     {
//         if (node == null) return true;
//
//         if (node.val <= min || node.val >= max) return false;
//         return Validate(node.left, min, node.val) && Validate(node.right, node.val, max);
//     }
//     static void Main()
//     {
//         TreeNode root = new TreeNode(2);
//         root.left = new TreeNode(1);
//         root.right = new TreeNode(3);
//         root.right.right = new TreeNode(-2);
//         Console.WriteLine(IsValidBST(root));
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         TreeNode root = new TreeNode(3);
//         root.left = new TreeNode(9);
//         root.left = new TreeNode(7);
//         
//
//         Console.WriteLine(IsBalanced(root));
//     }
//
//     public static bool IsBalanced(TreeNode root) => Check(root) != -1;
//
//     private static int Check(TreeNode node)
//     {
//         if (node == null) return 0;
//
//         int left = Check(node.left);
//         if (left == -1) return -1;
//
//         int right = Check(node.right);
//         if (right == -1) return -1;
//         if (Math.Abs(left - right) > 1) return -1;
//
//         return Math.Max(left, right) + 1;
//     }
// }


class Program
{
    public static TreeNode BalanceBST(TreeNode root)
    {
        List<int> nums = new List<int>();
        InOrder(root, nums);
        return Build(nums, 0, nums.Count - 1);
    }

    private static TreeNode Build(List<int> nums, int left, int right)
    {
        if (left > right) return null;

        int mid = left + (right - left) / 2;
        var node = new TreeNode(nums[mid]);
        node.left = Build(nums, left, mid - 1);
        node.right = Build(nums, mid + 1, right);

        return node;
    }
    private static void InOrder(TreeNode node, List<int> nums)
    {
        if (node == null) return;
        InOrder(node.left, nums);
        nums.Add(node.val);
        InOrder(node.right, nums);
    }
    
    static void Main()
    {
        TreeNode root = new TreeNode(1);
        root.right = new TreeNode(2);
        root.right.right = new TreeNode(3);
        root.right.right.right = new TreeNode(4);

        var result = BalanceBST(root);
        InOrder(result);
    }

    static void InOrder(TreeNode node)
    {
     
        if (node == null) return;
        InOrder(node.left);
        Console.Write(node.val + " ");
        InOrder(node.right);   
    }
}
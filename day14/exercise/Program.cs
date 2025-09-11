// class Program
// {
//   public static long Factorial(int n)
//   {
//     Console.WriteLine($"-> Factorial({n}) chaqirildi");

//     if (n < 0) throw new ArgumentException("n musbt be >= 0");

//     if (n == 0)
//     {
//       Console.WriteLine("  Base case: Factorial Factorial(0) = 1");
//       return 1;
//     }
//     long result = n * Factorial(n - 1);
//     Console.WriteLine($"<- Factorial({n}) tugadi, natija = {result}");
//     return result;
//   }

//   static void Main()
//   {
//     Console.WriteLine(Factorial(5));
//   }
// }

// public class Program
// {
//   public static long FactorialTail(int n) => FactorialTailHelper(n, 1);

//   private static long FactorialTailHelper(int n, long acc)
//   {
//     if (n < 0) throw new ArgumentException("n must be >= 0");
//     if (n == 0) return acc;
//     return FactorialTailHelper(n - 1, acc * n);
//   }
// }


// class Program
// {
//   public static long FibNaive(int n)
//   {
//     Console.WriteLine($"FibNaive({n}) chaqirildi");

//     if (n < 0) throw new ArgumentException("n must be >= 0");
//     if (n == 0) return 0;
//     if (n == 1) return 1;

//     long result = FibNaive(n - 1) + FibNaive(n - 2);

//     Console.WriteLine($"FibNaive({n}) tugadi, natija = {result}");
//     return result;
//   }
//   static void Main()
//   {
//     Console.WriteLine(FibNaive(8));
//   }
// }

// class Program
// {
//   public static long FibIter(int n)
//   {
//     if (n < 0) throw new ArgumentException("n must be >= 0");
//     if (n == 0) return 0;
//     if (n == 1) return 1;

//     long prev1 = 1;
//     long prev2 = 0;
//     long current = 0;

//     for (int i = 2; i <= n; i++)
//     {
//       current = prev1 + prev2;
//       prev2 = prev1;
//       prev1 = current;
//     }

//     return current;
//   }
//   static void Main()
//   {
//     Console.WriteLine(FibIter(8));
//   }
// }


// public class Program
// {
//   public static long FibMemo(int n)
//   {
//     if (n < 0) throw new ArgumentException("n >= 0 must be");

//     var memo = new Dictionary<int, long>() { { 0, 0 }, { 1, 1 } };
//     return FibMemoHelper(n, memo);
//   }

//   private static long FibMemoHelper(int n, Dictionary<int, long> memo)
//   {
//     if (memo.ContainsKey(n)) return memo[n];

//     long val = FibMemoHelper(n - 1, memo) + FibMemoHelper(n - 2, memo);
//     memo[n] = val;
//     return val;
//   }
//   static void Main()
//   {
//     Console.WriteLine(FibMemo(8));
//   }
// }

// public class Program
// {
//   public static long FibIter(int n)
//   {
//     if (n < 0) throw new ArgumentException("n >= must be");
//     if (n == 0) return 0;
//     if (n == 1) return 1;

//     long a = 0, b = 1;

//     for (int i = 2; i <= n; i++)
//     {
//       long tmp = a + b;
//       a = b;
//       b = tmp;
//     }
//     return b;
//   }

//   static void Main()
//   {
//     Console.WriteLine(FibIter(10));
//   }
// }


// class Program
// {
//   public static int SumArray(int[] a)
//   {
//     if (a == null) throw new ArgumentNullException(nameof(a));
//     return SumArrayFrom(a, 0);
//   }

//   private static int SumArrayFrom(int[] a, int idx)
//   {
//     if (idx >= a.Length) return 0;
//     return a[idx] + SumArrayFrom(a, idx + 1);
//   }

//   static void Main()
//   {
//     Console.WriteLine(SumArray(new int[] { 1, 2, 3, 4, 5, 6 }));
//   }
// }


// public class TreeNode
// {
//   public int val;
//   public TreeNode left;
//   public TreeNode right;
//   public TreeNode(int val = 0, TreeNode l = null, TreeNode r = null)
//   {
//     this.val = val;
//     this.left = l;
//     this.right = r;
//   }
// }

// public class Solution
// {
//   public static int MaxDepth(TreeNode root)
//   {
//     if (root == null) return -1;

//     var queue = new Queue<TreeNode>();
//     queue.Enqueue(root);
//     int depth = 0;

//     while (queue.Count > 0)
//     {
//       var levelSize = queue.Count;
//       for (int i = 0; i < levelSize; i++)
//       {
//         var node = queue.Dequeue();
//         if (node.left != null) queue.Enqueue(node.left);
//         if (node.right != null) queue.Enqueue(node.right);
//       }
//       depth++;
//     }
//     return depth;
//   }
//   // public static int MaxDepth(TreeNode root)
//   // {
//   //   if (root == null) return 0;
//   //   int left = MaxDepth(root.left);
//   //   int right = MaxDepth(root.right);
//   //   return Math.Max(left, right) + 1;
//   // }

//   static void Main()
//   {
//     var tree = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));
//     Console.WriteLine(MaxDepth(tree));
//   }
// }

public class TreeNode
{
  public int val;
  public TreeNode left;
  public TreeNode right;

  public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
  {
    this.val = val; this.left = left; this.right = right;
  }
}

// public class Solution
// {
//   // public static TreeNode InvertTree(TreeNode root)
//   // {
//   //   if (root == null) return null;

//   //   TreeNode temp = root.left;
//   //   root.left = root.right;
//   //   root.right = temp;

//   //   InvertTree(root.left);
//   //   InvertTree(root.right);

//   //   return root;
//   // }

//   public TreeNode InvertTree(TreeNode root)
//   {
//     if (root == null) return null;

//     var q = new Queue<TreeNode>();
//     q.Enqueue(root);

//     while (q.Count > 0)
//     {
//       TreeNode node = q.Dequeue();

//       TreeNode temp = node.left;
//       node.left = node.right;
//       node.right = temp;

//       if (node.left != null) q.Enqueue(node.left);
//       if (node.right != null) q.Enqueue(node.right);
//     }
//     return root;
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     var tree = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));
//   }
// }



// public class Solution
// {
//   public IList<int> InOrderTraversal(TreeNode root)
//   {
//     List<int> result = new List<int>();
//     Traverse(root, result);
//     return result;
//   }

//   private static void Traverse(TreeNode root, List<int> result)
//   {
//     if (root == null) return;

//     Traverse(root.left, result);
//     result.Add(root.val);
//     Traverse(root.right, result);
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     var root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));

//     var current = root;
//     while (current != null)
//     {
//       Console.WriteLine(current.val);
//       current = current.left;
//     }

//   }

// }

// public class Solution
// {
//   private Dictionary<int, int> memo = new Dictionary<int, int>();

//   public int ClimbStairs(int n)
//   {
//     if (n <= 2) return n;
//     if (memo.ContainsKey(n)) return memo[n];

//     int result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
//     memo[n] = result;

//     return result;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var sol = new Solution();
//     Console.WriteLine(sol.ClimbStairs(19));
//   }
// }

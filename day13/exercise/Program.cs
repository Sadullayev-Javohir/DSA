// public class TreeNode
// {
//   public int val;
//   public TreeNode left;
//   public TreeNode right;
//   public TreeNode(int v = 0, TreeNode l = null, TreeNode r = null)
//   {
//     val = v; left = l; right = r;
//   }
// }

// public static class TreeUtils
// {
//   public static IList<IList<int>> LevelOrder(TreeNode root)
//   {
//     var res = new List<IList<int>>();
//     if (root == null) return res;

//     var q = new Queue<TreeNode>();
//     q.Enqueue(root);

//     while (q.Count > 0)
//     {
//       int levelSize = q.Count;
//       var levelList = new List<int>(levelSize);

//       for (int i = 0; i < levelSize; i++)
//       {
//         var node = q.Dequeue();
//         levelList.Add(node.val);
//         if (node.left != null) q.Enqueue(node.left);
//         if (node.right != null) q.Enqueue(node.right);
//       }
//       res.Add(levelList);
//     }
//     return res;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, null, new TreeNode(6)));

//     var levels = TreeUtils.LevelOrder(root);

//     int levelNum = 1;
//     foreach (var level in levels)
//     {
//       Console.WriteLine("Level " + levelNum + ": ");
//       Console.WriteLine(string.Join(", ", level));
//       levelNum++;
//     }
//   }
// }


// public class TreeNode
// {
//   public int val;
//   public TreeNode right;
//   public TreeNode left;

//   public TreeNode(int v = 0, TreeNode r = null, TreeNode l = null)
//   {
//     val = v; right = r; left = l;
//   }
// }

// public class TreeUtils
// {
//   public static IList<IList<int>> LevelOrder(TreeNode root)
//   {
//     var res = new List<IList<int>>();
//     if (root == null) return res;

//     var q = new Queue<TreeNode>();
//     q.Enqueue(root);

//     while (q.Count > 0)
//     {
//       var levelSize = q.Count;
//       var levelList = new List<int>(levelSize);
//       for (int i = 0; i < levelSize; i++)
//       {
//         var node = q.Dequeue();
//         levelList.Add(node.val);
//         if (node.left != null) q.Enqueue(node.left);
//         if (node.right != null) q.Enqueue(node.right);
//       }
//       res.Add(levelList);
//     }
//     return res;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     TreeNode root = new TreeNode(1,
//     new TreeNode(2, new TreeNode(4), new TreeNode(5)),
//     new TreeNode(3, new TreeNode(6)));

//     var nodes = TreeUtils.LevelOrder(root);
//     int levelNum = 1;
//     foreach (var node in nodes)
//     {
//       Console.Write("Level " + levelNum + " ");
//       Console.WriteLine(string.Join(", ", node));
//       levelNum++;
//     }
//   }
// }

// public class CircularDeque<T>
// {
//   private T[] data;
//   private int head;
//   private int tail;
//   private int count;

//   public CircularDeque(int capacity = 4)
//   {
//     data = new T[capacity];
//     head = 0; tail = 0; count = 0;
//   }

//   public int Count => count;
//   public bool IsEmpty => count == 0;

//   public void PushBack(T val)
//   {
//     EnsureCapacity(count + 1);
//     data[tail] = val;
//     tail = (tail + 1) % data.Length;
//     count++;
//   }

//   public void PushFront(T val)
//   {
//     EnsureCapacity(count + 1);
//     head = (head - 1 + data.Length) % data.Length;
//     data[head] = val;
//     count++;
//   }

//   public T PopFront()
//   {
//     if (count == 0) throw new InvalidOperationException("Deque is IsEmpty");
//     var v = data[head];
//     data[head] = default(T);
//     head = (head + 1) % data.Length;
//     count--;
//     return v;
//   }

//   public T PopBack()
//   {
//     if (IsEmpty) throw new InvalidOperationException("Deque is empty");
//     tail = (tail - 1 + data.Length) % data.Length;
//     var v = data[tail];
//     data[tail] = default(T);
//     count--;
//     return v;
//   }

//   public T PeekFront()
//   {
//     if (IsEmpty) throw new InvalidOperationException("Deque is empty");
//     return data[head];
//   }

//   public T PeekBack()
//   {
//     if (IsEmpty) throw new InvalidOperationException("Deque is empty");
//     int idx = (tail - 1 + data.Length) % data.Length;
//     return data[idx];
//   }

//   private void EnsureCapacity(int minCapacity)
//   {
//     if (data.Length >= minCapacity) return;
//     int newCap = Math.Max(minCapacity, data.Length * 2);
//     var newArr = new T[newCap];

//     for (int i = 0; i < count; i++)
//     {
//       newArr[i] = data[(head + i) % data.Length];
//     }

//     data = newArr;
//     head = 0;
//     tail = count % data.Length;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var dq = new CircularDeque<int>();
//     dq.PushBack(1);
//     dq.PushBack(2);
//     dq.PushBack(3);
//     Console.WriteLine(dq.PeekFront());
//   }
// }

// public class TreeNode
// {
//   public int val;
//   public TreeNode right;
//   public TreeNode left;
//   public TreeNode(int v = 0, TreeNode r = null, TreeNode l = null)
//   {
//     val = v; right = r; left = l;
//   }
// }

// public static class TreeUtils
// {
//   public static IList<IList<int>> LevelOrder(TreeNode root)
//   {
//     var res = new List<IList<int>>();
//     if (root == null) return res;

//     var q = new Queue<TreeNode>();
//     q.Enqueue(root);

//     while (q.Count > 0)
//     {
//       var levelSize = q.Count;
//       var levelList = new List<int>(levelSize);

//       for (int i = 0; i < levelSize; i++)
//       {
//         var node = q.Dequeue();
//         levelList.Add(node.val);
//         if (node.left != null) q.Enqueue(node.left);
//         if (node.right != null) q.Enqueue(node.right);
//       }
//       res.Add(levelList);
//     }
//     return res;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));
//     var levels = TreeUtils.LevelOrder(root);
//     for (int i = 0; i < levels.Count; i++)
//     {
//       Console.WriteLine("Level " + (i + 1) + ": ");
//       foreach (var val in levels[i])
//       {
//         Console.WriteLine(val + " ");
//       }
//       Console.WriteLine();
//     }
//   }
// }


public class MyCircularDeque
{
  private int[] data;
  private int front;
  private int rear;
  private int count;
  private int capacity;

  public MyCircularDeque(int k)
  {
    data = new int[k];
    capacity = k;
    front = 0;
    rear = -1;
    count = 0;
  }

  public bool InsertFront(int value)
  {
    if (IsFull()) return false;
    front = (front - 1 + capacity) % capacity;
    data[front] = value;
    count++;
    if (count == 1) rear = front;
    return true;
  }

  public bool InsertLast(int value)
  {
    if (IsFull()) return false;
    rear = (rear + 1) % capacity;
    data[rear] = value;
    count++;
    if (count == 1) rear = front;
    return true;
  }

  public bool DeleteFront()
  {
    if (IsEmpty()) return false;
    front = (front + 1) % capacity;
    count--;
    return true;
  }

  public bool DeleteLast()
  {
    if (IsEmpty()) return false;
    rear = (rear - 1 + capacity) % capacity;
    count--;
    return true;
  }

  public int GetFront()
  {
    if (IsEmpty()) return -1;
    return data[front];
  }

  public int GetRear()
  {
    if (IsEmpty()) return -1;
    return data[rear];
  }

  public bool IsEmpty() => count == 0;
  public bool IsFull() => count == capacity;
}

// class Program
// {
//   static void Main()
//   {
//     var deque = new MyCircularDeque(4);
//     deque.InsertFront(1);
//     deque.InsertFront(2);
//     deque.InsertFront(3);
//     deque.InsertFront(4);
//     while (deque.IsEmpty())
//     {
//       Console.WriteLine(deque.DeleteFront());
//     }
//   }
// }

// 933

// public class RecentCounter
// {
//   private Queue<int> q;

//   public RecentCounter()
//   {
//     q = new Queue<int>();
//   }

//   public int Ping(int t)
//   {
//     q.Enqueue(t);
//     while (q.Count > 0 && q.Peek() < t - 3000)
//     {
//       q.Dequeue();
//     }
//     return q.Count;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     RecentCounter recentCounter = new RecentCounter();

//     Console.WriteLine(recentCounter.Ping(1));
//     Console.WriteLine(recentCounter.Ping(100));
//     Console.WriteLine(recentCounter.Ping(3001));
//     Console.WriteLine(recentCounter.Ping(3002));
//     Console.WriteLine(recentCounter.Ping(30037));
//     Console.WriteLine();
//   }
// }

// 346

// public class MovingAverage
// {
//   private Queue<int> q;
//   private int size;
//   private double sum;

//   public MovingAverage(int k)
//   {
//     q = new Queue<int>();
//     size = k;
//     sum = 0;
//   }

//   public double Next(int val)
//   {
//     q.Enqueue(val);
//     sum += val;

//     if (q.Count > size) sum -= q.Dequeue();
//     return sum / q.Count;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var moving = new MovingAverage(4);
//     Console.WriteLine(moving.Next(1));
//     Console.WriteLine(moving.Next(2));
//     Console.WriteLine(moving.Next(3));
//   }
// }


// public class Solution
// {
//   public int[] MaximumSlidingWindow(int[] nums, int k)
//   {
//     var deque = new LinkedList<int>();
//     var result = new List<int>();

//     for (int i = 0; i < nums.Length; i++)
//     {
//       if (deque.Count > 0 && deque.First.Value <= i - k) deque.RemoveFirst();

//       while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i]) deque.RemoveLast();

//       deque.AddLast(i);

//       if (i >= k - 1) result.Add(nums[deque.First.Value]);
//     }
//     return result.ToArray();
//   }
// }

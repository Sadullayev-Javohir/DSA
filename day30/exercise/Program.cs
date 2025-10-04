// class Program
// {
//   static int InterpolationSearch(int[] arr, int key)
//   {
//     int n = arr.Length;
//     if (n == 0) return -1;
//     if (n == 1 && arr[0] == key) return 0;

//     int low = 0, high = n - 1;

//     while (arr[low] <= key && key <= arr[high])
//     {
//       int pos = low + ((key - arr[low]) * (high - low)) / (arr[high] - arr[low]);

//       if (arr[pos] == key) return pos;
//       if (arr[pos] < key) low = pos + 1;
//       else high = pos - 1;
//     }
//     return -1;
//   }
//   static void Main()
//   {

//     int[] arr = {2};
//     Console.WriteLine(InterpolationSearch(arr, 1));
//   }
// }

// class Program
// {
//   static int JumpSearch(int[] arr, int key)
//   {
//     int n = arr.Length;
//     if (n == 0) return -1;

//     int step = (int)Math.Floor(Math.Sqrt(n));
//     int prev = 0;

//     while (prev < n && arr[Math.Min(step, n) - 1] < key)
//     {
//       prev = step;
//       step += (int)Math.Floor(Math.Sqrt(n));
//       if (prev >= n) return -1;
//     }

//     int end = (int)Math.Min(step, n);

//     for (int i = prev; i < end; i++)
//     {
//       if (arr[i] == key) return i;
//     }
//     return -1;
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4 };
//     Console.WriteLine(JumpSearch(arr, 2));
//   }
// }


// <summary>
// Zanjirli (chaining) usulda ishlovchi oddiy HashMap
// Ko'p oqimli (thread-safe) emas.
// Null kalitlarga ruxsat bermaydi (agar null yuborilsa ArgumentNullException tashlaydi)
// <summary>

public class MyHashMap<K, V>
{
  public class Node
  {
    public K Key;
    public V Value;

    public Node(K key, V value) { Key = key; Value = value; }
  }

  private LinkedList<Node>[] buckets;
  private int count;
  private const double LOAD_FACTOR = 0.75;

  public MyHashMap(int initialCapacity = 16)
  {
    if (initialCapacity <= 0) throw new ArgumentException("initialCapacity must be > 0");
    buckets = new LinkedList<Node>[initialCapacity];
    count = 0;
  }

  private int BucketIndex(K key)
  {
    int hash = key.GetHashCode() & 0x7fffffff;
    return hash % buckets.Length;
  }

  public int Count => count;

  public bool ContainsKey(K key)
  {
    if (key == null) throw new ArgumentNullException(nameof(key));
    int idx = BucketIndex(key);
    var list = buckets[idx];
    if (list == null) return false;
    foreach (var node in list)
    {
      if (EqualityComparer<K>.Default.Equals(node.Key, key)) return true;
    }
    return false;
  }

  public void Put(K key, V value)
  {
    if (key == null) throw new ArgumentNullException(nameof(key));

    int idx = BucketIndex(key);
    if (buckets[idx] == null) buckets[idx] = new LinkedList<Node>();

    var list = buckets[idx];

    for (var node = list.First; node != null; node = node.Next)
    {
      if (EqualityComparer<K>.Default.Equals(node.Value.Key, key))
      {
        node.Value.Value = value;
        return;
      }
    }
    list.AddFirst(new Node(key, value));
  }


  private void EnsureCapacityForAddition()
  {
    double currentLoad = (double)(count + 1) / buckets.Length;
    if (currentLoad <= LOAD_FACTOR) return;

    int newCapacity = buckets.Length * 2;
    var newbuckets = new LinkedList<Node>[newCapacity];

    foreach (var oldlist in buckets)
    {
      if (oldlist == null) continue;
      foreach (var node in oldlist)
      {
        int hash = node.Key.GetHashCode() & 0x7fffffff;
        int idx = hash % newCapacity;
        if (newbuckets[idx] == null) newbuckets[idx] = new LinkedList<Node>();
        newbuckets[idx].AddFirst(new Node(node.Key, node.Value));
      }
    }

    buckets = newbuckets;
  }
}

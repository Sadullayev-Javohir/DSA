// public class MyHashMap<K, V>
// {
//   public class Node
//   {
//     public K Key;
//     public V Value;

//     public Node(K Key, V Value)
//     {
//       this.Key = Key;
//       this.Value = Value;
//     }
//   }

//   private LinkedList<Node>[] buckets;
//   private int count;
//   private const double LOAD_FACTOR = 0.75;

//   public MyHashMap(int initialCapacity = 16)
//   {
//     if (initialCapacity <= 0) throw new ArgumentException("initialCapacity must be > 0");

//     buckets = new LinkedList<Node>[initialCapacity];
//     count = 0;
//   }

//   public int BucketIndex(K key)
//   {
//     if (key == null) throw new ArgumentNullException(nameof(key));

//     int hash = key.GetHashCode() & 0x7fffffff;
//     return hash % buckets.Length;
//   }

//   public bool ContainsKey(K key)
//   {
//     if (key == null) throw new ArgumentNullException(nameof(key));

//     int idx = BucketIndex(key);

//     if (buckets[idx] == null) return false;
//     var list = buckets[idx];
//     foreach (var node in list)
//     {
//       if (EqualityComparer<K>.Default.Equals(node.Key, key)) return true;
//     }
//     return false;
//   }

//   public void Put(K key, V value)
//   {
//     if (key == null) throw new ArgumentNullException(nameof(key));

//     int idx = BucketIndex(key);

//     if (buckets[idx] == null) buckets[idx] = new LinkedList<Node>();

//     var list = buckets[idx];
//     foreach (var node in list)
//     {
//       if (EqualityComparer<K>.Default.Equals(node.Key, key)) node.Value = value;
//     }

//     list.AddFirst(new Node(key, value));
//     count++;
//   }

//   public void EnsureCapacityForAddition()
//   {
//     double currentLoad = (double)(count + 1) / buckets.Length;

//     if (currentLoad <= LOAD_FACTOR) return;

//     int newCapacity = buckets.Length * 2;
//     var newBuckets = new LinkedList<Node>[newCapacity];
//     foreach (var oldlist in buckets)
//     {
//       if (oldlist == null) continue;
//       foreach (var node in oldlist)
//       {
//         int hash = node.Key.GetHashCode() & 0x7fffffff;
//         int idx = hash % newCapacity;

//         if (newBuckets[idx] == null) newBuckets[idx] = new LinkedList<Node>();
//         newBuckets[idx].AddFirst(new Node(node.Key, node.Value));
//       }
//     }

//     buckets = newBuckets;
//   }

//   public bool TryGet(K key, out V value)
//   {
//     if (key == null) throw new ArgumentNullException(nameof(key));

//     int idx = BucketIndex(key);

//     var list = buckets[idx];
//     if (list == null)
//     {
//       value = default(V);
//       return false;
//     }

//     foreach (var node in list)
//     {
//       if (EqualityComparer<K>.Default.Equals(node.Key, key))
//       {
//         value = node.Value;
//         return true;
//       }
//     }

//     value = default(V);
//     return false;
//   }

//   public V Get(K key)
//   {
//     if (TryGet(key, out V val)) return val;
//     throw new KeyNotFoundException("Key not found");
//   }

//   public bool Remove(K key)
//   {
//     if (key == null) throw new ArgumentNullException(nameof(key));

//     int idx = BucketIndex(key);
//     var list = buckets[idx];
//     if (list == null) return false;

//     for (var node = list.First; node != null; node = node.Next)
//     {
//       if (EqualityComparer<K>.Default.Equals(node.Value.Key, key))
//       {
//         list.Remove(node);
//         count--;
//         return true;
//       }
//     }
//     return false;
//   }

//   public IEnumerable<K> Keys()
//   {
//     foreach (var list in buckets)
//     {
//       if (list == null) continue;
//       foreach (var node in list) yield return node.Key;
//     }
//   }

// }
// class Program
// {
//   static void Main()
//   {
//     MyHashMap<string, int> map = new MyHashMap<string, int>();

//     map.Put("Olma", 10);
//     map.Put("Banan", 5);
//   }
// }









public class MyHashMap<K, V>
{
  public class Node
  {
    public K Key;
    public V Value;

    public Node(K Key, V Value)
    {
      this.Key = Key;
      this.Value = Value;
    }
  }

  private LinkedList<Node>[] buckets;
  private int count;
  const double LOAD_FACTOR = 0.75;

  public MyHashMap(int initialCapacity = 16)
  {
    if (initialCapacity <= 0) throw new ArgumentException("must be initialCapacity > 0");
    buckets = new LinkedList<Node>[initialCapacity];
    count = 0;
  }

  private int BucketIndex(K key)
  {
    int hash = key.GetHashCode() & 0x7fffffff;
    return hash % buckets.Length;
  }

  public bool ContainsKey(K key)
  {
    if (key == null) throw new ArgumentNullException(nameof(key));
    int idx = BucketIndex(key);
    if (buckets[idx] == null) return false;
    var list = buckets[idx];

    foreach (var node in list)
    {
      if (EqualityComparer<K>.Default.Equals(node.Key, key)) return true;
    }

    return false;
  }

  public void Put(K key, V value)
  {
    if (key == null) throw new ArgumentNullException(nameof(key));
    EnsureCapacityForAddition();

    int idx = BucketIndex(key);
    if (buckets[idx] == null) buckets[idx] = new LinkedList<Node>();
    var list = buckets[idx];
    foreach (var node in list)
    {
      if (EqualityComparer<K>.Default.Equals(node.Key, key))
      {
        node.Value = value;
      }
    }

    list.AddFirst(new Node(key, value));
    count++;
  }

  public bool TryGet(K key, out V value)
  {
    if (key == null) throw new ArgumentNullException(nameof(key));
    int idx = BucketIndex(key);
    var list = buckets[idx];

    if (list == null)
    {
      value = default(V);
      return false;
    }

    foreach (var node in list)
    {
      if (EqualityComparer<K>.Default.Equals(node.Key, key))
      {
        value = node.Value;
        return true;
      }
    }

    value = default(V);
    return false;
  }

  public V Get(K key)
  {
    if (TryGet(key, out V val)) return val;
    throw new KeyNotFoundException("Key not found");
  }

  public bool Remove(K key)
  {
    if (key == null) throw new ArgumentNullException(nameof(key));
    int idx = BucketIndex(key);
    if (buckets[idx] == null) return false;
    var list = buckets[idx];

    for (var node = list.First; node != null; node = node.Next)
    {
      if (EqualityComparer<K>.Default.Equals(node.Value.Key, key))
      {
        list.Remove(node);
        count--;
        return true;
      }
    }

    return false;
  }

  public void EnsureCapacityForAddition()
  {
    double currentLoad = (double)(count + 1) / buckets.Length;
    if (currentLoad <= LOAD_FACTOR) return;

    int newCapacity = buckets.Length * 2;
    var newBuckets = new LinkedList<Node>[newCapacity];

    foreach (var list in buckets)
    {
      if (list == null) continue;

      foreach (var node in list)
      {
        int hash = node.Key.GetHashCode() & 0x7fffffff;
        int idx = hash & newCapacity;
        if (newBuckets[idx] == null) newBuckets[idx] = new LinkedList<Node>();
        newBuckets[idx].AddFirst(new Node(node.Key, node.Value));
      }
    }

    buckets = newBuckets;
  }

  public IEnumerable<K> Keys()
  {
    foreach (var list in buckets)
    {
      if (list == null) continue;

      foreach (var node in list) yield return node.Key;
    }
  }
}

class Program
{
  static void Main()
  {
    var map = new MyHashMap<string, int>();
    map.Put("a", 1);
    map.Put("b", 2);
    map.Put("c", 3);
    map.Put("d", 4);

    map.Remove("c");
    Console.WriteLine(map.Get("b"));
    if (map.TryGet("a", out int value)) Console.WriteLine($"Found Value = {value}");
    else Console.WriteLine("Not found");

    foreach (var key in map.Keys()) Console.WriteLine(key);
  }
}

// class Program
// {
//   public static int SimpleHash(string key, int bucketSize)
//   {
//     int hash = 0;

//     foreach(char c in key)
//     {
//       hash += c;
//     }
//     return hash % bucketSize;
//   }

//   public static int BetterHash(string key, int bucketSize)
//   {
//     int hash = 17;
//     foreach(char c in key)
//     {
//       hash = hash * 31 + c;
//     }
//     return Math.Abs(hash) % bucketSize;
//   }

//   static void Main()
//   {
//     int bucketSize = 15;
//     string[] keys = {"cat", "dog", "apple", "user:101"};
//     foreach(var key in keys)
//     {
//       int index = BetterHash(key, bucketSize);
//       Console.WriteLine($"{key} => bucket {index}");
//     }

//   }
// }

// using System.Security.Cryptography.X509Certificates;

// using System.Collections;
// using System.Diagnostics.Tracing;

// public class HashTableChaining<TKey, TValue>
// {
//   private LinkedList<Entry>[]? _buckets;
//   private int _count;

//   private sealed class Entry
//   {
//     public TKey? Key {get;}
//     public TValue? Value {get; set;}

//     public Entry(TKey key, TValue value)
//     {
//       Key = key;
//       Value = value;
//     }

//     public override string ToString() => $"{Key}: {Value}";
//   }

//   public HashTableChaining(int capacity = 16)
//   {
//     if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity));
//     _buckets = new LinkedList<Entry>[capacity];
//   }

//   public int Count => _count;
//   public int capacity => _buckets!.Length;

//   public int GetBucketIndex(TKey key)
//   {
//     if (key == null) throw new ArgumentNullException(nameof(key));

//     int hash = key.GetHashCode() & 0x7fffffff;
//     return hash % _buckets!.Length;
//   }

//   public void Put(TKey key, TValue value)
//   {
//     int index = GetBucketIndex(key);

//     _buckets![index] ??= new LinkedList<Entry>();

//     foreach(var entry in _buckets[index])
//     {
//       if (EqualityComparer<TKey>.Default.Equals(entry.Key, key))
//       {
//         entry.Value = value;
//         return;
//       }
//     }

//     _buckets[index].AddLast(new Entry(key, value));
//     _count++;
//   }

//   public TValue Get(TKey key)
//   {
//     if (TryGet(key, out var value)) return value;
//     throw new KeyNotFoundException($"Key not found: {key}");
//   }

//   public bool TryGet(TKey key, out TValue value)
//   {
//     int index = GetBucketIndex(key);
//     var list = _buckets![index];

//     if (list != null)
//     {
//       foreach(var entry in list)
//       {
//         if (EqualityComparer<TKey>.Default.Equals(entry.Key, key))
//         {
//           value = entry.Value;
//           return true;
//         }
//       }
//     }
//     value = default!;
//     return false;
//   }

//   public bool ContainsKey(TKey key) => TryGet(key, out _);

//   public bool Remove(TKey key)
//   {
//     int index = GetBucketIndex(key);
//     var list = _buckets![index];

//     if (list == null) return false;

//     var node = list.First;
//     while (node != null)
//     {
//       if (EqualityComparer<TKey>.Default.Equals(node.Value.Key, key))
//       {
//         list.Remove(node);
//         _count--;

//         if (list.Count == 0) _buckets![index] = null!;
//         return true;
//       }
//       node = node.Next;
//     }
//     return false;
//   }

//   public void PrintBuckets()
//   {
//     for (int i = 0; i < _buckets!.Length; i++)
//     {
//       Console.WriteLine($"Index: {i}: ");

//       var list = _buckets[i];
//       if (list == null || list.Count == 0)
//       {
//         Console.WriteLine("[]");
//         continue;
//       }

//       var node = list.First;
//       while (node != null)
//       {
//         Console.WriteLine($"[{node.Value.Key}]");
//         node = node.Next;
//         if (node != null) Console.Write(" -> ");
//       }
//       Console.WriteLine();
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var ht = new HashTableChaining<string, int>(capacity: 5);

//     ht.Put("cat", 1);
//     ht.Put("act", 2);
//     ht.Put("tac", 3);

//     ht.Put("apple", 1200);
//     ht.Put("user:101", 999);

//     Console.WriteLine("========== BUCKETS =========");
//     ht.PrintBuckets();
//   }
// }

using System.Xml;

public class HashTableChaining<TKey, TValue>
{
  private LinkedList<Entry>[]? _buckets;
  private int _count;

  private sealed class Entry
  {
    public TKey? Key {get;}
    public TValue? Value {get;set;}

    public Entry(TKey key, TValue value)
    {
      Key = key;
      Value = value;
    }

    public override string ToString() => $"{Key}: {Value}";
  }

  public HashTableChaining(int capacity = 16)
  {
    if (capacity <= 0) throw new ArgumentOutOfRangeException(nameof(capacity));
    _buckets = new LinkedList<Entry>[capacity];
  }

  public int Count => _count;
  public int Capacity => _buckets!.Length;

  private int GetBucketIndex(TKey key)
  {
    if (key == null) throw new ArgumentNullException(nameof(key));

    int hash = key.GetHashCode() & 0x7fffffff;
    return hash % _buckets!.Length;
  }

  public void Put(TKey key, TValue value)
  {
    int index = GetBucketIndex(key);
    _buckets![index] ??= new LinkedList<Entry>();

    foreach(var entry in _buckets![index])
    {
      if (EqualityComparer<TKey>.Default.Equals(entry.Key, key))
      {
        entry.Value = value;
        return;
      }
    }

    _buckets![index].AddLast(new Entry(key, value));
    _count++;
  }

  public TValue Get(TKey key)
  {
    if (TryGet(key, out var value))
    {
      return value;
    }
    throw new KeyNotFoundException($"Key not found: {key}");
  }

  public bool TryGet(TKey key, out TValue value)
  {
    int index = GetBucketIndex(key);
    var list = _buckets![index];

    if (list != null)
    {
      foreach(var entry in list)
      {
        if (EqualityComparer<TKey>.Default.Equals(entry.Key, key))
        {
          value = entry.Value!;
          return true;
        }
      }
    }
    value = default!;
    return false;
  }

  public bool ContainsKey(TKey key) => TryGet(key, out _);

  public bool Remove(TKey key)
  {
    int index = GetBucketIndex(key);
    var list = _buckets![index];

    if (list == null) return false;

    var node = list.First;

    while (node != null)
    {
      if (EqualityComparer<TKey>.Default.Equals(node.Value.Key, key))
      {
        list.Remove(node);
        _count--;

        if (list.Count == 0) _buckets[index] = null!;
        return true;
      }
      node = node.Next;
    }
    return false;
  }

  public void PrintBuckets()
  {
    for (int i = 0; i < _buckets!.Length; i++)
    {
      Console.WriteLine($"Index {i}: ");

      var list = _buckets[i];

      if (list == null || list.Count == 0)
      {
        Console.WriteLine("[]");
        continue;
      }
      var node = list.First;

      while (node != null)
      {
        Console.Write($"[{node.Value.Key}]");
        node = node.Next;
        if (node != null) Console.Write(" -> ");
      }

      Console.WriteLine();
    }
  }
}

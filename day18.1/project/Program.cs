// using System.Xml;

// public sealed class LinkedListDictionary<TKey, TValue>
// {
//   private Node?[]? _buckets;
//   private int _count;
//   private readonly IEqualityComparer<TKey>? _cmp;

//   private sealed class Node
//   {
//     public readonly TKey? Key;
//     public TValue? Value;
//     public Node? Next;

//     public Node(TKey key, TValue value, Node? next)
//     {
//       Key = key;
//       Value = value;
//       Next = next;
//     }
//   }

//   public LinkedListDictionary(int capacity = 16, IEqualityComparer<TKey>? comparer = null)
//   {
//     if (capacity < 1) capacity = 1;
//     _buckets = new Node[capacity];
//     _cmp = comparer ?? EqualityComparer<TKey>.Default;
//   }

//   public int Count => _count;
//   public int Capacity => _buckets!.Length;

//   public double LoadFactor => (double)_count / _buckets!.Length;

//   public void Add(TKey key, TValue value)
//   {
//     if (key is null) throw new ArgumentNullException(nameof(key));

//     if (_count >= _buckets!.Length * 0.75) Resize(_buckets.Length * 2);

//     int idx = BucketIndex(key);

//     for (Node? n = _buckets[idx]; n != null; n = n.Next)
//     {
//       if (_cmp!.Equals(n.Key, key)) throw new ArgumentException("An item with the same key already exist");
//     }

//     _buckets[idx] = new Node(key, value, _buckets[idx]);
//     _count++;
//   }

//   private int BucketIndex(TKey key)
//   {
//     int h = _cmp!.GetHashCode(key!) & 0x7fffffff;
//     return h % _buckets!.Length;
//   }

//   private void Resize(int newSize)
//   {
//     var newBuckets = new Node[newSize];

//     for(int  i= 0; i < _buckets!.Length; i++)
//     {
//       Node? n = _buckets[i];
//       while (n != null)
//       {
//         Node? next= n.Next;

//         int h = _cmp!.GetHashCode(n.Key!) & 0x7fffffff;
//         int idx = h % newSize;

//         n.Next = newBuckets[idx];
//         newBuckets[idx] = n;

//         n = next;
//       }
//     }

//     _buckets = newBuckets;
//   }
// }
//

// using System.Transactions;

// public sealed class SimpleLinkedListDictionary
// {
//   private Node?[]? buckets;
//   private int count;

//   private sealed class Node
//   {
//     public string? Key;
//     public int Value;
//     public Node? Next;

//     public Node(string key, int value, Node? next)
//     {
//       Next = next;
//       Value =value;
//       Key = key;
//     }
//   }

//   public SimpleLinkedListDictionary(int capacity = 8)
//   {
//     if (capacity < 1) capacity = 1;
//     buckets = new Node[capacity];
//     count = 0;
//   }

//   public int Count => count;

//   private int BucketIndex(string key)
//   {
//     int h = key.GetHashCode();
//     if (h < 0) h = -h;
//     return h % buckets!.Length;
//   }

//   public void Add(string key, int value)
//   {
//     if (key is null) throw new ArgumentNullException(nameof(key));

//     int idx = BucketIndex(key);

//     for (Node? n = buckets![idx]; n != null; n = n.Next)
//     {
//       if (n.Key == key) throw new ArgumentException("Key already exists");
//     }

//     buckets[idx] = new Node(key, value, buckets[idx]);
//     count++;
//   }

//   public bool TryGet(string key, out int value)
//   {
//     if (key is null) throw new ArgumentNullException(nameof(key));

//     int idx = BucketIndex(key);

//     for (Node? n = buckets![idx]; n != null; n = n.Next)
//     {
//       if (n.Key == key)
//       {
//         value = n.Value;
//         return true;
//       }
//     }

//     value = 0;
//     return false;
//   }

//   public bool Remove(string key)
//   {
//     if (key == null) throw new ArgumentNullException(nameof(key));

//     int idx = BucketIndex(key);

//     Node? prev = null;
//     Node? cur = buckets![idx];

//     while (cur != null)
//     {
//       if (cur.Key == key)
//       {
//         if (prev == null) buckets[idx] = cur.Next;
//         else prev.Next = cur.Next;

//         count--;
//         return true;
//       }
//       prev = cur;
//       cur = cur.Next;
//     }
//     return false;
//   }

//   public void Print()
//   {
//     Console.WriteLine("=====Dictionary=====");

//     for (int i = 0; i < buckets!.Length; i++)
//     {
//       Console.WriteLine($"Buckets {i}: ");
//       Node? curr = buckets[i];

//       if (curr == null)
//       {
//         Console.WriteLine("empty");
//         continue;
//       }

//       while (curr != null)
//       {
//         Console.Write($"[{curr.Key}:{curr.Value}] => ");
//         curr = curr.Next;
//       }
//       Console.WriteLine("null");
//     }

//     Console.WriteLine("==========");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var dict = new SimpleLinkedListDictionary();
//     dict.Add("act", 1);
//     dict.Add("get", 10);
//     dict.Add("sure", 11);
//     dict.Add("cat", 3);
//     dict.Print();
//   }
// }


class SimpleLinkedListDictionary
{
  public SimpleLinkedListDictionary(int capacity = 8)
  {
    if (capacity < 1) capacity = 1;

    buckets = new Node[capacity];
  }

  private Node?[] buckets;
  private int count;

  public sealed class Node
  {
    public string? Key;
    public int Value;
    public Node? Next;

    public Node(string key, int value, Node? next)
    {
      Key = key;
      Value = value;
      Next = next;
    }
  }



  public int Count => count;

  private int BucketIndex(string key)
  {
    int h = key.GetHashCode();
    if (h < 0) h = -h;
    return h % buckets.Length;
  }

  public void Add(string key, int value)
  {
    if (key is null) throw new ArgumentNullException(nameof(key));

    int idx = BucketIndex(key);

    for (var n = buckets[idx]; n != null; n = n.Next)
    {
      if (n.Key == key) throw new ArgumentException("key already exists");
    }

    buckets[idx] = new Node(key, value, buckets[idx]);
    count++;
  }

  public bool TryGet(string key, out int value)
  {
    if (key is null) throw new ArgumentNullException(nameof(key));

    int idx = BucketIndex(key);

    for (var n = buckets[idx]; n != null; n = n.Next)
    {
      if (n.Key == key)
      {
        value = n.Value;
        return true;
      }
    }
    value = 0;
    return false;
  }

  public bool Remove(string key)
  {
    if (key is null) throw new ArgumentNullException(nameof(key));

    int idx = BucketIndex(key);
    Node? prev = null;
    Node? curr = buckets[idx];

    while (curr != null)
    {
      if (curr.Key == key)
      {
        if (prev == null) buckets[idx] = curr.Next;
        else prev.Next = curr.Next;

        count--;
        return true;
      }
      prev = curr;
      curr = curr.Next;
    }
    return false;
  }

  public void Print()
  {
    for (int i = 0; i < buckets.Length; i++)
    {
      Console.WriteLine($"Buckets {i}: ");
      Node? curr = buckets[i];

      if (curr == null)
      {
        Console.WriteLine("Empty");
        continue;
      }
      while (curr != null)
      {
        Console.Write($"[{curr.Key}: {curr.Value}] =>");
        curr = curr.Next;
      }
      Console.WriteLine("null");
    }
  }
}

class Program
{
  static void Main()
  {
    var dict = new SimpleLinkedListDictionary();
    dict.Add("one", 1);
    dict.Add("neo", 2);
    dict.Add("three", 3);
    dict.Add("four", 4);
    Console.WriteLine(dict.Remove("four"));
    Console.WriteLine(dict.TryGet("four", out var v));
    dict.Print();
  }
}

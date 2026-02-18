//class HashTable
//{
//    private Node[]? _data;
//    private int _count;

//    public sealed class Node
//    {
//        public string? Key;
//        public int Value;
//        public Node? Next;

//        public Node ( string key, int value, Node? next )
//        {
//            Key = key;
//            Value = value;
//            Next = next;
//        }
//    }
//    public HashTable ( int capacity = 8 )
//    {
//        if (capacity < 1) capacity = 1;
//        _data = new Node[capacity];
//    }

//    public void Add(string key, int value)
//    {
//        int idx = BucketIndex(key);
//        Node curr = _data![idx];

//        while (curr != null)
//        {
//            if (curr.Key == key) throw new InvalidOperationException("Key already exists");
//            curr = curr.Next;
//        }
//        _data[idx] = new Node(key, value, _data[idx]);
//        _count++;
//    }

//    public void Set(string key, int value)
//    {
//        if (key == null) throw new ArgumentNullException(nameof(key));

//        int idx = BucketIndex(key);
//        var curr = _data![idx];

//        while (curr != null)
//        {
//            if (curr.Key == key) { curr.Value = value; return; }
//            curr = curr.Next;
//        }
//        _data[idx] = new Node(key, value, _data[idx]);
//        _count++;
//    }

//    public bool TryGet(string key, out int value)
//    {
//        if (key is null) throw new ArgumentNullException(nameof(key));

//        int idx = BucketIndex(key);
//        var curr = _data![idx];

//        while (curr != null)
//        {
//            if (curr.Key == key) { value = curr.Value; return true; }
//            curr = curr.Next;
//        }
//        value = 0;
//        return false;
//    }

//    public void Print()
//    {
//        if (_data != null)
//        {
//            for (int i = 0; i < _data.Length; i++)
//            {
//                Console.Write($" [{i}] ");
//                var n = _data[i];

//                while (n != null)
//                {
//                    Console.Write($"{n.Key}:{n.Value} -> ");
//                    n = n.Next;
//                }
//                Console.WriteLine("null");
//            }
//        }
//    }
//    private int BucketIndex (string key)
//    {
//        int hash = 0;

//        for (int i = 0; i < key.Length; i++)
//        {
//            hash = hash * 31 + key[i];
//        }
//        if (hash < 0) hash = -hash;

//        return hash % _data!.Length;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var hasht = new HashTable();
//        hasht.Add("apple", 1);
//        hasht.Add("banana", 2);
//        hasht.Add("cherry", 3);
//        hasht.Print();
//    }
//}



class HashTable
{
    private Node?[] _buckets;
    private int _count;
    private sealed class Node
    {
        public string Key;
        public int Value;
        public Node Next;

        public Node ( string key, int value, Node? next )
        {
            Key = key;
            Value = value;
            Next = next;
        }
    }

    public HashTable ( int capacity = 8 )
    {
        if (capacity < 1) capacity = 1;
        _buckets = new Node[capacity];
    }

    public int Count => _count;

    private int BucketIndex ( string key )
    {
        ArgumentNullException.ThrowIfNull(key);

        int hash = 0, i = 0;

        while (i < key.Length)
        {
            hash = hash * 31 + key[i++];
        }
        if (hash < 0) hash = -hash;

        return hash % _buckets.Length;
    }

    public void Add ( string key, int value )
    {
        ArgumentNullException.ThrowIfNull(key);

        int idx = BucketIndex(key);
        var curr = _buckets[idx];

        while (curr != null)
        {
            if (curr.Key == key) throw new ArgumentException("Key already exists");
            curr = curr.Next;
        }
        _buckets[idx] = new Node(key, value, _buckets[idx]);
        _count++;
    }

    public void Set ( string key, int value )
    {
        ArgumentNullException.ThrowIfNull(key);

        int idx = BucketIndex(key);
        var curr = _buckets[idx];

        while (curr != null)
        {
            if (curr.Key == key) { curr.Value = value; return; }
            curr = curr.Next;
        }
        _buckets[idx] = new Node(key, value, _buckets[idx]);
        _count++;
    }

    public bool Remove ( string key )
    {
        ArgumentNullException.ThrowIfNull(key);

        int idx = BucketIndex(key);
        var curr = _buckets[idx];
        Node? prev = null;

        while (curr != null)
        {
            if (curr.Key == key)
            {
                if (prev == null) _buckets[idx] = curr.Next;
                else prev.Next = curr.Next;
                _count--;
                return true;
            }
            prev = curr;
            curr = curr.Next;
        }
        return false;
    }

    public void Print ( )
    {
        int i = 0;

        while (i < _buckets.Length)
        {
            Console.Write($"{i}: ");
            var curr = _buckets[i++];
            if (curr == null) Console.WriteLine("null");
            while (curr != null)
            {
                Console.WriteLine($"Key: {curr.Key}, Value: {curr.Value}");
                curr = curr.Next;
            }

        }
    }

    public bool TryGet ( string key, out int value )
    {
        ArgumentNullException.ThrowIfNull(key);
        int idx = BucketIndex(key);
        var curr = _buckets[idx];

        while (curr != null)
        {
            if (curr.Key == key) { value = curr.Value; return true; }
            curr = curr.Next;
        }
        value = 0;
        return false;
    }
}

class Program
{
    static void Main ( )
    {
        HashTable ht = new HashTable();
        ht.Add("apple", 1);
        ht.Add("cherry", 2);
        ht.Add("orange", 3);
        ht.Set("orangee", 4);
        ht.Remove("apple");

        if (ht.TryGet("apple", out int value))
        {
            Console.WriteLine($"TryGet: {value}");
        }
        ht.Print();
        Console.ReadLine();
    }
}
// public class OpenAddressingHashMap<K, V>
// {
//   private enum EntryState { Empty, Occupied, Deleted }

//   private K[] keys;
//   private V[] values;
//   private EntryState[] states;
//   private int capacity;
//   private int count;
//   private int usedSlots;
//   private const double MAX_LOAD = 0.5;

//   public int Count => count;

//   public OpenAddressingHashMap(int initialCapacity = 8)
//   {
//     if (initialCapacity < 3) initialCapacity = 3;
//     capacity = NextPowerOfTwo(initialCapacity);
//     keys = new K[capacity];
//     values = new V[capacity];
//     states = new EntryState[capacity];
//   }

//   private int Hash(K key)
//   {
//     int h = key == null ? 0 : key.GetHashCode();
//     unchecked { h = (h & 0x7fffffff); }
//     return h % capacity;
//   }

//   private static int NextPowerOfTwo(int n)
//   {
//     int p = 1;
//     while (p < n) p <<= 1;
//     return p;
//   }

//   public bool ContainsKey(K key) => TryGetValue(key, out _);

//   public V Get(K key)
//   {
//     if (TryGetValue(key, out V val)) return val;
//     throw new KeyNotFoundException("Key not found");
//   }


//   public bool TryGetValue(K key, out V value)
//   {
//     int idx = Hash(key);
//     int start = idx;
//     value = default!;
//     while (true)
//     {
//       var st = states[idx];
//       if (st == EntryState.Empty)
//       {
//         return false;
//       }
//       else if (st == EntryState.Occupied && EqualityComparer<K>.Default.Equals(keys[idx], key))
//       {
//         value = values[idx];
//         return true;
//       }

//       idx = (idx + 1) % capacity;
//       if (idx == start) return false;
//     }
//   }

//   public void Put(K key, V value)
//   {
//     if ((usedSlots + 1) > capacity * MAX_LOAD) Resize(capacity * 2);

//     int idx = Hash(key);
//     int firstDeleted = -1;
//     int start = idx;

//     while (true)
//     {
//       var st = states[idx];
//       if (st == EntryState.Empty)
//       {
//         int insertIdx = (firstDeleted != -1) ? firstDeleted : idx;
//         keys[insertIdx] = key;
//         values[insertIdx] = value;
//         states[insertIdx] = EntryState.Occupied;
//         count++;
//         usedSlots++;
//         return;
//       }
//       else if (st == EntryState.Deleted)
//       {
//         if (firstDeleted == -1) firstDeleted = idx;
//       }
//       else if (st == EntryState.Occupied && EqualityComparer<K>.Default.Equals(keys[idx], key))
//       {
//         values[idx] = value;
//         return;
//       }

//       idx = (idx + 1) % capacity;
//       if (idx == start) throw new InvalidOperationException("HashMap is full (shouldn't happen after resize)");
//     }
//   }
// }

public class OpenAddressingHashMap<K, V>
{
  private enum EntryState { Empty, Occupied, Deleted }

  private K[] keys;
  private V[] values;
  private EntryState[] states;
  private int capacity;
  private int count;
  private int usedSlots;
  private const double MAX_LOAD = 0.5;

  public int Count => count;

  public OpenAddressingHashMap(int initialCapacity = 8)
  {
    if (initialCapacity < 3) initialCapacity = 3;
    capacity = NextPowerOfTwo(initialCapacity);
    keys = new K[capacity];
    values = new V[capacity];
    states = new EntryState[capacity];
  }

  private int Hash(K key)
  {
    int h = key == null ? 0 : key.GetHashCode();
    unchecked { h = (h & 0x7fffffff); }
    return h % capacity;
  }

  private static int NextPowerOfTwo(int n)
  {
    int p = 1;
    while (p < n) p <<= 1;
    return p;
  }

  public bool ContainsKey(K key) => TryGetValue(key, out _);

  public V Get(K key)
  {
    if (TryGetValue(key, out V val)) return val;
    throw new KeyNotFoundException("Key not found");
  }

  public bool TryGetValue(K key, out V value)
  {
    int idx = Hash(key);
    int start = idx;
    value = default!;

    while (true)
    {
      var st = states[idx];
      if (st == EntryState.Empty) return false;
      else if (st == EntryState.Occupied && EqualityComparer<K>.Default.Equals(keys[idx], key))
      {
        value = values[idx];
        return true;
      }

      idx = (idx + 1) % capacity;
      if (idx == start) return false;
    }
  }

  public void Put(K key, V value)
  {
    if ((usedSlots + 1) > capacity * MAX_LOAD)
    {
      Resize(capacity * 2);
    }

    int idx = Hash(key);
    int firstDeleted = -1;
    int start = idx;

    while (true)
    {
      var st = states[idx];
      if (st == EntryState.Empty)
      {
        int insertIdx = (firstDeleted != -1) ? firstDeleted : idx;
        keys[insertIdx] = key;
        values[insertIdx] = value;
        states[insertIdx] = EntryState.Occupied;
        count++;
        usedSlots++;
        return;
      }

      else if (st == EntryState.Deleted)
      {
        if (firstDeleted == -1) firstDeleted = idx;
      }
      
      else if (st == EntryState.Occupied && EqualityComparer<K>.Default.Equals(keys[idx], key))
      {
        values[idx] = value;
        return;
      }

      idx = (idx + 1) % capacity;
      if (idx == start) throw new InvalidOperationException("HashMap is full (shouldn't happen after resize).");
    }
  }
}

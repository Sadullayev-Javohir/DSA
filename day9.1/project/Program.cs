// using System.Security.Cryptography;

// public class SinglyLinkedList<T>
// {
//   private sealed class Node
//   {
//     public T value;
//     public Node? Next;
//     public Node(T value)
//     {
//       this.value = value;
//       Next = null;
//     }
//   }

//   private Node? head;
//   private Node? tail;
//   private int count;

//   public SinglyLinkedList()
//   {
//     head = null;
//     tail = null;
//     count = 0;
//   }

//   public void AddFirst(T value)
//   {
//     var node = new Node(value);
//     node.Next = head;
//     head = node;

//     if (count == 0)
//     {
//       tail = node;
//     }
//     count++;
//   }

//   public void AddLast(T value)
//   {
//     var node = new Node(value);

//     if (count == 0) head = tail = node;
//     else
//     {
//       tail!.Next = node;
//       tail = node;
//     }
//     count++;
//   }

//   public T RemoveFirst()
//   {
//     EnsureNotEmpty();

//     T removed = head!.value;
//     head = head.Next;
//     count--;

//     if (count == 0) tail = null;
//     return removed;
//   }

//   public T RemoveLast()
//   {
//     EnsureNotEmpty();

//     if (count == 1)
//     {
//       T removed = head!.value;
//       head = tail = null;
//       count = 0;
//       return removed;
//     }

//     Node current = head!;
//     while (current.Next != tail) current = current.Next!;

//     T removedTail = tail!.value;
//     current.Next = null;
//     tail = current;
//     count--;

//     return removedTail;
//   }

//   public bool IsEmpty() => count == 0;

//   public int Count() => count;

//   public bool Contains(T value)
//   {
//     var comparer = EqualityComparer<T>.Default;
//     Node? current = head;
//     while (current != null)
//     {
//       if (comparer.Equals(current.value, value)) return true;
//       current = current.Next;
//     }
//     return false;
//   }

//   public int IndexOf(T value)
//   {
//     var comparer = EqualityComparer<T>.Default;
//     Node? current = head;
//     int index = 0;

//     while (current != null)
//     {
//       if (comparer.Equals(current.value, value)) return index;
//       current = current.Next;
//       index++;
//     }
//     return -1;
//   }

//   public T GetFirst()
//   {
//     EnsureNotEmpty();
//     return head!.value;
//   }

//   public T GetLast()
//   {
//     EnsureNotEmpty();
//     return tail!.value;
//   }

//   public void InsertAt(int index, T value)
//   {
//     if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index), "Index 0... count oralig'ida bo'lishi kerak.");
//     if (index == 0)
//     {
//       AddFirst(value);
//       return;
//     }

//     if (index == count)
//     {
//       AddLast(value);
//       return;
//     }

//     Node prev = GetNodeAt(index - 1);

//     var node = new Node(value)
//     {
//       Next = prev.Next
//     };

//     prev.Next = node;
//     count++;
//   }

//   public T RemoveAt(int index)
//   {
//     EnsureIndexInRange(index);

//     if (index == 0) return RemoveFirst();

//     if (index == count - 1) return RemoveLast();

//     Node prev = GetNodeAt(index - 1);
//     Node removed = prev.Next!;
//     prev.Next = removed.Next;
//     count--;

//     return removed.value;
//   }

//   public T GetAt(int index)
//   {
//     EnsureIndexInRange(index);
//     return GetNodeAt(index).value;
//   }

//   public void Clear()
//   {
//     head = null;
//     tail = null;
//     count = 0;
//   }

//   public void Traverse(Action<T> action)
//   {
//     if (action == null) throw new ArgumentNullException(nameof(action));

//     Node? current = head;
//     while ( current!= null)
//     {
//       action(current.value);
//       current = current.Next;
//     }
//   }



//   private void EnsureIndexInRange(int index)
//   {
//     if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index), $"Index 0...{count - 1} oralig'ida bo'lishi kerak.");
//   }

//   private Node GetNodeAt(int index)
//   {
//     Node current = head!;
//     for (int i = 0; i < index; i++) current = current.Next!;

//     return current;
//   }

//   private void EnsureNotEmpty()
//   {
//     if (count == 0) throw new InvalidOperationException("Linked List bo'sh (empty)");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var list = new SinglyLinkedList<int>();

//     list.AddFirst(10);
//   }
// }


// using System.Net.Http.Headers;
// using System.Security.Cryptography.X509Certificates;

// class SinglyLinkedList<T>
// {
//   private sealed class Node
//   {
//     public Node? Next;
//     public T Value;

//     public Node(T value)
//     {
//       Value = value;
//       Next = null;
//     }
//   }

//   private Node? head;
//   private Node? tail;
//   private int count;

//   public SinglyLinkedList()
//   {
//     head = tail = null;
//     count = 0;
//   }

//   public void AddFirst(T value)
//   {
//     var node = new Node(value);
//     if (count == 0)
//     {
//       head = tail = node;
//       count++; return;
//     }

//     node.Next = head;
//     head = node;
//     count++;
//   }

//   public void AddLast(T value)
//   {
//     var node = new Node(value);

//     if (count == 0)
//     {
//       head = tail = node;
//       count++;
//       return;
//     }

//     tail!.Next = node;
//     tail = node;
//     count++;
//   }

//   public T RemoveFirst()
//   {
//     EnsureNotEmpty();
//     T removed = head!.Value;
//     head = head.Next;
//     count--;

//     if (count == 0) tail = null;

//     return removed;
//   }

//   public T RemoveLast()
//   {
//     EnsureNotEmpty();

//     if (count == 1)
//     {
//       T removed = head!.Value;
//       head = tail = null;
//       count = 0;
//       return removed;
//     }

//     Node current = head!;
//     while (current.Next != tail) current = current.Next!;

//     T removedTail = tail!.Value;
//     current.Next = null;
//     tail = current;
//     count--;
//     return removedTail;
//   }

//   public bool IsEmpty() => count == 0;

//   public int Count() => count;

//   public bool Contains(T value)
//   {
//     var comparer = EqualityComparer<T>.Default;
//     var currrent = head!;
//     while (currrent != null)
//     {
//       if (comparer.Equals(currrent!.Value, value)) return true;
//       else
//       {
//         currrent = currrent.Next;
//       }
//     }
//     return false;
//   }

//   public int IndexOf(T value)
//   {
//     var current = head;
//     var comparer = EqualityComparer<T>.Default;
//     int index = 0;

//     while (current != null)
//     {
//       if (comparer.Equals(current.Value, value)) return index;
//       current = current.Next;
//       index++;
//     }
//     return -1;
//   }

//   public T GetFirst()
//   {
//     EnsureNotEmpty();
//     T get = head!.Value;
//     return get;
//   }

//   public T GetLast()
//   {
//     EnsureNotEmpty();
//     T get = tail!.Value;
//     return get;
//   }

//   public void InsertAt(int index, T value)
//   {
//     if (index < 0 || index > count) throw new ArgumentOutOfRangeException(nameof(index), $"0...{index} oralig'ida bo'lishi kerak.");

//     if (index == 0)
//     {
//       AddFirst(value);
//       return;
//     }

//     if (count == index)
//     {
//       AddLast(value);
//       return;
//     }

//     Node prev = GetNodeAt(index - 1);
//     var node = new Node(value);
//     node.Next = prev.Next;
//     prev.Next = node;
//     count++;
//   }

//   public T RemoveAt(int index)
//   {
//     if (count < index || index < 0) throw new IndexOutOfRangeException($"index: 0...{count} oralig'ida bo'lishi kerak.");

//     if (index == 0) return RemoveFirst();
//     if (index == count) return RemoveLast();

//     var prev = GetNodeAt(index - 1);
//     Node removed = prev.Next!;
//     prev.Next = removed.Next;
//     count--;
//     return removed.Value;
//   }

//   public T GetAt(int index)
//   {
//     EnsureIndexInRange(index);
//     return GetNodeAt(index).Value;
//   }

//   public void Clear()
//   {
//     head = tail = null;
//     count = 0;
//   }



//   public void Traverse(Action<T> action)
//   {
//     if (action == null) throw new ArgumentNullException(nameof(action));
//     Node? current = head;
//     while (current != null)
//     {
//       action(current.Value);
//       current = current.Next;
//     }
//   }

//   public void Reverse()
//   {
//     if (count <= 1) return;

//     Node? prev = null;
//     Node? current = head;
//     tail = head;

//     while (current != null)
//     {
//       Node? next = current.Next;
//       current.Next = prev;
//       prev = current;
//       current = next;
//     }
//     head = prev;
//   }

//   public T[] ToArray()
//   {
//     T[] arr  = new T[count];
//     Node? current = head;
//     int i = 0;

//     while (current != null)
//     {
//       arr[i++] = current.Value;
//       current = current.Next;
//     }
//     return arr;
//   }



//   private Node GetNodeAt(int index)
//   {
//     Node current = head!;
//     for (int i = 0; i < index; i++)
//     {
//       current = current.Next!;
//     }
//     return current;
//   }


//   public void Print()
//   {
//     if (count == 0) { Console.WriteLine("Bo'sh"); return; }
//     var current = head!;
//     while (current != null)
//     {
//       Console.Write(current!.Value);
//       if (count >= 0) Console.Write("->");
//       current = current.Next;
//     }
//     Console.Write("null");
//     Console.WriteLine();
//   }

//   private void EnsureNotEmpty()
//   {
//     if (count == 0) throw new ArgumentException("Bo'sh");
//   }

//   private void EnsureIndexInRange(int index)
//   {
//     if (index < 0 || index >= count) throw new ArgumentOutOfRangeException(nameof(index), $"Index 0...{index} oralig'ida bo'lishi kerak");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     SinglyLinkedList<int> linkedlist = new SinglyLinkedList<int>();
//     linkedlist.AddFirst(1);
//     linkedlist.AddFirst(2);
//     linkedlist.InsertAt(0, 0);
//     // linkedlist.Traverse(x =>
//     // {
//     //   if (x % 2 == 0) Console.WriteLine($"{x} juft");
//     // });
//     // int sum = 0;
//     // linkedlist.Traverse(x => sum += x);
//     // Console.WriteLine(sum);


//     // linkedlist.AddLast(3);

//     // linkedlist.RemoveFirst();
//     // linkedlist.RemoveFirst();
//     // linkedlist.RemoveLast();
//     // Console.WriteLine(linkedlist.IsEmpty());
//     // Console.WriteLine(linkedlist.Count());
//     // Console.WriteLine(linkedlist.Contains(3));
//     // Console.WriteLine(linkedlist.IndexOf(1));
//     // Console.WriteLine(linkedlist.GetFirst());
//     // Console.WriteLine(linkedlist.GetLast());

//     linkedlist.Print();

//     linkedlist.Reverse();
//     linkedlist.Print();
//   }
// }


// class SinglyLinkedList<T>
// {
//   private sealed class Node
//   {
//     public Node? Next;
//     public T? Value;

//     public Node(T value)
//     {
//       Next = null;
//       Value = value;
//     }
//   }
//   private Node? head;
//   private Node? tail;
//   private int count;

//   public SinglyLinkedList()
//   {
//     head = null;
//     tail = null;
//     count = 0;
//   }

//   public void AddFirst(T value)
//   {
//     var node = new Node(value);
//     node.Next = head;
//     head = node;

//     if (count == 0)
//     {
//       tail = node;
//     }
//     count++;
//   }

//   public void AddLast(T value)
//   {
//     var node = new Node(value);
//     if (count == 0) { head = tail = node; count++; return; }
//     tail!.Next = node;
//     tail = node;
//     count++;
//   }

//   public T RemoveFirst()
//   {
//     IsEmpty();

//     T removed = head!.Value;
//     head = head.Next;
//     count--;

//     if (count == 0) tail = null;
//     return removed!;
//   }

//   public T RemoveLast()
//   {
//     IsEmpty();

//     if (count == 1)
//     {
//       T removed = head!.Value;
//       head = tail = null;
//       count = 0;
//       return removed;
//     }

//     var current = head;
//     while (current!.Next != tail)
//     {
//       current = current.Next;
//     }

//     T? removedTail = tail!.Value;
//     current.Next = null;
//     tail = current;
//     count--;

//     return removedTail;



//   }

//   public void Print()
//   {

//     IsEmpty();
//     var current = head;

//     while (current != null)
//     {
//       Console.Write(current.Value);
//       Console.Write("->");
//       current = current.Next;
//     }

//     Console.Write("null");
//   }

//   // public bool IsEmpty() => count == 0;
//   public int Count => count;



//   public void IsEmpty()
//   {
//     if (count == 0) Console.WriteLine("Bo'sh");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var linkedList = new SinglyLinkedList<int>();
//     // linkedList.AddFirst(1);
//     // linkedList.AddFirst(2);
//     // linkedList.AddFirst(3);

//     // linkedList.AddLast(0);

//     linkedList.Print();

//   }
// }


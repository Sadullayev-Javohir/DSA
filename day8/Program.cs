public class Node<T>
{
  public T Data { get; set; }
  public Node<T> Next { get; set; }
  public Node<T> Previous { get; set; }

  public Node(T data)
  {
    Data = data;
    Next = null;
    Previous = null;
  }
}

public class DoublyLinkedList<T>
{
  public Node<T> Head { get; private set; }
  public Node<T> Tail { get; private set; }
  public int Count { get; private set; }

  public DoublyLinkedList()
  {
    Head = null;
    Tail = null;
    Count = 0;
  }

  public void AddFirst(T data)
  {
    var newNode = new Node<T>(data);
    if (Head == null) Head = Tail = newNode;
    else
    {
      newNode.Next = Head;
      Head.Previous = newNode;
      Head = newNode;
    }
    Count++;
  }
  public void AddLast(T data)
  {
    var newNode = new Node<T>(data);
    if (Head == null) Head = Tail = newNode;
    else
    {
      Tail.Next = newNode;
      newNode.Previous = Tail;
      Tail = newNode;
    }
    Count++;
  }

  public bool Remove(T data)
  {
    var curr = Head;

    while (curr != null)
    {
      if (curr.Data.Equals(data))
      {
        if (curr.Previous != null)
          curr.Previous.Next = curr.Next;
        else
          Head = curr.Next;

        if (curr.Next != null)
          curr.Next.Previous = curr.Previous;
        else
          Tail = curr.Previous;
        Count--;
        return true;
      }
      curr = curr.Next;
    }
    return false;
  }

  public bool Contains(T data)
  {
    var curr = Head;

    while (curr != null)
    {
      if (curr.Data.Equals(data))
      {
        return true;
      }
      curr = curr.Next;
    }
    return false;
  }

  public void Clear()
  {
    Head = null;
    Tail = null;
    Count = 0;
  }

  public void PrintList()
  {
    var current = Head;
    Console.Write("Head -> ");

    while (current != null)
    {
      if (Count == 1)
      {
        Console.Write(current.Data + " -> ");
      }
      else
      {
        Console.Write(current.Data + " <-> ");
      }
      current = current.Next;
    }
    Console.WriteLine("null");
  }
}

class Program
{
  static void Main()
  {
    DoublyLinkedList<int> list = new DoublyLinkedList<int>();

    list.AddFirst(1);
    list.AddFirst(2);
    list.AddLast(0);
    list.Clear();
    list.PrintList();
  }
}

// public class Node<T>
// {
//   public T Value { get; set; }
//   public Node<T> Next { get; set; }
//   public Node<T> Previous { get; set; }

//   public Node(T value)
//   {
//     Value = value;
//     Next = null;
//     Previous = null;
//   }
// }

// public class DoublyLinkedList<T>
// {
//   public Node<T> head { get; private set; }
//   public Node<T> tail { get; private set; }
//   public int Count { get; private set; }

//   public DoublyLinkedList()
//   {
//     head = null;
//     tail = null;
//     Count = 0;
//   }

//   public void AddFirst(T value)
//   {
//     var node = new Node<T>(value);

//     if (head == null) head = tail = node;
//     else
//     {
//       node.Next = head;
//       head.Previous = node;
//       head = node;
//     }
//     Count++;
//   }

//   public void AddLast(T value)
//   {
//     var node = new Node<T>(value);
//     if (head == null) tail = head = node;
//     else
//     {
//       tail.Next = node;
//       node.Previous = tail;
//       tail = node;
//     }
//     Count++;
//   }

//   public bool Remove(T value)
//   {
//     var curr = head;
//     while (curr != null)
//     {
//       if (curr.Value.Equals(value))
//       {
//         if (curr.Previous != null)
//         {
//           curr.Previous.Next = curr.Next;
//         }
//         else
//         {
//           head = curr.Next;
//         }

//         if (curr.Next != null)
//         {
//           curr.Next.Previous = curr.Previous;
//         }
//         else
//         {
//           tail = curr.Previous;
//         }
//         Count--;
//         return true;
//       }
//       curr = curr.Next;
//     }
//     return false;
//   }

//   public void ToString()
//   {
//     var curr = head;

//     Console.Write("Head -> ");
//     while (curr != null)
//     {
//       if (Count == 1) Console.Write(curr.Value);
//       else
//       {
//         Console.Write(curr.Value + " <-> ");
//       }
//       curr = curr.Next;
//     }
//     Console.WriteLine(" null");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var list = new DoublyLinkedList<int>();
//     list.AddFirst(1);
//     list.AddFirst(2);
//     list.AddLast(0);
//     Console.WriteLine(list.Remove(0));
//     list.ToString();
//   }
// }


// public class Node<T>
// {
//   public T value { get; set; }
//   public Node<T> Next { get; set; }

//   public Node(T value)
//   {
//     this.value = value;
//     Next = null;
//   }
// }

// public class SinglyLinkedList<T>
// {
//   public Node<T> head { get; private set; }
//   public Node<T> tail { get; private set; }
//   public int Count { get; private set; }

//   public SinglyLinkedList()
//   {
//     head = null;
//     tail = null;
//     Count = 0;
//   }

//   public void InsertHead(T value)
//   {
//     var node = new Node<T>(value);
//     if (head == null) head = tail = node;
//     else
//     {
//       node.Next = head;
//       head = node;
//     }
//     Count++;
//   }

//   public void InsertTail(T value)
//   {
//     var node = new Node<T>(value);
//     if (head == null) tail = head = null;
//     else
//     {
//       tail.Next = node;
//       tail = node;
//     }
//     Count++;
//   }

//   public void InsertAt(int index, T value)
//   {
//     if (index < 0 || index > Count) throw new ArgumentOutOfRangeException(nameof(index));
//     if (index == 0) InsertHead(value);
//     if (index == Count) InsertTail(value);

//     var node = new Node<T>(value);
//     var prev = head;
//     for (int i = 0; i < index - 1; i++) prev = prev.Next;
//     node.Next = prev.Next;
//     prev.Next = node;
//     Count++;
//   }

//   public void DeleteHead()
//   {
//     if (head == null) return;
//     head = head.Next;
//     Count--;
//   }

//   public void DeleteAt(int index)
//   {
//     if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index));
//     if (index == 0) { DeleteHead(); return; }

//     var prev = head;
//     for (int i = 0; i < index - 1; i++) prev = prev.Next;
//     var curr = prev.Next;

//     prev.Next = curr.Next;

//     if (curr == tail)
//     {
//       tail = prev;
//     }
//     Count--;
//   }


//   public void Reverse()
//   {
//     if (head == null) return;
//     Node<T> prev = null;
//     var curr = head;
//     tail = head;

//     while (curr != null)
//     {
//       var next = curr.Next;
//       curr.Next = prev;
//       prev = curr;
//       curr = next;
//     }
//     head = prev;
//   }

//   public void ToString()
//   {
//     if (Count == 0) { Console.WriteLine("Empty"); return; }
//     Console.Write("Head");
//     var curr = head;

//     while (curr != null)
//     {
//       if (Count != 1) Console.Write(" -> ");
//       Console.Write(curr.value);
//       curr = curr.Next;
//     }
//     Console.WriteLine(" -> null");
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     var list = new SinglyLinkedList<int>();
//     list.InsertHead(1);
//     list.InsertHead(2);
//     list.InsertTail(0);
//     list.InsertAt(1, 5);
//     list.Reverse();
//     // list.DeleteHead();
//     // list.DeleteAt(1);
//     list.ToString();
//   }
// }

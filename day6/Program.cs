using System;
using System.Text;

// public class SimplyLinkedList<T>
// {
//   public class Node
//   {
//     public T value;
//     public Node Next;

//     public Node(T value)
//     {
//       this.value = value;
//       Next = null;
//     }
//   }
//   private Node head;
//   private Node tail;
//   public int Count { get; private set; }

//   public SimplyLinkedList()
//   {
//     head = null;
//     tail = null;
//     Count = 0;
//   }

//   public void InsertHead(T value)
//   {
//     var node = new Node(value);
//     node.Next = head;
//     head = node;
//     if (tail == null) tail = head;
//     Count++;
//   }

//   public override string ToString()
//   {
//     if (head == null) return "Empty";
//     var sb = new StringBuilder();
//     var curr = head;

//     while (curr != null)
//     {
//       sb.Append(curr.value);
//       if (curr.Next != null) sb.Append(" -> ");
//       curr = curr.Next;
//     }
//     return sb.ToString();
//   }

//   public void InsertTail(T value)
//   {
//     var node = new Node(value);
//     if (head == null)
//     {
//       head = node;
//       tail = node;
//     }
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
//     if (index == 0) { InsertHead(value); return; }
//     if (index == Count) { InsertTail(value); return; }

//     var newNode = new Node(value);
//     var prev = head;
//     for (int i = 0; i < index - 1; i++) prev = prev.Next;
//     newNode.Next = prev.Next;
//     prev.Next = newNode;
//     Count++;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var list = new SimplyLinkedList<int>();

//     list.InsertHead(1);
//     list.InsertHead(2);
//     list.InsertHead(3);
//     list.InsertHead(4);

//     Console.WriteLine(list);
//   }
// }

public class SinglyLinkedList<T>
{
  public class Node
  {
    public T Value;
    public Node Next;

    public Node(T value)
    {
      Value = value;
      Next = null;
    }
  }

  private Node head;
  private Node tail;
  public int Count { get; private set; }

  public SinglyLinkedList()
  {
    head = null;
    tail = null;
    Count = 0;
  }

  public void InsertHead(T value)
  {
    var node = new Node(value);
    node.Next = head;
    head = node;
    if (tail == null) tail = head;
    Count++;
  }

  public void InsertTail(T value)
  {
    var node = new Node(value);
    if (head == null)
    {
      tail = node;
      head = node;
    }
    else
    {
      tail.Next = node;
      tail = node;
    }
    Count++;
  }

  public void InsertAt(int index, T value)
  {
    if (index < 0 || index > Count) throw new ArgumentOutOfRangeException(nameof(index));
    if (index == 0) { InsertHead(value); return; }
    if (index == Count) { InsertTail(value);  return; }

    var newNode = new Node(value);
    var prev = head;
    for (int i = 0; i < index - 1; i++) prev = prev.Next;

    newNode.Next = prev.Next;
    prev.Next = newNode;
    Count++;
  }

  public override string ToString()
  {
    if (head == null) return "Empty";
    var sb = new StringBuilder();
    var curr = head;
    while (curr != null)
    {
      sb.Append(curr.Value);
      if (curr.Next != null) sb.Append(" -> ");
      curr = curr.Next;
    }
    return sb.ToString();
  }
}

class Program
{
  static void Main()
  {
    var list = new SinglyLinkedList<int>();
    list.InsertHead(1);
    list.InsertTail(2);
    list.InsertAt(2, 199);
    list.InsertHead(4);
    Console.WriteLine(list);
  }
}

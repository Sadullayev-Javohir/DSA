using System;
using System.Text;

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
    if (tail == null)
    {
      tail = head = node;
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
    if (index == Count) { InsertTail(value); return; }

    var prev = head;
    var node = new Node(value);
    for (int i = 0; i < index - 1; i++) prev = prev.Next;

    node.Next = prev.Next;
    prev.Next = node;
    Count++;
  }

  public T DeleteHead()
  {
    if (head == null) throw new InvalidOperationException("List empty");
    var val = head.Value;
    head = head.Next;
    if (head == null) tail = null;
    Count--;
    return val;
  }

  public T DeleteAt(int index)
  {
    if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException("List empty");
    if (index == 0) DeleteHead();

    var prev = head;
    for (int i = 0; i < index - 1; i++) prev = prev.Next;
    var target = prev.Next;
    prev.Next = target.Next;
    if (target == tail) tail = prev;
    Count--;
    return target.Value;
  }

  public int IndexOf(T value)
  {
    var curr = head;
    int idx = 0;
    EqualityComparer<T> cmp = EqualityComparer<T>.Default;

    while (curr != null)
    {
      if (cmp.Equals(curr.Value, value)) return idx;
      curr = curr.Next;
      idx++;
    }
    return -1;
  }


  public void Reverse()
  {
    Node previous = null;
    var current = tail = head;
    while (current != null)
    {
      var next = current.Next;
      current.Next = previous;
      previous = current;
      current = next;
    }
    head = previous;
  }

  public override string ToString()
  {
    if (head == null) return "List empty";
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
    list.InsertHead(2);
    list.InsertHead(3);

    // list.InsertTail(0);
    // list.InsertAt(0, 2);
    // list.DeleteHead();
    list.Reverse();
    Console.WriteLine(list);
    // list.IndexOf(2);
    // Console.WriteLine(list.IndexOf(3));
  }
}

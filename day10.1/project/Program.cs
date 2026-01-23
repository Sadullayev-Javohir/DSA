// public class MyQueue<T>
// {
//   public sealed class Node
//   {
//     public T Value;
//     public Node? Next;

//     public Node(T value) => Value = value;
//   }

//   public Node? _tail;
//   public Node? _front;
//   public int Count {get;private set;}

//   public bool IsEmpty() => Count == 0;

//   public void Enqueue(T value)
//   {
//     var node = new Node(value);
//     if (_tail == null) _front = _tail = node;
//     else
//     {
//       _tail.Next = node;
//       _tail = node;
//     }
//     Count++;
//   }

//   public T Dequeue()
//   {
//     EmptyError();
//     if (_front == null)
//     {
//       _tail = null;
//     }
//     T removed = _front.Value;
//     _front = _front.Next;
//     Count--;
//     return removed;
//   }

//   public void EmptyError()
//   {
//     if (IsEmpty()) Console.WriteLine("Bo'sh");
//   }

//   public T Peek()
//   {
//     return _front.Value;
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     var queue = new MyQueue<int>();
//     queue.Enqueue(1);
//     queue.Enqueue(2);
//     Console.WriteLine(queue.Dequeue());
//     Console.WriteLine(queue.Peek());
//   }
// }

public class MyStack
{
  public Queue<int> q1;
  public Queue<int> q2;

  public MyStack()
  {
    q1 = new Queue<int>();
    q2 = new Queue<int>();
  }

  public void Push(int x)
  {
    q2.Enqueue(x);
    while (q1.Count > 0)
    {
      q2.Enqueue(q1.Dequeue());
    }
    (q1, q2) = (q2, q1);
  }

  public int Pop() => q1.Dequeue();

  public int Top() => q1.Peek();

  public bool Empty => q1.Count == 0;
}

class Program
{
  static void Main()
  {
    MyStack stack = new MyStack();
    stack.Push(1);
    Console.WriteLine(stack.Top());
  }
}

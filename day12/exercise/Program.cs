using System;

public class CircularQueue<T>
{
  private T[] _buffer;
  private int _head;
  private int _tail;
  private int _count;

  public int Count => _count;
  public int Capacity => _buffer.Length;

  public CircularQueue(int capacity = 4)
  {
    if (capacity < 1) throw new ArgumentException("Capacity must be >= 1");
    _buffer = new T[capacity];
    _head = 0;
    _tail = 0;
    _count = 0;
  }

  public void Enqueue(T item)
  {
    if (_count == _buffer.Length) Resize(_buffer.Length * 2);

    _buffer[_tail] = item;
    _tail = (_tail + 1) % _buffer.Length;
    _count++;
  }

  private void Resize(int newCapacity)
  {
    if (newCapacity < 1) newCapacity = 1;
    T[] newBuffer = new T[newCapacity];

    for (int i = 0; i < _count; i++)
    {
      newBuffer[i] = _buffer[(_head + i) % _buffer.Length];
    }
    _buffer = newBuffer;
    _head = 0;
    _tail = _count % _buffer.Length;
  }

  public T Dequeue()
  {
    if (_count == 0) throw new InvalidOperationException("Queue is empty");
    T result = _buffer[_head];
    _buffer[_head] = default(T);
    _head = (_head + 1) % _buffer.Length;
    _count--;
    if (_count > 0 && _count == _buffer.Length / 4) Resize(_buffer.Length / 2);

    return result;
  }

  public T Peek()
  {
    if (_count == 0) throw new InvalidOperationException("Queue is empty");
    return _buffer[_head];
  }

  public bool IsEmpty() => _count == 0;
  public bool IsFull() => _count == _buffer.Length;
}

// class Program
// {
//   static void Main()
//   {
//     var q = new CircularQueue<int>(3);
//     q.Enqueue(10);
//     q.Enqueue(20);
//     q.Enqueue(30);
//     // Console.WriteLine(q.Dequeue());
//     while (!q.IsEmpty()) Console.WriteLine(q.Dequeue());
//   }
// }

// class CircularQueue<T>
// {
//   private T[] _buffer;
//   private int _head;
//   private int _tail;
//   private int _count;

//   public int Count => _count;
//   public int Capacity => _buffer.Length;

//   public CircularQueue(int capacity = 4)
//   {
//     if (capacity < 1) throw new ArgumentException("Capacity must be >= 1");
//     _buffer = new T[capacity];
//     _head = 0;
//     _tail = 0;
//     _count = 0;
//   }

//   public void Enqueue(T item)
//   {
//     if (_buffer.Length == _count) Resize(_buffer.Length * 2);
//     _buffer[_tail] = item;
//     _tail = (_tail + 1) % _buffer.Length;
//     _count++;
//   }

//   public T Dequeue()
//   {
//     if (_count == 0) throw new InvalidOperationException("Queue is empty");

//     T result = _buffer[_head];
//     _buffer[_head] = default(T);
//     _head = (_head + 1) % _buffer.Length;
//     _count--;

//     if (_count > 0 && _count == _buffer.Length / 4) Resize(_buffer.Length / 2);
//     return result;
//   }

//   public T Peek()
//   {
//     if (_count == 0) throw new InvalidOperationException("Queue is empty");
//     return _buffer[_head];
//   }

//   public bool IsEmpty() => _count == 0;
//   public bool IsFull() => _count == _buffer.Length;



//   private void Resize(int newCapacity)
//   {
//     if (newCapacity < 1) newCapacity = 1;
//     T[] newBuffer = new T[newCapacity];

//     for (int i = 0; i < _count; i++)
//     {
//       newBuffer[i] = _buffer[(_head + 1) % _buffer.Length];
//     }
//     _buffer = newBuffer;
//     _head = 0;
//     _tail = _count % _buffer.Length;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var q = new CircularQueue<int>(4);
//     q.Enqueue(1);
//     q.Enqueue(2);
//     q.Enqueue(3);
//     q.Enqueue(4);
//     Console.WriteLine(q.Capacity);
//   }
// }

// public class Solution
// {
//   public int[] GetNoZeroIntegers(int n)
//   {
//     for (int a = 1; a < n; a++)
//     {
//       int b = n - a;
//       if (!HasZero(a) && !HasZero(b)) return new int[] { a, b };
//     }
//     return new int[0];
//   }
//   private bool HasZero(int x)
//   {
//     while (x > 0)
//     {
//       if (x % 10 == 0) return true;
//       x /= 10;
//     }
//     return false;
//   }
// }

// public class MyCircularQueue
// {
//   private int[] buffer;
//   private int head;
//   private int tail;
//   private int count;

//   public MyCircularQueue(int k)
//   {
//     buffer = new int[k];
//     head = 0;
//     tail = 0;
//     count = 0;
//   }

//   public bool Enqueue(int value)
//   {
//     if (IsFull()) return false;
//     buffer[tail] = value;
//     tail = (tail + 1) % buffer.Length;
//     count++;
//     return true;
//   }

//   public bool Dequeue()
//   {
//     if (IsEmpty()) return false;
//     head = (head + 1) % buffer.Length;
//     count--;
//     return true;
//   }

//   public int Front()
//   {
//     if (IsEmpty()) return -1;
//     return buffer[head];
//   }

//   public int Rear()
//   {
//     if (IsEmpty()) return -1;
//     int lastIndex = (tail - 1 + buffer.Length) % buffer.Length;
//     return buffer[lastIndex];
//   }

//   public bool IsEmpty() => count == 0;
//   public bool IsFull() => count == buffer.Length;
// }

public class MyQueue
{
  private Stack<int> inStack;
  private Stack<int> outStack;
  public MyQueue()
  {
    inStack = new Stack<int>();
    outStack = new Stack<int>();
  }

  public void Push(int x)
  {
    inStack.Push(x);
  }

  public int Pop()
  {
    Move();
    return outStack.Pop();
  }

  public int Peek()
  {
    Move();
    return outStack.Peek();
  }

  public bool Empty()
  {
    return inStack.Count == 0 && outStack.Count == 0;
  }

  private void Move()
  {
    if (outStack.Count == 0)
    {
      while (inStack.Count > 0) outStack.Push(inStack.Pop());
    }
  }
}

// public class Program
// {
//   static void Main()
//   {
//     var q = new MyQueue();
//     q.Push(2);
//     q.Push(3);
//     Console.WriteLine(q.Peek());
//   }
// }


public class MyStack
{
  private Queue<int> q1;
  private Queue<int> q2;

  public MyStack()
  {
    q1 = new Queue<int>();
    q2 = new Queue<int>();
  }

  public void Push(int x)
  {
    q2.Enqueue(x);

    while (q1.Count > 0) q2.Enqueue(q1.Dequeue());

    var temp = q1;
    q1 = q2;
    q2 = temp;
  }

  public int Pop() => q1.Dequeue();

  public int Top() => q1.Peek();

  public bool Empty() => q1.Count == 0;
}

// class Program
// {
//   static void Main()
//   {
//     MyStack st = new MyStack();
//     st.Push(1);
//     st.Push(2);
//     Console.Write(st.Top());
//   }
// }

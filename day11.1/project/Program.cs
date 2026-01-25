// var stack = new MyStack<int>();

// stack.Push(1);
// stack.Push(2);
// stack.Push(3);

// while (stack.top >= 0)
// {
//   Console.WriteLine(stack.Pop());
// }

// public class MyStack<T>
// {
//   public int top;
//   public T[] items;

//   public MyStack(int capacity = 4)
//   {
//     items = new T[capacity];
//     top = -1;
//   }

//   public void Push(T value)
//   {
//     if (top == items.Length - 1) Resize();
//     items[++top] = value;
//   }

//   public T Pop()
//   {
//     if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
//     return items[top--];
//   }

//   public T Peek()
//   {
//     if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
//     return items[top];
//   }

//   public bool IsEmpty() => top == -1;

//   private void Resize()
//   {
//     T[] newArray = new T[items.Length * 2];
//     Array.Copy(items, newArray, items.Length);
//     items = newArray;
//   }
// }


var stack = new StackUsingLinkedList<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);

while (!stack.IsEmpty())
{
  Console.WriteLine(stack.Pop());
}

public class StackUsingLinkedList<T>
{
  private Node? top;

  private sealed class Node
  {
    public T Value;
    public Node? Next;
    public Node(T value)
    {
      Value = value;
      Next = null;
    }
  }

  public void Push(T value)
  {
    var node = new Node(value);
    node.Next = top;
    top = node;
  }

  public T Pop()
  {
    if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
    T value = top!.Value;
    top = top.Next;
    return value;
  }

  public T Peek()
  {
    if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
    return top.Value;
  }

  public bool IsEmpty() => top == null;
}

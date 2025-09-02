public class ArrayStack<T>
{
  private T[] data;
  private int count;

  public ArrayStack(int initialCapacity = 4)
  {
    if (initialCapacity < 1) initialCapacity = 4;
    data = new T[initialCapacity];
    count = 0;
  }

  public void Push(T item)
  {
    if (count == data.Length)
    {
      Array.Resize(ref data, data.Length * 2);
    }
    data[count++] = item;
  }

  public T Pop()
  {
    if (count == 0)
    {
      throw new InvalidOperationException("Stack is empty");
    }
    T item = data[--count];
    data[count] = default(T);
    return item;
  }

  public T Peek()
  {
    if (count == 0) throw new InvalidOperationException("stack is empty");
    return data[count - 1];
  }

  public bool IsEmpty() => count == 0;
  public int Size() => count;

}

// class Program
// {
//   static void Main()
//   {
//     ArrayStack<int> stack = new ArrayStack<int>();

//     Console.WriteLine("Stackga element qo'shamiz");
//     stack.Push(1);
//     stack.Push(2);
//     stack.Push(3);
//     // Console.WriteLine(stack.Size());
//     // Console.WriteLine(stack.Peek());
//     while (!stack.IsEmpty())
//     {
//       Console.WriteLine(stack.Pop());
//     }
//   }
// }


// public class ArrayStack<T>
// {
//   private T[] data;
//   private int count;

//   public ArrayStack(int initialCapacity = 4)
//   {
//     if (initialCapacity < 1) initialCapacity = 4;
//     data = new T[initialCapacity];
//     count = 0;
//   }

//   public void Push(T item)
//   {
//     if (data.Length == count) Array.Resize(ref data, data.Length * 2);
//     data[count++] = item;
//   }

//   public T Pop()
//   {
//     if (count == 0) throw new InvalidOperationException("Stack is empty");

//     T item = data[--count];
//     data[count] = default(T);
//     return item;
//   }

//   public T Peek()
//   {
//     if (count == 0) throw new InvalidOperationException("Stack is empty");

//     return data[count - 1];
//   }

//   public bool IsEmpty() => count == 0;
//   public int Size() => count;
// }

// public class Program
// {
//   static void Main()
//   {
//     var stack = new ArrayStack<int>();
//     stack.Push(1);
//     stack.Push(2);
//     stack.Push(3);

//     Console.WriteLine(stack.Peek());

//     // while (!stack.IsEmpty())
//     // {
//     //   Console.WriteLine(stack.Pop());
//     // }
//   }
// }


// public class LinkedStack<T>
// {
//   private Node top;
//   private int count;

//   private class Node
//   {
//     public T Value;
//     public Node Next;
//     public Node(T value, Node next)
//     {
//       Value = value; Next = next;
//     }
//   }
//   public LinkedStack()
//   {
//     top = null;
//     count = 0;
//   }

//   public void Push(T item)
//   {
//     top = new Node(item, top);
//     count++;
//   }

//   public T Pop()
//   {
//     if (count == 0) throw new InvalidOperationException("stack is empty");

//     T val = top.Value;
//     top = top.Next;
//     count--;
//     return val;
//   }

//   public T Peek()
//   {
//     if (count == 0) throw new InvalidOperationException("stack is empty");
//     return top.Value;
//   }

//   public void PrintAll()
//   {
//     Node current = top;

//     while (current != null)
//     {
//       Console.WriteLine(current.Value);
//       current = current.Next;
//     }
//     Console.WriteLine();
//   }

//   public bool IsEmpty => count == 0;
//   public int Size => count;
// }

// class Program
// {
//   static void Main()
//   {
//     var stackLinked = new LinkedStack<int>();
//     stackLinked.Push(1);
//     stackLinked.Push(2);
//     stackLinked.Push(3);

//     stackLinked.PrintAll();
//   }
// }

// public static class ParenthesesChecker
// {

//   public static bool IsValid(string s)
//   {
//     if (s == null) return false;
//     var stack = new Stack<char>();

//     foreach (var ch in s)
//     {
//       if (ch == '(' || ch == '{' || ch == '[')
//       {
//         stack.Push(ch);
//       }
//       else if (ch == ']' || ch == '}' || ch == ')')
//       {
//         if (stack.Count == 0) return false;
//         var top = stack.Pop();

//         if (!Matches(top, ch)) return false;
//       }
//     }
//     return stack.Count == 0;
//   }

//   public static bool Matches(char open, char close)
//   {
//     return (open == '(' && close == ')') || (open == '{' && close == '}') || (open == '[' && close == ']');
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var input = "([]]";
//     Console.WriteLine(ParenthesesChecker.IsValid(input));
//   }
// }


// public class MinStack
// {
//   private Stack<int> minStack;
//   private Stack<int> mainStack;

//   public MinStack()
//   {
//     minStack = new Stack<int>();
//     mainStack = new Stack<int>();
//   }

//   public void Push(int x)
//   {
//     mainStack.Push(x);

//     if (minStack.Count == 0 || x <= minStack.Peek())
//     {
//       minStack.Push(x);
//     }
//   }

//   public void Pop()
//   {
//     if (mainStack.Count == 0) throw new InvalidOperationException();

//     var removed = mainStack.Pop();
//     if (removed == minStack.Peek())
//     {
//       minStack.Pop();
//     }
//   }

//   public int Top()
//   {
//     if (mainStack.Count == 0) throw new InvalidOperationException();
//     return mainStack.Peek();
//   }

//   public int GetMin()
//   {
//     if (minStack.Count == 0) throw new InvalidOperationException();

//     return minStack.Peek();
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var st = new MinStack();

//     st.Push(1);
//     st.Push(2);
//     st.Push(3);
//     st.Push(0);

//     Console.WriteLine(st.GetMin());
//   }
// }

// public static class Solution
// {
//   public static string RemoveDuplicates(string s)
//   {
//     var st = new Stack<char>();

//     foreach (var ch in s)
//     {
//       if (st.Count > 0 && st.Peek() == ch)
//       {
//         st.Pop();
//       }
//       else
//       {
//         st.Push(ch);
//       }
//     }

//     char[] result = st.ToArray();
//     Array.Reverse(result);
//     return new string(result);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine(Solution.RemoveDuplicates("azxxzy"));
//   }
// }

// public static class Solution
// {
//   public static int EvalRPN(string[] tokens)
//   {
//     var st = new Stack<int>();

//     foreach (var token in tokens)
//     {
//       if (token == "+" || token == "*" || token == "/" || token == "-")
//       {
//         int b = st.Pop();
//         int a = st.Pop();

//         switch (token)
//         {
//           case "+": st.Push(a + b); break;
//           case "-": st.Push(a - b); break;
//           case "*": st.Push(a * b); break;
//           case "/": st.Push(a / b); break;
//         }
//       }
//       else
//       {
//         st.Push(int.Parse(token));
//       }
//     }
//     return st.Pop();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     string[] arr = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"];
//     Console.WriteLine(Solution.EvalRPN(arr));
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string sentence = "Salom Duyo";
//     string word = "";
//     string result = "";

//     for (int i = 0; i < sentence.Length; i++)
//     {
//       char currentChar = sentence[i];

//       if (currentChar != ' ') word = currentChar + word;

//       else
//       {
//         if (result.Length > 0)
//         {
//           result += ' ';
//         }
//         result += word;
//         word = "";
//       }
//     }

//     if (word.Length > 0)
//     {
//       if (result.Length > 0)
//       {
//         result += ' ';
//       }
//       result += word;
//     }

//     Console.WriteLine(result);
//   }
// }

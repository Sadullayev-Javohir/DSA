// Day 14: 🏆 WEEKLY PROJECT 2 — "Stack and Queue Implementation"

//     Vazifa: Kodingizda Stack va Queue ni array dan foydalanib o'zingiz yarating (C# Collections sinflaridan foydalanmang).


// class Stack
// {
//   int[] data;
//   int tail;

//   public Stack()
//   {
//     data = new int[] { };
//     tail = 0;
//   }
// }

using System.Data.Common;

Queue q = new Queue(4);
q.Enqueue(0);
q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);
q.Dequeue();
q.Dequeue();
q.Dequeue();
q.Dequeue();
q.Print();

// QUEUE
class Queue
{
  public int[]? data;
  int count;

  public Queue(int capacity)
  {
    data = new int[capacity];
    count = 0;
  }

  public void Enqueue(int value)
  {
    if (count == data!.Length)
    {
      Resize();
    }

    data[count++] = value;
  }
  private void Minimize()
  {
    int newCapacity = data!.Length / 2;

    if (newCapacity < 4) newCapacity = 4;

    int[] newData = new int[newCapacity];
    for (int i = 0; i < count; i++)
    {
      newData[i] = data![i];
    }
    data = newData;
  }
  public int Dequeue()
  {
    if (count > 0 && count <= data!.Length / 4)
    {
      Minimize();
    }
    int removed = data![0];
    for (int i = 0; i < count - 1; i++)
    {
      data[i] = data[i + 1];
    }
    count--;
    data[count] = 0;
    return removed;
  }

  private void Resize()
  {
    int[] newData = new int[data!.Length * 2];

    if (data != null)
    {
      for (int i = 0; i < data.Length; i++)
      {
        newData[i] = data[i];
      }
      data = newData;
    }
  }

  public void Print()
  {
    if (count != 0)
    {
      for (int i = 0; i < data!.Length; i++) Console.Write(data![i] + ", ");
    }
    else
    {
      Console.WriteLine("Array bo'sh");
    }
  }
}

// Array

// using System.Data.Common;

class Array
{
  private int capacity;
  private int[]? data;
  private int count;

  public Array(int capacity)
  {
    this.capacity = capacity;
    data = new int[capacity];
    count = 0;
  }

  public void Add(int value)
  {
    if (data!.Length == count)
    {
      Resize();
    }
      data?[count++] = value;
  }

  public void Remove(int index)
  {
    // int[] newData = new int[count];
    // if (data != null)
    // {
    //   for (int i = 0; i < index; i++)
    //   {
    //     newData[i] = data[i];
    //   }
    //   for (int i = index + 1; i < count; i++)
    //   {
    //     newData[i - 1] = data[i];
    //   }
    //   data = newData;
    //   count--;
    // }

    if (index < 0 || index >= count) throw new IndexOutOfRangeException();

    for (int i = index; i < count - 1; i++)
    {
      data![i] = data[i + 1];
    }
    count--;
  }

  private void Resize()
  {
    int[] newData = new int[data!.Length * 2];

    if (data != null)
    {
      for (int i = 0; i < data.Length; i++)
      {
        newData[i] = data[i];
      }
      data = newData;
    }
  }

  public void Clear()
  {
    data = new int[capacity];
    count = 0;
  }

  public void Print()
  {
    if (count != 0)
    {
      for (int i = 0; i < count; i++) Console.WriteLine(data![i]);
    }
    else
    {
      Console.WriteLine("Array bo'sh");
    }
  }

  public int Count() => count;

  public int IndexOf(int index)
  {
    int i = 0;
    while (i < count)
    {
      if (data![index] == data[i]) return data[i];
      i++;
    }
    return -1;
  }

  public void Reverse()
  {
    int left = 0, right = count - 1;

    while (left <= right)
    {
      // var temp = data[left];
      // data[left] = data[right];
      // data[right] = temp;
      (data![left], data[right]) = (data[right], data[left]);
      left++; right--;
    }
  }
}

public class Program1
{
  static void Main()
  {
    Array arr = new Array(4);
    arr.Add(1);
    arr.Add(2);
    arr.Add(3);
    arr.Add(4);
    arr.Add(5);
    // arr.Remove(0);
    // arr.Clear();
    arr.Reverse();
    arr.Print();
    // Console.WriteLine(arr.IndexOf(2));
    // Console.WriteLine(arr.Count());
  }
}



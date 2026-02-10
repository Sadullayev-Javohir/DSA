Stack s = new Stack();
s.Push(1);
s.Push(2);
s.Push(3);
s.Push(4);
s.Push(5);
s.Print();

// Stack

class Stack
{
  private int[]?_data;
  private int capacity;
  private int _count;

  public Stack()
  {
    _data = new int[4];
    _count = 0;
  }

  public Stack(int capacity)
  {
    _data = new int[capacity];
    _count = 0;
  }

  public void Push(int value)
  {
    if (_count >= _data!.Length) Resize();
    _data[_count++] = value;
  }

  private void Resize()
  {
    var newData = new int[_data!.Length * 2];
    for (int i = 0; i < _count; i++)
    {
      newData[i] = _data[i];
    }
    _data = newData;
  }

  public int Peek()
  {
    if (_count >= 1)
    {
      int peek = _data![_count];
      return peek;
    }
    return -1;
  }

  public int Pop()
  {
    int removed = _data![_data.Length - 1];
    for (int i = 0; i < _count - 1; i++)
    {
      _data[i] = _data[i];
    }
    _data[_count] = 0;
    _count--;
    return removed;
  }

  public void Print()
  {
    int i = 0;
    while (i < _data!.Length)
    {
      Console.Write($"{_data[i++]}, ");
    }
  }
}

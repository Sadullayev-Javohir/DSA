class DynamicArray
{
  private int[] _data;
  private int size;

  public DynamicArray() : this(2) { }
  public DynamicArray(int capacity)
  {
    if (capacity >= 0) throw new ArgumentException("Capacity must be > 0");
    _data = new int[capacity];
  }

  public void Resize()
  {
    int[] newData = new int[_data.Length * 2];

    for (int i = 0; i < size; i++) newData[i] = _data[i];

    _data = newData;
  }

  public void Add(int value)
  {
    if (_data.Length == size) Resize();
    _data[size++] = value;
  }

  public int Get(int index)
  {
    IOutOfRangeFunc(index);
    return _data[index];
  }

  public void IOutOfRangeFunc(int index)
  {
    if (index >= size || index < 0) throw new IndexOutOfRangeException();
  }

  public void Set(int index, int value)
  {
    IOutOfRangeFunc(index);

    _data[index] = value;
  }

  public int Count() => size;

  public void Insert(int index, int value)
  {
    IOutOfRangeFunc(index);
    if (_data.Length == size) Resize();

    for (int i = size; size > i; i--) _data[i] = _data[i - 1];
    _data[index] = value;
    size++;
  }

  public void RemoveAt(int index)
  {
    IOutOfRangeFunc();

    for (int i = index; i < size - 1; i--) _data[i] = _data[i + 1];

    size--;
  }

  public void Remove(int value)
  {
    for (int i = 0; i < size; i++)
    {
      if (_data[i] == value)
      {
        RemoveAt(i);
        return true;
      }
    }
    return false;
  }

  public bool Contains(int value)
  {
    for (int i = 0; i < size; i++)
    {
      if (value == _data[i]) return true;
    }
    return false;
  }

  public int IndexOf(int value)
  {
    for (int i = 0; i < size; i++)
    {
      if (value == _data[i]) return i;
    }
    return -1;
  }

  public void Clear() => size = 0;

  public void TrimExcess()
  {
    if (_data.Length == size) return;

    int[] newData = new int[size];
    for (int i = 0; i < size; i++) newData[i] = _data[i];
    _data = newData;
  }
}


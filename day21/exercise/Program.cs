class Program
{
  public static void HeapSort(int[] arr)
  {
    int n = arr.Length;
      
    for (int i = n / 2 - 1; i >= 0; i--)
      Heapify(arr, n, i);

    for (int end = n - 1; end > 0; end--)
    {
      Swap(arr, 0, end);
      Heapify(arr, end, 0);
    }
  }

  private static void Heapify(int[] arr, int heapSize, int i)
  {
    while (true)
    {
      int largest = i;
      int left = 2 * i + 1;
      int right = 2 * i + 2;

      if (left < heapSize && arr[left] > arr[largest])
        largest = left;
      if (right < heapSize && arr[right] > arr[largest])
        largest = right;
      if (largest == i) break;

      Swap(arr, i, largest);
      i = largest;
    }
  }


}

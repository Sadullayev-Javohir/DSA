// class Program
// {
//   static void BubbleSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 1) return;

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//       for (int j = 0; j < arr.Length - i - 1; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           Swap(arr, j, j + 1);
//         }
//       }
//     }
//   }

//   static void Swap(int[] arr, int j1, int j2)
//   {
//     int t = arr[j1];
//     arr[j1] = arr[j2];
//     arr[j2] = t;
//   }

//   static void Main()
//   {
//     int[] arr = { 6, 2, 7, 3 };
//     BubbleSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }


// class Program
// {
//   static void InsertionSort(int[] arr)
//   {
//     for (int i = 1; i < arr.Length; i++)
//     {
//       int j = i - 1;
//       int key = i;
//       while (j >= 0 && arr[j] > key)
//       {
//         arr[j + 1] = arr[j];
//         j--;
//       }
//       arr[j + 1] = key;
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 5, 2, 7, 3 };
//     InsertionSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }


// class Program
// {
//   static void SelectionSort(int[] arr)
//   {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//       int min = i;

//       for (int j = i + 1; j < arr.Length; j++)
//       {
//         if (arr[min] > arr[j]) min = j;
//       }

//       if (i != min) Swap(arr, min, i);
//     }
//   }

//   static void Swap(int[] arr, int min, int i)
//   {
//     int t = arr[min];
//     arr[min] = arr[i];
//     arr[i] = t;
//   }

//   static void Main()
//   {
//     int[] arr = { 5, 2, 6, 3 };
//     SelectionSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }


// class Program
// {
//   static void MergeSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 1) return;

//     MergeSort(arr, 0, arr.Length - 1);
//   }

//   private static void MergeSort(int[] arr, int left, int right)
//   {
//     if (left < right)
//     {
//       int mid = left + (right - left) / 2;

//       MergeSort(arr, left, mid);

//       MergeSort(arr, mid + 1, right);

//       Merge(arr, left, mid, right);
//     }
//   }

//   private static void Merge(int[] arr, int left, int mid, int right)
//   {
//     int n1 = mid - left + 1;
//     int n2 = right - mid;

//     int[] L = new int[n1], R = new int[n2];

//     for (int i = 0; i < n1; i++) L[i] = arr[left + i];
//     for (int j = 0; j < n2; j++) R[j] = arr[mid + 1 + j];

//     int iIndex = 0, jIndex = 0, k = left;

//     while (iIndex < n1 && jIndex < n2)
//     {
//       if (L[iIndex] <= R[jIndex])
//       {
//         arr[k] = L[iIndex];
//         iIndex++;
//       }
//       else
//       {
//         arr[k] = R[jIndex];
//         jIndex++;
//       }
//       k++;
//     }

//     while (iIndex < n1)
//     {
//       arr[k] = L[iIndex];
//       iIndex++;
//       k++;
//     }

//     while (jIndex < n2)
//     {
//       arr[k] = R[jIndex];
//       jIndex++;
//       k++;
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 5, 2, 7, 3 };
//     MergeSort(arr);
//     Console.WriteLine(string.Join(", ", arr));


// class Program
// {
//   static void QuickSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 1) return;

//     QuickSort(arr, 0, arr.Length - 1);
//   }

//   private static void QuickSort(int[] arr, int left, int right)
//   {
//     if (left < right)
//     {
//       int pivotIndex = Partition(arr, left, right);

//       QuickSort(arr, left, pivotIndex - 1);
//       QuickSort(arr, pivotIndex + 1, right);
//     }
//   }

//   private static int Partition(int[] arr, int left, int right)
//   {
//     int i = left - 1, pivot = arr[right];

//     for (int j = 0; j < right; j++)
//     {
//       if (arr[j] <= pivot)
//       {
//         i++;
//         Swap(arr, i, j);
//       }
//     }

//     Swap(arr, i + 1, right);

//     return i + 1;
//   }

//   static void Swap(int[] arr, int i, int j)
//   {
//     int t = arr[i];
//     arr[i] = arr[j];
//     arr[j] = t;
//   }

//   static void Main()
//   {
//     int[] arr = { 2, 1, 7, 4 };
//     QuickSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

class Program
{
  static void HeapSort(int[] arr)
  {
    if (arr == null || arr.Length <= 1) return;

    int n = arr.Length;

    for (int i = n / 2 - 1; i >= 0; i--) Heapify(arr, n, i);

    for (int i = n - 1; i > 0; i--)
    {
      Swap(arr, 0, i);
      Heapify(arr, i, 0);
    }
  }

  static void Heapify(int[] arr, int n, int i)
  {
    int largest = i;

    int left = 2 * i + 1, right = 2 * i + 2;

    if (left < n && arr[left] > arr[largest]) largest = left;

    if (right < n && arr[right] > arr[largest]) largest = right;

    if (largest != i)
    {
      Swap(arr, i, largest);
      Heapify(arr, n, largest);
    }
  }

  static void Swap(int[] arr, int i, int j)
  {
    int t = arr[i];
    arr[i] = arr[j];
    arr[j] = t;
  }

  static void Main()
  {
    int[] arr = { 2, 8, 3, 5, 1 };
    HeapSort(arr);
    Console.WriteLine(string.Join(", ", arr));
  }
}

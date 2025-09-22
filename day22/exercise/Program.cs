// class Program
// {
//   static void BubbleSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 0) return;

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//       for (int j = 0; j < arr.Length - i - 1; j++)
//       {
//         if (arr[j] > arr[j + 1]) Swap(arr, j, j + 1);
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
//     int[] arr = { 6, 2, 7, 3, 8 };
//     BubbleSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// class Program
// {
//   static void InsertionSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 1) return;

//     for (int i = 1; i < arr.Length; i++)
//     {
//       int key = arr[i];
//       int j = i - 1;

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
//     int[] arr = { 6, 3, 7, 2 };
//     InsertionSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }


// class Program
// {
//   static void SelectionSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 1) return;

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//       int minIndex = i;

//       for (int j = i + 1; j < arr.Length; j++)
//       {
//         if (arr[minIndex] > arr[j]) minIndex = j;
//       }

//       if (minIndex != i)
//       {
//         int t = arr[i];
//         arr[i] = arr[minIndex];
//         arr[minIndex] = t;
//       }
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 6, 2, 7, 4 };
//     SelectionSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

class Program
{
  static void MergeSort(int[] arr)
  {
    if (arr == null || arr.Length <= 1) return;

    MergeSort(arr, 0, arr.Length - 1);
  }

  private static void MergeSort(int[] arr, int left, int right)
  {
    if (left < right)
    {
      int mid = left + (right - left) / 2;

      MergeSort(arr, left, mid);

      MergeSort(arr, mid + 1, right);

      Merge(arr, left, mid, right);
    }
  }

  private static void Merge(int[] arr, int left, int mid, int right)
  {
    int n1 = mid - left + 1;
    int n2 = right - mid;

    int[] L = new int[n1], R = new int[n2];

    for (int i = 0; i < n1; i++) L[i] = arr[left + i];
    for (int j = 0; j < n2; j++) R[j] = arr[mid + j + 1];

    int iIndex = 0, jIindex = 0, k = left;

    while (iIndex < n1 && jIindex < n2)
    {
      if (L[iIndex] <= R[jIindex])
      {
        arr[k] = L[iIndex];
        iIndex++;
      }
      else
      {
        arr[k] = R[jIindex];
        jIindex++;
      }
      k++;
    }

    while (iIndex < n1)
    {
      arr[k] = L[iIndex];
      iIndex++;
      k++;
    }

    while (jIindex < n2)
    {
      arr[k] = R[jIindex];
      jIindex++;
      k++;
    }
  }
}
//   static void Main()
//   {
//     int[] arr = { 5, 2, 7, 3 };
//     MergeSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

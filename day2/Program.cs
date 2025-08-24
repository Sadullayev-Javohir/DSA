using System;

// class Program1
// {
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5 };
//     int i = 0, j = arr.Length - 1;

//     while (i < j)
//     {
//       int temp = arr[i];
//       arr[i] = arr[j];
//       arr[j] = temp;

//       i++;
//       j--;
//     }

//     Console.WriteLine(string.Join(",", arr));
//   }
// }

// class Program2
// {
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5 };
//     int[] reversed = new int[arr.Length];

//     for (int i = 0; i < arr.Length; i++)
//     {
//       reversed[i] = arr[arr.Length - 1 - i];
//     }

//     Console.WriteLine(string.Join(",", reversed));
//   }
// }

// class Program3
// {
//   static int LinearSearch(int[] arr, int target)
//   {
//     for (int i = 0; i < arr.Length; i++) if (arr[i] == target) return i;
//     return -1;
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5 };
//     Console.WriteLine(LinearSearch(arr, 5) + "-indexda 5 topildi");
//   }
// }


// class Program4
// {
//   static int BinarySearch(int[] arr, int target)
//   {
//     int low = 0, high = arr.Length - 1;
//     while (low <= high)
//     {
//       int mid = low + (high - low) / 2;
//       if (arr[mid] == target) return mid;
//       if (arr[mid] < target) low = mid + 1;
//       else high = mid - 1;
//     }
//     return -1;
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5, 6 };
//     Console.WriteLine("6 soni " + BinarySearch(arr, 6) + "-index da topildi");
//   }
// }

// class Program5
// {
//   static int[] Copy(int[] arr)
//   {
//     int[] b = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//       b[i] = arr[i];
//     }
//     return b;
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5, 6 };
//     int[] newarr = Copy(arr);
//     Console.WriteLine(string.Join(",", newarr));
//   }
// }

// class Program6
// {
//   static int Fibonachi(int n)
//   {
//     if (n <= 1) return n;
//     return Fibonachi(n - 1) + Fibonachi(n - 2);
//   }
//   static void Main()
//   {
//     Console.WriteLine(Fibonachi(10));
//   }
// }

class Program7
{
  static void SelectionSort(int[] arr)
  {
    if (arr == null) return;
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
      int minIndex = i;

      for (int j = i + 1; j < n; j++)
      {
        if (arr[j] < arr[minIndex]) minIndex = j;
      }

      int temp = arr[i];
      arr[i] = arr[minIndex];
      arr[minIndex] = temp;
    }
  }
  static void Main()
  {
    int[] arr = { 11, 6, 3, 1, 8, 2 };
    SelectionSort(arr);
    Console.WriteLine(string.Join(",", arr));
  }
}


class Program8
{

  static void BubbleSort(int[] arr)
  {
    if (arr == null) return;
    int n = arr.Length;

    for (int i = 0; i < n - 1; i++)
    {
      for (int j = 0; j < n - i - 1; j++)
      {
        if (arr[j] > arr[j + 1])
        {
          int temp = arr[j];
          arr[j] = arr[j + 1];
          arr[j + 1] = temp;
        }
      }
    }
  }

  static void Main()
  {
    int[] arr = new int[] { 5, 3, 8, 4, 2 };
    BubbleSort(arr);
    Console.WriteLine(string.Join(",", arr));
  }
}

class Program9
{
  static void InsertionSort(int[] arr)
  {
    if (arr == null) return;
    int n = arr.Length;

    for (int i = 1; i < n; i++)
    {
      int key = arr[i];
      int j = i - 1;

      while (j >= 0 && arr[j] > key)
      {
        arr[j + 1] = arr[j];
        j--;
      }
      arr[j + 1] = key;
    }

  }
  static void Main()
  {
    int[]? arr = { 5, 3, 8, 4, 2 };
    InsertionSort(arr);
    Console.WriteLine(string.Join(",", arr));
  }
}

// Linear Search, Binary Search, Selection Sort, Bubble Sort, Insertion Sort

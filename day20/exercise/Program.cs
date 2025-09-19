// static class QuickSorter
// {
//   public static void QuickSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 1) return;

//     QuickSort(arr, 0, arr.Length - 1);
//   }

//   private static void QuickSort(int[] arr, int low, int high)
//   {
//     if (low < high)
//     {
//       int p = Partition(arr, low, high);
//       QuickSort(arr, low, p - 1);
//       QuickSort(arr, p + 1, high);
//     }
//   }

//   private static int Partition(int[] arr, int low, int high)
//   {
//     int i = low, pivot = arr[high];

//     for (int j = low; j < high; j++)
//     {
//       if (arr[j] < pivot)
//       {
//         Swap(arr, i, j);
//         i++;
//       }
//     }
//     Swap(arr, i, high);
//     return i;
//   }

//   private static void Swap(int[] arr, int i, int j)
//   {
//     int t = arr[i];
//     arr[i] = arr[j];
//     arr[j] = t;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int[] arr = { 7, 2, 54, 8, 4 };
//     QuickSorter.QuickSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// public class Solution
// {
//   public int FindKthLargest(int[] nums, int k)
//   {
//     int n = nums.Length;

//     int targetIndex = n - k;

//     int low = 0, high = n - 1;

//     while (low <= high)
//     {
//       int pivotIndex = Partition(nums, low, high);

//       if (pivotIndex == targetIndex) return nums[pivotIndex];
//       else if (pivotIndex < targetIndex) low = pivotIndex + 1;
//       else high = pivotIndex - 1;
//     }
//     return -1;
//   }

//   private int Partition(int[] a, int low, int high)
//   {
//     int pivot = a[high];
//     int i = low;

//     for (int j = low; j < high; j++)
//     {
//       if (a[j] <= pivot)
//       {
//         int t = a[i];
//         a[i] = a[j];
//         a[j] = t;

//         i++;
//       }
//     }

//     int temp = a[i];
//     a[i] = a[high];
//     a[high] = temp;

//     return i;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int[] arr = { 15, 7, 2, 8, 3 };
//     var solution = new Solution();
//     int result = solution.FindKthLargest(arr, 2);
//     Console.WriteLine(result);
//   }
// }

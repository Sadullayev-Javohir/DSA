// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 6, 2, 1, 7, 4 };
//         MergeSort(arr, 0, arr.Length - 1);
//         
//         Console.WriteLine(string.Join(", ", arr));
//     }
//
//     // static void MergeSort(int[] arr)
//     // {
//     //     int left = 0, right = arr.Length - 1;
//     //     MergeSort(arr, left, right);
//     // }
//
//     static void MergeSort(int[] arr, int left, int right)
//     {
//         if (left >= right) return;
//
//         int mid = (left + right) / 2;
//         
//         MergeSort(arr, left, right: mid);
//         MergeSort(arr, mid + 1, right);
//
//         Merge(arr, left, mid, right);
//     }
//
//     static void Merge(int[] arr, int left, int mid, int right)
//     {
//         int n1 = mid - left + 1;
//         int n2 = right - mid;
//
//         int[] L = new int[n1], R = new int[n2];
//
//         int i = 0, j = 0, k = left;
//         
//         Array.Copy(arr, left, L, 0, n1);
//         Array.Copy(arr, mid + 1, R, 0, n2);
//
//         while (i < n1 && j < n2)
//         {
//             if (L[i] <= R[j]) arr[k++] = L[i++];
//             else arr[k++] = R[j++];
//         }
//         
//         while (i < n1) arr[k++] = L[i++];
//         while (j < n2) arr[k++] = R[j++];
//
//     }
// }

using System.Collections.Concurrent;
//
// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 6, 2, 3, 1, 7 };
//         QuickSort(arr);
//         Console.WriteLine(string.Join(", ", arr));
//     }
//     static void QuickSort(int[] arr)
//     {
//         int left = 0, right = arr.Length - 1;
//         QuickSort(arr, left, right);
//     }
//
//     private static void QuickSort(int[] arr, int left, int right)
//     {
//         if (left >= right) return;
//
//         int pivot = arr[(left + right) / 2];
//         int index = Partition(arr, left, right, pivot);
//         
//         QuickSort(arr, left, index - 1);
//         QuickSort(arr, index, right);
//     }
//
//     static int Partition(int[] arr, int left, int right, int pivot)
//     {
//         while (left <= right)
//         {
//             while (arr[left] < pivot) left++;
//             while (arr[right] > pivot) right--;
//
//             if (left <= right)
//             {
//                 (arr[left], arr[right]) = (arr[right], arr[left]);
//                 left++;
//                 right--;
//             }
//         }
//
//         return left;
//     }
// }

class Program
{
    static void Main()
    {
        int[] arr = { 4, 9, 1, 0, 3 };
        int target = 3;

        int index = LinearSearch(arr, target);

        Console.WriteLine((index != -1) ? "Topildi" : "Topilmadi");
    }
    
    // Simple Version
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }

        return -1;
    }
}

// class Program
// {
//         static void Main()
//         {
//             int[] arr = { 4, 9, 1, 0, 3 };
//             int target = 3;
//
//             int index = SentinelLinearSearch(arr, target);
//
//             Console.WriteLine((index != -1) ? "Topildi" : "Topilmadi");
//         }
//
//         // Sentinel Technique
//         static int SentinelLinearSearch(int[] arr, int target)
//         {
//             int n = arr.Length;
//             int last = arr[n - 1];
//             int i = 0;
//
//             while (arr[i] != target) i++;
//             arr[n - 1] = last;
//
//             if (i < n - 1 || last == target) return i;
//             return - 1;
//         }
// }
using System.Collections;
using System.Reflection.Metadata.Ecma335;

// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 5, 2, 7, 1 };
//         HeapSort(arr);
//         Console.WriteLine(string.Join(", ", arr));
//     }
//
//     static void HeapSort(int[] arr)
//     {
//         int n = arr.Length;
//
//         for (int i = n / 2 - 1; i >= 0; i--) Heapify(arr, n, i);
//
//         for (int i = n - 1; i >= 0; i--)
//         {
//             (arr[0], arr[i]) = (arr[i], arr[0]);
//             Heapify(arr, i, 0);
//         }
//     }
//
//     static void Heapify(int[] arr, int n, int i)
//     {
//         int left = 2 * i + 1, right = 2 * i + 2;
//         int largest = i;
//
//         if (left < n && arr[left] > arr[largest]) largest = left;
//         if (right < n && arr[right] > arr[largest]) largest = right;
//
//         if (largest != i)
//         {
//             (arr[largest], arr[i]) = (arr[i], arr[largest]);
//             Heapify(arr, n, largest);
//         }
//
//     }
//         
//     static void InsertionSort(int[] arr)
//     {
//         int n = arr.Length;
//
//         for (int i = 1; i < n; i++)
//         {
//             int key = arr[i];
//             int j = i - 1;
//             while (j >= 0 && arr[j] > key)
//             {
//                 arr[j + 1] = arr[j];
//                 j--;
//             }
//
//             arr[j + 1] = key;
//         }
//     }
//     
//     static void SelectionSort(int[] arr)
//     {
//         for (int i = 0; i < arr.Length - 1; i++)
//         {
//             int min = i;
//             for (int j = i + 1; j < arr.Length; j++)
//             {
//                 if (arr[min] > arr[j]) min = j;
//             }
//
//             if (arr[i] != arr[min]) (arr[i], arr[min]) = (arr[min], arr[i]);
//         }
//     }
// }

class Program
{
    static void Main()
    {
        int[][] intervals = new int[][]
        {
            new int[] { 15, 19 },
            new int[] { 1, 3 },
            new int[] { 8, 10 },
            new int[] { 2, 6 },
        };

        var result = Merge(intervals);

        foreach (var interval in result)
        {
            Console.WriteLine($"[{interval[0]},{interval[1]}] ");
        }
    }

    static List<int[]> Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var merged = new List<int[]>();


        merged.Add(intervals[0]);
        foreach (var curr in intervals)
        {
            var last = merged[merged.Count - 1];

            if (curr[0] <= last[1]) last[1] = Math.Max(last[1], curr[1]);
            else
            {
                merged.Add(curr);
            }
        }
        return merged;
    }
}
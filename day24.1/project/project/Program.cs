// using System.Collections;
//
// class Program
// {
//     static void InsertionSort(int[] arr)
//     {
//         for (int i = 1; i < arr.Length; i++)
//         {
//             int key = arr[i];
//             int j = i - 1;
//
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
//     static void BinaryInsertionSort(int[] arr)
//     {
//         for (int i = 1; i < arr.Length; i++)
//         {
//             int key = arr[i], left = 0, right = i - 1;
//
//             while (left <= right)
//             {
//                 int mid = (left + right) / 2;
//                 if (arr[mid] > key) right = mid - 1;
//                 else left = mid + 1;
//             }
//
//             for (int j = i - 1; j >= left; j--) arr[j + 1] = arr[j];
//             arr[left] = key;
//         }
//     }
//
//     static void SentinelInsertionSort(int[] arr)
//     {
//         int minIndex = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[minIndex] > arr[i]) minIndex = i;
//         }
//
//         (arr[0], arr[minIndex]) = (arr[minIndex], arr[0]);
//
//         for (int i = 1; i < arr.Length; i++)
//         {
//             int key = arr[i];
//             int j = i - 1;
//
//             while (arr[j] > key)
//             {
//                 arr[j + 1] = arr[j];
//                 j--;
//             }
//
//             arr[j + 1] = key;
//         }
//     }
//
//     static void Main()
//     {
//         int[] arr = new[] { 100, 24, 83, 46 };
//         SentinelInsertionSort(arr);
//         foreach (var i in arr)
//         {
//             Console.WriteLine(i);    
//         }
//     }
// }

class Program
{
    // Selection Sort
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[minIdx] > arr[j]) minIdx = j;
            }

            (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
            // int temp = arr[i];
            // arr[i] = arr[minIdx]; 
            // arr[minIdx] = temp;
        }
    }

    // SelectionSortNotNeedSwap
    static void SelectionSort_NoRedunantSwap(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIdx = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[minIdx] > arr[j]) minIdx = j;
            }

            if (minIdx != i) (arr[minIdx], arr[i]) = (arr[i], arr[minIdx]);
        }
    }

    // Early Exit
    static void SelectionSortEarlyExit(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            bool alreadySortedSuffix = true;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[minIdx] > arr[j]) minIdx = j;
                if (arr[j] > arr[j - 1]) alreadySortedSuffix = false;
            }

            if (alreadySortedSuffix && minIdx == i) break;
            if (minIdx != i) (arr[i], arr[minIdx]) = (arr[minIdx], arr[i]);
        }
    }
    
    // Double Check
    static void DoubleSelectionSort(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int minIdx = left, maxIdx = left;
            for (int j = left; j <= right; j++)
            {
                minIdx = (arr[j] < arr[minIdx]) ? j : minIdx;
                maxIdx = (arr[j] > arr[maxIdx]) ? j : maxIdx;
            }

            if (minIdx != left)
            {
                (arr[left], arr[minIdx]) = (arr[minIdx], arr[left]);
                maxIdx = (maxIdx == left) ? minIdx : maxIdx;
            }

            if (maxIdx != right)
            {
                (arr[right], arr[maxIdx]) = (arr[maxIdx], arr[right]);
            }

            left++;
            right--;
        }
    }
    
    // Stable Optimization
    static void StableSelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[minIdx] > arr[j]) minIdx = j;
            }

            int key = arr[minIdx];

            while (minIdx > i)
            {
                arr[minIdx] = arr[minIdx - 1];
                minIdx--;
            }

            arr[i] = key;
        }
    }
    
    static void Main()
    {
        int[] arr = { 6, 2, 3, 1 };
        DoubleSelectionSort(arr);
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
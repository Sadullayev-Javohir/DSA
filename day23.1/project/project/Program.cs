// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 2, 7, 3, 6 };
//         CocktailShaker(arr);
//         foreach (int i in arr)
//         {
//             Console.WriteLine(i);
//         }
//     }
//     static void EarlyExit(int[] arr)
//     {
//         int n = arr.Length - 1;
//         for (int i = 0; i < n; i++)
//         {
//             bool swapped = false;
//             for (int j = 0; j < n - i; j++)
//             {
//                 if (arr[j] > arr[j + 1])
//                 {
//                     (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
//                     swapped = true;
//                 }
//             }
//
//             if (!swapped) break;
//         }
//     }
//
//     static void LastSwap(int[] arr)
//     {
//         int n = arr.Length - 1;
//
//         while (n > 0)
//         {
//             int lastSwap = 0;
//             for (int i = 0; i < n; i++)
//             {
//                 if (arr[i] > arr[i + 1])
//                 {
//                     (arr[i],  arr[i + 1]) = (arr[i + 1], arr[i]);
//                     lastSwap = i + 1;
//                 }
//             }
//             n = lastSwap;
//
//             if (n == 0) break;
//         }
//     }
//
//     static void CocktailShaker(int[] arr)
//     {
//         bool swapped = true;
//         int left = 0,  right = arr.Length - 1;
//
//         while (swapped)
//         {
//             swapped = false;
//             for (int i = left; i < right; i++)
//             {
//                 if (arr[i] > arr[i + 1])
//                 {
//                     (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
//                     swapped = true;
//                 }
//             }
//
//             right--;
//             if (!swapped) break;
//
//             swapped = false;
//             for (int i = right; i > left; i--)
//             {
//                 if (arr[i] < arr[i - 1])
//                 {
//                     (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
//                     swapped = true;
//                 }
//             }
//
//             left++;
//         }
//     }
// }

// Insertion Sort

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 3, 1 };
        InsertionSortWithSentinel(arr);
        foreach (var i in arr)
        {
            Console.Write(i + ", ");
        }
    }
    
    // Insertion Sort
    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
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
    
    // BinaryInsertionSort
    static void BinaryInsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int left = 0, right = i - 1, key = arr[i];
    
            while (left <= right)
            {
                int mid = (left + right) / 2;
    
                if (arr[mid] > key) right = mid - 1;
                else left = mid + 1;
            }
    
    
            for (int j = i - 1; j >= left; j--) arr[j + 1] = arr[j];
    
            arr[left] = key;
        }
    }
    
    // Sentinel Optimization
    static void InsertionSortWithSentinel(int[] arr)
    {
        int minIndex = 0;
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[minIndex]) minIndex = i;
        }

        (arr[0], arr[minIndex]) = (arr[minIndex], arr[0]);

        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
    
    
} 








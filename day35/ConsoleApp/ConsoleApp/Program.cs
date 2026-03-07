// class Program
// {
//     public static int LengthOfLongestSubstring(string s)
//     {
//         HashSet<char> window = new HashSet<char>();
//         int sum = 0, maxSum = 0;
//         int left = 0;
//
//         for (int right = 0; right < s.Length; right++)
//         {
//             while (window.Contains(s[right])) window.Remove(s[left++]);
//             window.Add(s[right]);
//             sum = right - left + 1;
//
//             maxSum = Math.Max(sum, maxSum);
//         }
//
//         return maxSum;
//     }
//
//     static void Main()
//     {
//         Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
//         Console.WriteLine(LengthOfLongestSubstring("1234567890"));
//         
//         
//     }
// }

using System.Collections.Concurrent;
using System.Diagnostics.Tracing;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(CharacterReplacement("ABAB", 2));
//     }
//     public static int CharacterReplacement(string s, int k)
//     {
//         int left = 0, maxFrequent = 0, maxLength = 0;
//         Dictionary<char, int> window = new Dictionary<char, int>();
//
//         for (int right = 0; right < s.Length; right++)
//         {
//             if (window.ContainsKey(s[right])) window[s[right]]++;
//             else window[s[right]] = 1;
//             
//             maxFrequent = Math.Max(maxFrequent, window[s[right]]);
//            
//
//             while ((right - left + 1) - maxFrequent > k)
//             {
//                 window[s[left]]--;
//                 left++;
//             }
//
//             maxLength = Math.Max(maxLength, right - left + 1);
//         }
//
//         return maxLength;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine(CheckInclusion("ab", "eiaboaoo"));
//     }
//
//     static bool CheckInclusion(string s1, string s2)
//     {
//         int[] s1Count = new int[26];
//         int[] windowCount = new int[26];
//
//         for (int i = 0; i < s1.Length; i++)
//         {
//             s1Count[s1[i] - 'a']++;
//             windowCount[s2[i] - 'a']++;
//         }
//
//         if (IsSame(s1Count, windowCount)) return true;
//
//         for (int right = s1.Length; right < s2.Length; right++)
//         {
//             windowCount[s2[right] - 'a']++;
//             windowCount[s2[right - s1.Length] - 'a']--;
//
//             if (IsSame(s1Count, windowCount)) return true;
//         }
//
//         return false;
//     }
//
//     static bool IsSame(int[] a, int[] b)
//     {
//         for (int i = 0; i < a.Length; i++)
//         {
//             if (a[i] != b[i]) return false;
//         }
//
//         return true;
//     }
// }


class Program
{
    static void Main()
    {
        int[] arr = new int[] { 9, 2, 3, 7, 1, 4 };
        // MergeSort(arr, 0, arr.Length - 1);
        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int pivotIndex = Random.Shared.Next(left, right + 1);
        int pivot = arr[pivotIndex];

        int index = Partition(arr, left, right, pivot);
        
        QuickSort(arr, left, index - 1);
        QuickSort(arr, index, right);
    }

    private static int Partition(int[] arr, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (arr[left] < pivot) left++;
            while (arr[right] > pivot) right--;

            if (left <= right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
        }

        return left;
    }
     

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        
        Merge(arr, left, mid, right);
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1], R = new int[n2];
        
        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (L[i] > R[j]) arr[k++] = R[j++];
            else arr[k++] = L[i++];
        }

        while (i < n1) arr[k++] = L[i++];
        while (j < n2) arr[k++] = R[j++];
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[minIndex] > arr[j]) minIndex = j;
            }

            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }
    }

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

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            Heapify(arr, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int leftChild = 2 * i + 1, rightChild = 2 * i + 2;

        if (leftChild < n && arr[leftChild] > arr[largest]) largest = leftChild;
        if (rightChild < n && arr[rightChild] > arr[largest]) largest = rightChild;

        if (i != largest)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}
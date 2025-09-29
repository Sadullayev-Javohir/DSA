// class Program
// {
//   static void CountingSort(int[] arr)
//   {
//     if (arr == null && arr.Length <= 1) return;

//     int max = arr[0];
//     int n = arr.Length;

//     for (int i = 0; i < n; i++) if (max < arr[i]) max = arr[i];

//     int[] count = new int[max + 1];
//     for (int i = 0; i < n; i++) count[arr[i]]++;

//     for (int i = 1; i < max + 1; i++) count[i] += count[i - 1];

//     int[] output = new int[n];
//     for (int i = n - 1; i >= 0; i--)
//     {
//       output[count[arr[i]] - 1] = arr[i];
//       count[arr[i]]--;
//     }

//     for (int i = 0; i < n; i++) arr[i] = output[i];
//   }
//   static void Main()
//   {
//     int[] arr = { 7, 2, 4, 1 };
//     CountingSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }

// }

// public class Radix
// {
//   public static int[] NonNegative(int[] arr)
//   {
//     int max = arr[0], n = arr.Length;


//     for (int i = 0; i < n; i++) if (max < arr[i]) max = arr[i];

//     int exp = 1;
//     int[] output = new int[n];

//     while (max / exp > 0)
//     {
//       int[] count = new int[10];
//       foreach (var v in arr)
//       {
//         int digit = (v / exp) % 10;
//         count[digit]++;
//       }

//       for (int i = 1; i < 10; i++) count[i] += count[i - 1];

//       for (int i = n - 1; i >= 0; i--)
//       {
//         int digit = (arr[i] / exp) % 10;

//         count[digit]--;
//         output[count[digit]] = arr[i];
//       }

//       for (int i = 0; i < n; i++) arr[i] = output[i];

//       exp *= 10;
//     }
//     return arr;
//   }

//   static int[] Radixsort(int[] arr)
//   {
//     int n = arr.Length;

//     var neg = new List<int>();
//     var pos = new List<int>();

//     foreach (var v in arr)
//     {
//       if (v < 0) neg.Add(-v);
//       else pos.Add(v);
//     }

//     int[] sortedNeg = neg.Count > 0 ? NonNegative(neg.ToArray()) : new int[0];
//     int[] sortedPos = pos.Count > 0 ? NonNegative(pos.ToArray()) : new int[0];

//     int idx = 0;
//     int[] result = new int[n];

//     for (int i = sortedNeg.Length - 1; i >= 0; i--) result[idx++] = sortedNeg[i];

//     for (int i = 0; i < sortedPos.Length; i++)
//     {
//       result[idx++] = sortedPos[i];
//     }

//     return result;
//   }

//   static void Main()
//   {
//     int[] arr = { 6, 2, 3, 1 };
//     arr = Radixsort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }

// }


class Solution
{
  public void Merge(int[] nums1, int m, int[] nums2, int n)
  {
    int p1 = m - 1;
    int p2 = n - 1;
    int p = m + n - 1;

    while (p1 >= 0 && p2 >= 0)
    {
      if (nums1[p1] > nums2[p2])
      {
        nums1[p] = nums1[p1];
        p1--;
      }
      else
      {
        nums1[p] = nums2[p2];
        p2--;
      }
      p--;
    }

    while (p2 >= 0)
    {
      nums1[p] = nums2[p2];
      p2--;
      p--;
    }
  }
}

class Program
{
  static void Main()
  {
    int[] nums1 = { 1, 2, 3, 0, 0, 0 };
    int[] nums2 = { 4, 5, 6 };

    var sol = new Solution();
    int n = 3, m = 3;
    sol.Merge(nums1, m, nums2, m);
    Console.WriteLine(string.Join(", ", nums1));
  }
}

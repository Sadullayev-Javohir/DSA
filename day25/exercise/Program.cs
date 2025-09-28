// class Program
// {
//   static void CountingSort(int[] arr)
//   {
//     int max = arr[0];
//     int n = arr.Length;
//     for (int i = 0; i < n; i++) if (arr[i] > max) max = arr[i];

//     int[] count = new int[max + 1];
//     for (int i = 0; i < n; i++) count[arr[i]]++;

//     for (int i = 1; i <= max; i++) count[i] += count[i - 1];

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
//     int[] arr = { 6, 2, 4, 1 };
//     CountingSort(arr);
//     Console.WriteLine(string.Join(",", arr));
//   }
// }

public static class Radix
{
  public static int[] RadixNonNegative(int[] arr)
  {
    int max = arr[0];
    int n = arr.Length;

    foreach (var v in arr) if (v > max) max = v;

    int exp = 1;
    int[] output = new int[n];

    while (max / exp > 0)
    {
      int[] count = new int[10];
      foreach (var v in arr)
      {
        int digit = (v / exp) % 10;
        count[digit]++;
      }

      for (int i = 1; i < 10; i++) count[i] += count[i - 1];

      for (int i = n - 1; i >= 0; i--)
      {
        int digit = (arr[i] / exp) % 10;
        count[digit]--;
        output[count[digit]] = arr[i];
      }

      for (int i = 0; i < n; i++) arr[i] = output[i];

      exp *= 10;
    }
    return arr;
  }

  public static int[] RadixSort(int[] arr)
  {
    var pos = new List<int>();
    var neg = new List<int>();

    foreach (var v in arr)
    {
      if (v < 0) neg.Add(-v);
      else pos.Add(v);
    }

    int[] sortedPos = pos.Count > 0 ? RadixNonNegative(pos.ToArray()) : new int[0];
    int[] sortedNeg = neg.Count > 0 ? RadixNonNegative(neg.ToArray()) : new int[0];

    int idx = 0;
    int[] result = new int[arr.Length];

    for (int i = sortedNeg.Length - 1; i >= 0; i--) result[idx++] = -sortedNeg[i];
    for (int i = 0; i < sortedPos.Length; i++) result[idx++] = sortedPos[i];

    return result;
  }
}

// class Program
// {
//   static void Main()
//   {
//     int[] arr = { -6, 2, 3, 1 };
//     arr = Radix.RadixSort(arr);
//     Console.WriteLine(string.Join(" ,", arr));
//   }
// }


// public class Solution
// {
//   public int FindKthLargest(int[] arr, int k)
//   {
//     var minHeap = new PriorityQueue<int, int>();

//     foreach (var a in arr)
//     {
//       minHeap.Enqueue(a, a);

//       if (minHeap.Count > k) minHeap.Dequeue();
//     }
//     return minHeap.Dequeue();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int[] arr = { 6, 2, 7, 3 };
//     int k = 2;
//     var sol = new Solution();
//     Console.WriteLine(sol.FindKthLargest(arr, k));
//   }
// }


// public class KthLargest
// {
//   private readonly int k;
//   private readonly PriorityQueue<int, int> minHeap;

//   public KthLargest(int k, int[] arr)
//   {
//     this.k = k;
//     minHeap = new PriorityQueue<int, int>();

//     foreach (var num in arr)
//     {
//       minHeap.Enqueue(num, num);

//       if (minHeap.Count > k) minHeap.Dequeue();
//     }
//   }

//   public int Add(int a)
//   {
//     minHeap.Enqueue(a, a);
//     if (minHeap.Count > k) minHeap.Dequeue();

//     return minHeap.Peek();
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     int k = 2;
//     int[] arr = new int[] { 8, 3, 5, 1 };
//     var kth = new KthLargest(k, arr);
//     Console.WriteLine(kth.Add(2));
//   }
// }

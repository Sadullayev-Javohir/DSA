// class Program
// {
//   static int InterpolationSearch(int[] arr, int k)
//   {
//     int low = 0, high = arr.Length - 1;

//     while (low <= high && arr[low] <= k && k <= arr[high])
//     {
//       if (low == high)
//       {
//         if (arr[low] == k) return low;
//         return -1;
//       }

//       int pos = low + ((k- arr[low]) * (high - low)) / (arr[high] - arr[low]);
//       if (arr[pos] == k) return pos;
//       if (arr[low] < arr[pos]) low = pos + 1;
//       else high = pos - 1;
//     }
//     return -1;
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5 };
//     Console.WriteLine(InterpolationSearch(arr, 4));
//   }
// }

class Program
{
  static int JumpSearch(int[] arr, int k)
  {
    int n = arr.Length;
    if (n == 0) return -1;

    int step = (int)Math.Floor(Math.Sqrt(n));
    int prev = 0;

    while (k < n && arr[Math.Min(step, n) - 1] < k)
    {
      prev = step;
      step += (int)Math.Floor(Math.Sqrt(n));
      if (prev >= n) return -1;
    }

    int end = Math.Min(step, n);
    for (int i = prev; i < end; i++)
    {
      if (arr[i] == k) return i;
      if (arr[i] > k) return -1;
    }
    return -1;
  }

  static void Main()
  {
    int[] arr = { 1, 2, 3, 4, 5 };
    Console.WriteLine(JumpSearch(arr, 2));
  }
}

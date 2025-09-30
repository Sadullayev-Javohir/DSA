// public static class SearchExamples
// {
//   public static int LinearSearch(int[] arr, int t)
//   {
//     if (arr == null || arr.Length <= 1) return -1;

//     for (int i = 0; i < arr.Length; i++) if (arr[i] == t) return i;
//     return -1;
//   }

//   public static int BinarySearchIterative(int[] arr, int t)
//   {
//     int left = 0, right = arr.Length - 1;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;

//       if (arr[mid] == t) return mid;
//       else if (arr[mid] < t) left = mid + 1;
//       else right = mid - 1;
//     }
//     return -1;
//   }

//   public static int BinarySearchRecursive(int[] arr, int t) => BinarySearchRecursive(arr, t, 0, arr.Length - 1);

//   private static int BinarySearchRecursive(int[] arr, int t, int left, int right)
//   {
//     if (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (arr[mid] == t) return mid;
//       else if (arr[mid] < t) return BinarySearchRecursive(arr, t, mid + 1, right);
//       else BinarySearchRecursive(arr, t, left, right - 1);
//     }
//     return -1;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5, 6 };
//     int t = 6;
//     // Console.WriteLine(SearchExamples.LinearSearch(arr, t));

//     Console.WriteLine(SearchExamples.BinarySearchIterative(arr, t));

//   }
// }

// class Program
// {
//   static (int first, int last) FirstAndLastFind(int[] arr, int target)
//   {
//     int first = -1, last = -1;
//     int left = 0, right = arr.Length - 1;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;

//       if (arr[mid] >= target) right = mid - 1;
//       else left = mid + 1;
//     }
//     if (left < arr.Length && arr[left] == target) first = left;
//     else return (-1, -1);

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (arr[mid] <= target) left = mid + 1;
//       else right = mid - 1;
//     }
//     last = right;
//     return (first, last);
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 3, 3, 4 };
//     var (f, l) = FirstAndLastFind(arr, 3);
//     Console.WriteLine($"{f}, {l}");
//   }
// }

// class Program
// {
//   public static int MajorityElementBoyerMoore(int[] nums)
//   {
//     int candidate = 0, count = 0;

//     foreach (var x in nums)
//     {
//       if (count == 0)
//       {
//         candidate = x;
//         count = 1;
//       }
//       else if (x == candidate) count++;

//       else count--;
//     }

//     int occ = 0;
//     foreach (int x in nums) if (x == candidate) occ++;
//     if (occ > nums.Length / 2) return candidate;
//     return -1;
//   }

//   static void Main()
//   {
//     int[] arr = { 3, 3, 4 };
//     Console.WriteLine(MajorityElementBoyerMoore(arr));
//   }
// }

public class Solution
{
  public int[] SearchRange(int[] nums, int target)
  {
    if (nums == null || nums.Length == 0) return new int[] { -1, -1 };

    int n = nums.Length;
    int first = -1, last = -1;

    int left = 0, right = n - 1;

    while (left <= right)
    {
      int mid = left + (right - left) / 2;
      if (nums[mid] >= target) right = mid - 1;
      else left = mid + 1;
    }
    if (left < n && nums[left] == target) first = left;
    else return new int[] { -1, -1 };

    left = 0; right = n - 1;

    while (left <= right)
    {
      int mid = left + (right - left) / 2;
      if (nums[mid] <= target) left = mid + 1;
      else right = mid - 1;
    }
    last = right;

    return new int[] { first, last };
  }
}
// class Program
// {
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 3, 3, 4 };
//     var sol = new Solution();
//     var result = sol.SearchRange(arr, 3);
//     Console.WriteLine(string.Join(", ", result));
//   }
// }



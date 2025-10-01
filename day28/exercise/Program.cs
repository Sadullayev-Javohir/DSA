// class Program
// {
//   static int BinarySearch(int[] arr, int k)
//   {
//     int left = 0, right = arr.Length - 1;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (arr[mid] == k) return mid;
//       else if (arr[mid] >= k) right = mid - 1;
//       else left = mid + 1;
//     }
//     return -1;
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5 };
//     Console.WriteLine(BinarySearch(arr, 5));
//   }
// }

// class Program
// {
//   // static int LowerBound(int[] a, int target)
//   // {
//   //   int left = 0, right = a.Length - 1;
//   //   int found = a.Length;

//   //   while (left <= right)
//   //   {
//   //     int mid = left + (right - left) / 2;
//   //     if (a[mid] >= target)
//   //     {
//   //       found = mid;
//   //       right = mid - 1;
//   //     }
//   //     else left = mid + 1;
//   //   }
//   //   return found;
//   // }

//   static int UpperBound(int[] arr, int target)
//   {
//     int left = 0, right = arr.Length - 1;
//     int found = arr.Length;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (arr[mid] > target)
//       {
//         found = mid;
//         right = mid - 1;
//       }
//       else left = mid + 1;
//     }
//     return found;
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5, 5 };
//     Console.WriteLine(UpperBound(arr, 1));
//   }
// }

// class Program
// {
//   static int SearchInRotated(int[] arr, int target)
//   {
//     int n = arr.Length;
//     int left = 0, right = n - 1;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (arr[mid] == target) return mid;

//       if (arr[left] <= arr[mid])
//       {
//         if (arr[left] <= target && target < arr[mid]) right = mid - 1;
//         else left = mid + 1;
//       }
//       else
//       {
//         if (arr[mid] < target && target <= arr[right]) left = mid + 1;
//         else right = mid - 1;
//       }
//     }
//     return -1;
//   }

//   static void Main()
//   {
//     int[] arr = { 6, 7, 8, 1, 2, 3 };
//     Console.WriteLine(SearchInRotated(arr, 8));
//   }
// }

// class Program
// {
//   static int SearchInRotatedWithDuplicates(int[] arr, int target)
//   {
//     int left = 0, right = arr.Length - 1;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (arr[mid] == target) return mid;
//       if (arr[left] == arr[mid] && arr[mid] == arr[right]) { left++; right--; }
//       else if (arr[left] <= arr[mid])
//       {
//         if (arr[left] <= target && target < arr[mid]) right = mid - 1;
//         else left = mid + 1;
//       }
//       else
//       {
//         if (arr[mid] < target && target <= arr[right]) left = mid + 1;
//         else right = mid - 1;
//       }
//     }
//     return -1;
//   }
//   static void Main()
//   {
//     int[] arr = { 2, 2, 2, 3, 4, 2, 2 };
//     Console.WriteLine(SearchInRotatedWithDuplicates(arr, 2));
//   }
// }


// public class Solution
// {
//   public static int FindMin(int[] nums)
//   {
//     int left = 0, right = nums.Length - 1;

//     while (left < right)
//     {
//       int mid = left + (right - left) / 2;

//       if (nums[mid] > nums[right]) left = mid + 1;
//       else right = mid;
//     }
//     return nums[left];
//   }

//   static void Main()
//   {
//     int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
//     Console.WriteLine(FindMin(nums));
//   }
// }

// public class Solution
// {
//   public static bool Search(int[] nums, int target)
//   {
//     int left = 0, right = nums.Length - 1;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (nums[mid] == target) return true;

//       if (nums[left] == nums[mid] && nums[mid] == nums[right]) { left++; right--; }
//       else if (nums[left] <= nums[mid])
//       {
//         if (nums[left] <= target && target < nums[mid]) right = mid - 1;
//         else left = mid + 1;
//       }
//       else
//       {
//         if (nums[mid] < target && target <= nums[right]) left = mid + 1;
//         else right = mid - 1;
//       }
//     }
//     return false;
//   }

//   static void Main()
//   {
//     int[] arr = { 2, 5, 6, 0, 0, 1, 2 };
//     Console.WriteLine(Search(arr, 0));
//   }
// }


// class Program
// {
//   public static int FindPeakElement(int[] nums)
//   {
//     int left = 0, right = nums.Length - 1;

//     while (left < right)
//     {
//       int mid = left + (right - left) / 2;
//       if (nums[mid] < nums[mid + 1]) left = mid + 1;
//       else right = mid;
//     }
//     return left;
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 1 };
//     int n = FindPeakElement(arr);
//     Console.WriteLine(n);
//   }
// }

class Program
{
  public static int FindMin(int[] arr)
  {
    int left = 0, right = arr.Length - 1;

    while (left < right)
    {
      int mid = left + (right - left) / 2;
      if (arr[mid] > arr[right]) left = mid + 1;
      else if (arr[mid] < arr[right]) right = mid;
      else right--;
    }
    return arr[left];
  }
  static void Main()
  {
    int[] arr = { 2, 2, 2, 0, 1 };
    Console.WriteLine(FindMin(arr));
  }
}

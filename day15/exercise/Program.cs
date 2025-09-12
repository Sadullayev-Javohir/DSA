// class Program
// {
//   static void Hanoi(int diskSoni, char A, char C, char B)
//   {
//     if (diskSoni <= 0) return;

//     if (diskSoni == 1)
//     {
//       Console.WriteLine($"Disk 1 ni {A} dan {C} ga ko'chir");
//       return;
//     }

//     Hanoi(diskSoni - 1, A, B, C);

//     Console.WriteLine($"Disk {diskSoni} ni {A} dan {C} ga ko'chir");


//     Hanoi(diskSoni - 1, B, C, A);
//   }

//   static void Main()
//   {
//     int diskSoni = 3;
//     Console.WriteLine($"Hanoy minorasi masalasi {diskSoni} ta disk uchun yechim");
//     Hanoi(diskSoni, 'A', 'B', 'C');
//   }
// }

// class Program
// {
//   static int BinarySearch(int[] arr, int left, int right, int key)
//   {
//     if (left > right) return -1;
//     int mid = left + (right - left) / 2;
//     if (arr[mid] == key) return mid;
//     if (arr[mid] < key) return BinarySearch(arr, mid + 1, right, key);
//     return BinarySearch(arr, left, mid - 1, key);
//   }
//   static void Main()
//   {
//     int[] arr = new int[] { 15, 16, 17, 18, 19 };
//     int i = BinarySearch(arr, 0, arr.Length - 1, 17);
//     Console.WriteLine(i >= 0 ? $"Found: {i}" : "Not found");
//   }
// }


// class PermuteExample
// {
//   static void Permute(int[] arr, int start, List<int[]> output)
//   {
//     if (start == arr.Length - 1)
//     {
//       int[] copy = new int[arr.Length];
//       Array.Copy(arr, copy, arr.Length);
//       output.Add(copy);
//       return;
//     }

//     for (int i = start; i < arr.Length; i++)
//     {
//       Swap(arr, start, i);
//       Permute(arr, start + 1, output);
//       Swap(arr, start, i);
//     }
//   }

//   static void Swap(int[] arr, int i, int j)
//   {
//     var temp = arr[i];
//     arr[i] = arr[j];
//     arr[j] = temp;
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3 };
//     var outlist = new List<int[]>();
//     Permute(arr, 0, outlist);
//     foreach (var p in outlist)
//     {
//       Console.WriteLine(string.Join(",", p));
//     }
//   }
// }


// public class Solution

// {
//   public static int Search(int[] arr, int target)
//   {
//     if (arr == null) return -1;
//     return SearchHelper(arr, 0, arr.Length - 1, target);
//   }

//   private static int SearchHelper(int[] arr, int left, int right, int target)
//   {
//     if (left > right) return -1;
//     int mid = left + (right - left) / 2;
//     if (arr[mid] == target) return mid;
//     if (arr[mid] < target) return SearchHelper(arr, mid + 1, right, target);
//     return SearchHelper(arr, left, mid - 1, target);
//   }

//   static void Main()
//   {
//     int[] a = new int[] { 15, 16, 17, 18 };
//     Console.WriteLine(Search(a, 17));
//   }
// }

// public class Solution
// {
//   public static int SearchInsert(int[] nums, int target)
//   {
//     int left = 0, right = nums.Length - 1;
//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;
//       if (nums[mid] == target) return mid;
//       if (nums[mid] < target) left = mid + 1;
//       else right = mid - 1;
//     }
//     return left;
//   }

//   static void Main()
//   {
//     var a = new int[] { 4, 5, 6, 7, 8 };
//     int i = SearchInsert(a, 1);
//     Console.WriteLine(i);
//   }
// }

class Program
{
  static int SearchInsert(int[] nums, int target)
  {
    return BinarySearch(nums, 0, nums.Length - 1, target);
  }
  private static int BinarySearch(int[] nums, int left, int right, int target)
  {
    if (left > right) return left;

    int mid = left + (right - left) / 2;
    if (nums[mid] == target) return mid;
    if (nums[mid] < target) return BinarySearch(nums, mid + 1, right, target);
    return BinarySearch(nums, left, mid - 1, target);
  }

  static void Main()
  {
    var a = new int[] { 4, 5, 6, 8 };
    int i = SearchInsert(a, 7);
    Console.WriteLine(i);
  }
}


// public class VersionControl
// {
//   private int bad;

//   public VersionControl(int badVersion)
//   {
//     bad = badVersion;
//   }

//   protected bool IsBadVersion(int version)
//   {
//     return version >= bad;
//   }
// }

// public class Solution : VersionControl
// {
//   public Solution(int badVersion) : base(badVersion) { }

//   public int FirstBadVersion(int n)
//   {
//     int left = 1, right = n;
//     while (left < right)
//     {
//       int mid = left + (right - left) / 2;

//       if (IsBadVersion(mid)) right = mid;
//       else left = mid + 1;
//     }
//     return left;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Solution sol = new Solution(6);
//     Console.WriteLine("Natija: " + sol.FirstBadVersion(10));
//   }
// }

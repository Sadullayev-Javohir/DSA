// class Program
// {
//   static void ReverseInPlace(int[] arr)
//   {
//     if (arr != null)
//     {
//       int n = arr.Length, l = 0, r = n - 1;

//       while (l < r)
//       {
//         int temp = arr[l];
//         arr[l] = arr[r];
//         arr[r] = temp;
//         l++; r--;
//       }
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5, 6 };
//     ReverseInPlace(arr);
//     Console.WriteLine(string.Join(",", arr));
//   }
// }



// class Program
// {
//   public static int LinearSearch(int[] arr, int find)
//   {
//     if (arr == null) return -1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if (arr[i] == find) return i;
//     }
//     return -1;
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5, 6 };
//     Console.WriteLine(LinearSearch(arr, 4));
//   }
// }

// class Program
// {
//   static int BinarySearch(int[] arr, int find)
//   {
//     if (arr == null || arr.Length < find) return -1;
//     int n = arr.Length, l = 0, r = n - 1;

//     while (l <= r)
//     {
//       int middle = l + (r - l) / 2;
//       if (arr[middle] == find) return middle;
//       if (arr[middle] < find) l = middle + 1;
//       else r = middle - 1;
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
//   static bool HasDuplicate(int[] arr)
//   {
//     var seen = new HashSet<int>();
//     foreach (var x in arr)
//     {
//       if (seen.Contains(x)) return true;
//       seen.Add(x);
//     }
//     return false;
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 1 };
//     Console.WriteLine(HasDuplicate(arr));
//   }
// }

class Program
{
  public static bool HasDuplicateBySort(int[] arr)
  {
    if (arr == null || arr.Length <= 1) return false;
    for (int i = 1; i < arr.Length; i++)
    {
      if (arr[i] == arr[i - 1]) return true;
    }
    return false;
  }

  static void Main()
  {
    int[] arr = { 1, 2, 4, 3 };
    Console.WriteLine(HasDuplicateBySort(arr));
  }
}


// 5) LeetCode masalalari (2 ta): muammo, yechim, C# kod, test case’lar
// Masala 1 — Two Sum (LC #1)

// Problem: Berilgan nums massiv va target qiymat — ikkita indeks toping i va j shundayki nums[i] + nums[j] = target. Indekslar juftini qaytaring (o‘rni farqi yo‘q).

// Yondashuv: HashMap (dictionary) — elementni ko‘zdan kechirarkanmiz, target - nums[i] ning oldindan ko‘rilganini tekshiramiz.

// Murakkablik: vaqt O(n), xotira O(n).

// public class Program
// {
//   static int[] TwoSum(int[] arr, int target)
//   {
//     if (arr == null) return new int[] { -1, -1 };
//     Dictionary<int, int> map = new Dictionary<int, int>();

//     for (int i = 0; i < arr.Length; i++)
//     {
//       int needed = target - arr[i];
//       if (map.ContainsKey(needed)) return new int[] { map[needed], i };
//       if (!map.ContainsKey(needed))
//       {
//         map[arr[i]] = i;
//       }
//     }
//     return new int[] { -1, -1 };
//   }

//   static void Main()
//   {
//     int[] arr = { 2, 7, 11,  };
//     int[] result = TwoSum(arr, 9);
//     Console.WriteLine(string.Join(",", result));
//   }
// }


public class Program2
{
  static int[] ProductExceptSelf(int[] arr)
  {
    if (arr == null) return new int[] { };
    int n = arr.Length;
    int[] output = new int[n];
    int left = 1;

    for (int i = 0; i < n; i++)
    {
      output[i] = left;
      left *= arr[i];
    }

    int right = 1;

    for (int i = n - 1; i >= 0; i--)
    {
      output[i] *= right;
      right *= arr[i];
    }
    return output;
  }
  static void Main()
  {
    int[] arr = { 1, 2, 3, 4 };
    int[] result = ProductExceptSelf(arr);
    Console.WriteLine(string.Join(",", result));
  }
}


// public class Program
// {
//   public static void ReverseString(char[] s)
//   {
//     if (s == null) return;
//     int n = s.Length, l = 0, r = n - 1;
//     while (l < r)
//     {
//       char temp = s[l];
//       s[l] = s[r];
//       s[r] = temp;
//       l++; r--;
//     }
//   }
//   static void Main()
//   {
//     char[] s = { 'h', 'e', 'l', 'l', 'o' };
//     ReverseString(s);
//     Console.WriteLine(string.Join(",", s));
//   }
// }

// class Program
// {
//   static int BinarySearch(int[] arr, int target)
//   {
//     if (arr == null) return -1;
//     int l = 0, n = arr.Length, r = n - 1;

//     while (l <= r)
//     {
//       int middle = l + (r - l) / 2;
//       if (target == arr[middle]) return middle;
//       if (arr[middle] < target) l = middle + 1;
//       else r = middle - 1;
//     }
//     return -1;
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5 };
//     int target = 5;
//     Console.WriteLine(BinarySearch(arr, target));
//   }
// }

// class Program
// {
//   static bool IsPalindrome(int x)
//   {
//     if (x < 0) return false;
//     string s = x.ToString();
//     int l = 0, r = s.Length - 1;
//     while (l < r)
//     {
//       if (s[l] != s[r]) return false;
//       l++; r--;
//     }
//     return true;
//   }
//   static void Main()
//   {
//     int num = -11;
//     Console.WriteLine(IsPalindrome(num));
//   }
// }


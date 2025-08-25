// int[] a = new int[5];
// a[0] = 10;
// int x = a[0];
// Console.WriteLine(x);

// int[] arr = { 1, 2, 3 };
// int newElement = 4;

// int[] newArr = new int[arr.Length + 1];

// for (int i = 0; i < arr.Length; i++)
// {
//   newArr[i] = arr[i];
// }

// newArr[newArr.Length - 1] = newElement;

// arr = newArr;

// Console.WriteLine(string.Join(",", arr));


// List<int> list = new List<int> { 1, 2, 3 };
// int newElement = 4;

// list.Add(newElement);

// Console.WriteLine(string.Join(",", list));

// int[] a = { 1, 2, 3, 4, 5 };
// int[] sub = new int[3];
// Array.Copy(a, 1, sub, 0, 3);

// sub[0] = 99;
// Console.WriteLine(string.Join(",", sub));

// int[] a = { 1, 2, 3, 4, 5 };

// ArraySegment<int> view = new ArraySegment<int>(a, 1, 3);

// foreach (var item in view)
// {
//   Console.WriteLine(item + " ");
// }
// Console.WriteLine();

// view[0] = 99;
// Console.WriteLine(string.Join(",", a));

// int[] arr = { 1, 2, 3, 4, 5 };
// int removeIndex = 2;

// for (int i = removeIndex; i < arr.Length - 1; i++)
// {
//   arr[i] = arr[i + 1];
// }

// arr[arr.Length - 1] = 0;

// Console.WriteLine(string.Join(",", arr));

// public static class ArrayUtils
// {

//   public static T[] RemoveAt<T>(T[] arr, int index)
//   {
//     if (arr == null) throw new ArgumentNullException(nameof(arr));
//     if (index < 0 || index >= arr.Length) throw new ArgumentOutOfRangeException(nameof(arr));

//     T[] newArr = new T[arr.Length - 1];
//     if (index > 0) Array.Copy(arr, 0, newArr, 0, index);
//     if (index < arr.Length - 1) Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1);
//     return newArr;
//   }

//   public static T[] AddItem<T>(T[] arr, T value)
//   {
//     if (arr == null) return new T[] { value };

//     T[] newArr = new T[arr.Length + 1];

//     Array.Copy(arr, newArr, arr.Length);

//     newArr[arr.Length] = value;
//     return newArr;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int[] numbers = { };

//     numbers = ArrayUtils.AddItem(numbers, 4);
//     numbers = ArrayUtils.RemoveAt(numbers, 0);
//     Console.WriteLine(string.Join(",", numbers));

//   }
// }


// public class Program
// {
//   static void Main()
//   {
//     // var list = new List<int>() { 1, 2, 3 };
//     // list.Add(4);
//     // list.Insert(1, 99);
//     // list.RemoveAt(2);
//     // list.ForEach(Console.WriteLine);

//     int[] a = { 1, 2, 3, 4, 5 };

//     int[] subCopy = new int[3];
//     Array.Copy(a, 1, subCopy, 0, 3);

//     ArraySegment<int> subView = new ArraySegment<int>(a, 1, 3);

//     a[2] = 99;

//     Console.WriteLine(string.Join(",", subCopy));
//     Console.WriteLine(string.Join(",", subView));
//   }
// }


// public class Program
// {
//   public static void ReverseInPlace<T>(T[] arr)
//   {
//     if (arr == null) return;
//     int i = 0, j = arr.Length - 1;
//     while (i < j)
//     {
//       T temp = arr[i];
//       arr[i] = arr[j];
//       arr[j] = temp;

//       i++; j--;
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5 };

//     ReverseInPlace(arr);

//     Console.WriteLine(string.Join(",", arr));
//   }
// }


// public class Program
// {
//   static void RemoveDuplicateSorted(int[] nums)
//   {
//     if (nums.Length == 0) return;
//     int write = 1;
//     for (int read = 1; read < nums.Length; read++)
//     {
//       if (nums[read] != nums[write - 1])
//       {
//         nums[write] = nums[read];
//         write++;
//       }
//     }
//     // return write;
//   }
//   static void Main()
//   {
//     int[] nums = { 1, 1, 2, 2, 3, 3, 4, 4 };
//     RemoveDuplicateSorted(nums);
//     Console.WriteLine(string.Join(",", nums));
//   }
// }


// public class Program
// {
//   static void RotateRight<T>(T[] arr, int k)
//   {
//     int n = arr.Length;
//     if (n == 0) return;
//     k = k % n;
//     if (k == 0) return;

//     void Reverse(int l, int r)
//     {
//       while (l < r)
//       {
//         T temp = arr[l];
//         arr[l] = arr[r];
//         arr[r] = temp;

//         l++; r--;
//       }
//     }

//     Reverse(0, n - 1);
//     Reverse(0, k - 1);
//     Reverse(k, n - 1);
//   }

//   static void Main()
//   {
//     int[] nums = [1, 2, 3, 4, 5];
//     RotateRight(nums, 2);
//     Console.WriteLine(string.Join(",", nums));
//   }
// }


// Masala 1 — Reverse in-place (beginner)

// Savol: Berilgan massivni joyida teskari qiling.
// Yechim: ikki pointer (i, j) va swap. O(n) vaqt, O(1) joy.

class Program
{
  static void Reverse<T>(T[] arr)
  {
    if (arr == null) return;
    int i = 0, j = arr.Length - 1;
    while (i < j)
    {
      T temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;

      i++; j--;
    }
  }
  static void Main()
  {
    string[] letters = { "A", "B", "C", "D", "E" };
    Reverse(letters);
    Console.WriteLine(string.Join(",", letters));
  }
}

public class Program2
{
  static int[] TwoSum(int[] arr, int target)
  {
    if (arr != null)
    {
      Dictionary<int, int> map = new Dictionary<int, int>();

      for (int i = 0; i < arr.Length; i++)
      {
        int needed = target - arr[i];

        if (map.ContainsKey(needed))
        {
          return new int[] { map[needed], i };
        }
        if (!map.ContainsKey(needed))
        {
          map[arr[i]] = i;
        }
      }
    }
    return new int[] { -1, -1 };
  }
  static void Main()
  {
    int[] nums = { 2, 7, 11, 15 };
    int target = 9;
    int[] res = TwoSum(nums, target);
    Console.WriteLine($"[{res[0]}, {res[1]}]");
  }
}

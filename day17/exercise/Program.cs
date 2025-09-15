// Integer24
// class Program
// {
//   static void Main()
//   {
//     int K = int.Parse(Console.ReadLine());
//     int qoldiq = K % 7;
//     string haftaKuni = Convert.ToString(qoldiq);
//     switch (haftaKuni)
//     {
//       case "0":
//         Console.WriteLine("Yakshanba");
//         break;
//       case "1":
//         Console.WriteLine("Dushanba");
//         break;
//       case "2":
//         Console.WriteLine("Chorshanba");
//         break;
//       case "3":
//         Console.WriteLine("Payshanba");
//         break;
//       case "4":
//         Console.WriteLine("Juma");
//         break;
//       case "5":
//         Console.WriteLine("Shanba");
//         break;
//     }
//   }
// }


// Integer25

// class Program
// {
//   static void Main()
//   {
//     int K = int.Parse(Console.ReadLine());
//     int qoldiq = (K % 7) + 2;

//     string haftaKuni = Convert.ToString(qoldiq);
//     switch (haftaKuni)
//     {
//       case "0":
//         Console.WriteLine("Yakshanba");
//         break;
//       case "1":
//         Console.WriteLine("Dushanba");
//         break;
//       case "2":
//         Console.WriteLine("Chorshanba");
//         break;
//       case "3":
//         Console.WriteLine("Payshanba");
//         break;
//       case "4":
//         Console.WriteLine("Juma");
//         break;
//       case "5":
//         Console.WriteLine("Shanba");
//         break;
//     }
//   }
// }

// Integer26
// class Program
// {
//   static void Main()
//   {
//     int k = int.Parse(Console.ReadLine());
//     int haftaKuni = (k + 1) % 7;
//     string[] kunlar = {
//       "Dushanba",
//       "Seshanba",
//       "Chorshanba",
//       "Payshanba",
//       "Juma",
//       "Shanba",
//       "Yakshanba"
//     };
//     Console.WriteLine(kunlar[haftaKuni == 0 ? 6 : haftaKuni - 1]);
//   }
// }

// Console.WriteLine(-1 > 0 ? true : false);
// Console.WriteLine(11 % 2 != 0 ? "Toq son" : "Musbat son");
// Console.WriteLine(11 % 2 == 0 ? "Musbat son" : "Toq son");

// int a = 5, b = 3;
// Console.WriteLine(a > 2 && b <= 3);


// public class Program
// {
//   static void BubbleSort(int[] arr)
//   {
//     if (arr == null) return;

//     int n = arr.Length;

//     for (int i = 0; i < n - 1; i++)
//     {
//       for (int j = 0; j < n - 1 - i; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           int tmp = arr[j];
//           arr[j] = arr[j + 1];
//           arr[j + 1] = tmp;
//         }
//       }
//     }
//   }
//   static void Main()
//   {
//     var arr = new int[] { 4, 2, 6, 3, 1 };
//     BubbleSort(arr);
//     for (int i = 0; i < arr.Length; i++)
//     {
//       Console.WriteLine(arr[i]);
//     }
//   }
// }

// public class Program
// {
//   public static void BubbleSort(int[] arr)
//   {
//     int n = arr.Length;
//     for (int i = 0; i < n - 1; i++)
//     {
//       bool swapped = false;
//       for (int j = 0; j < n - 1 - i; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           int temp = arr[j];
//           arr[j] = arr[j + 1];
//           arr[j + 1] = temp;
//           swapped = true;
//         }
//       }
//       if (!swapped) break;
//     }
//   }

//   static void Main()
//   {
//     var arr = new int[] { 4, 2, 6, 3, 1 };
//     BubbleSort(arr);
//     for (int i = 0; i < arr.Length; i++)
//     {
//       Console.WriteLine(arr[i]);
//     }
//   }
// }


// class Program
// {
//   static void BubbleSort(int[] arr)
//   {
//     int n = arr.Length;
//     int newN;

//     while (n > 1)
//     {
//       newN = 0;
//       for (int i = 1; i < n; i++)
//       {
//         if (arr[i - 1] > arr[i])
//         {
//           int temp = arr[i - 1];
//           arr[i - 1] = arr[i];
//           arr[i] = temp;
//           newN = i;
//         }
//       }
//       n = newN;
//     }
//   }
//   static void Main()
//   {
//     int[] arr = { 5, 6, 7, 8, 9, 1 };
//     BubbleSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// *BubbleSort Basic*

// for (int i = 0; i < 5; i++)
// {
//   if (i == 3) continue;
//   Console.WriteLine("i = " + i);
// }

// class Program
// {
//   static void BubbleSort(int[] arr)
//   {
//     if (arr == null) return;
//     int n = arr.Length;

//     for (int i = 0; i < n - 1; i++)
//     {
//       for (int j = 0; j < n - 1 - i; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           int temp = arr[j];
//           arr[j] = arr[j + 1];
//           arr[j + 1] = temp;
//         }
//       }
//     }
//   }
//   static void Main()
//   {
//     int[] arr = { 15, 1, 6, 3, 7, 2 };
//     BubbleSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// ** Optimized BubbleSort

// class Program
// {
//   static void OptimizedBubbleSort(int[] arr)
//   {
//     if (arr == null) return;
//     int n = arr.Length;

//     for (int i = 0; i < n - 1; i++)
//     {
//       bool swapped = false;
//       for (int j = 0; j < n - 1 - i; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           int temp = arr[j];
//           arr[j] = arr[j + 1];
//           arr[j + 1] = temp;
//           swapped = true;
//         }
//       }
//       if (!swapped) break;
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 12, 6, 1, 7, 2 };
//     OptimizedBubbleSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// public class Program
// {
//   static void BubbleSortLastSwap(int[] arr)
//   {
//     int n = arr.Length;
//     int newN;

//     while (n > 1)
//     {
//       newN = 0;
//       for (int i = 1; i < n; i++)
//       {
//         if (arr[i - 1] > arr[i])
//         {
//           int temp = arr[i - 1];
//           arr[i - 1] = arr[i];
//           arr[i] = temp;
//           newN = i;
//         }
//       }
//       n = newN;
//     }
//   }
//   static void Main()
//   {
//     int[] arr = { 15, 1, 7, 2, -2, -4 };
//     BubbleSortLastSwap(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }


// public class Program
// {
//   public static void CocktailShakerSort(int[] arr)
//   {
//     int left = 0, right = arr.Length - 1;

//     while (left < right)
//     {
//       for (int i = left; i < right; i++)
//       {
//         if (arr[i] > arr[i + 1])
//         {
//           int tmp = arr[i];
//           arr[i] = arr[i + 1];
//           arr[i + 1] = tmp;
//         }
//       }
//       right--;

//       for (int i = right; i > left; i--)
//       {
//         if (arr[i - 1] > arr[i])
//         {
//           int tmp = arr[i - 1];
//           arr[i - 1] = arr[i];
//           arr[i] = tmp;
//         }
//       }
//       left++;
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 8, 9, 19, 1, 4, 6, 2 };
//     CocktailShakerSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// public class Solution
// {
//   static void MoveZero(int[] arr)
//   {
//     if (arr == null) return;
//     int pos = 0;
//     int n = arr.Length;

//     for (int i = 0; i < n; i++)
//     {
//       if (arr[i] != 0)
//       {
//         arr[pos] = arr[i];
//         pos++;
//       }
//     }

//     while (pos < n)
//     {
//       arr[pos] = 0;
//       pos++;
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 0, 1, 0, 3, 12 };
//     MoveZero(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// public class Solution
// {
//   public static int[] Shuffle(int[] arr, int n)
//   {
//     int index = 0;
//     var result = new int[n * 2];

//     for (int i = 0; i < n; i++)
//     {
//       result[index++] = arr[i];
//       result[index++] = arr[i + n];
//     }
//     return result;
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4, 5, 6 };
//     var result = Shuffle(arr, 3);
//     Console.WriteLine(string.Join(", ", result));
//   }
// }

// public class Solution
// {
//   public static bool IsAnagram(string t, string s)
//   {
//     if (t.Length != s.Length) return false;

//     var count = new int[26];
//     for (int i = 0; i < t.Length; i++)
//     {
//       count[t[i] - 'a']++;
//       count[s[i] - 'a']--;
//     }

//     foreach (var c in count) if (c != 0) return false;

//     return true;
//   }
//   static void Main()
//   {
//     string t = "anagram", s = "nagaram";
//     Console.WriteLine(IsAnagram(t, s));
//   }
// }


public class Solution
{
  public void SortColors(int[] nums)
  {
    int zero = 0, now = 0, two = nums.Length - 1;

    while (now <= two)
    {
      if (nums[now] == 0)
      {
        int tmp = nums[zero];
        nums[zero] = nums[now];
        nums[now] = tmp;

        zero++; now++;
      }
      else if (nums[now] == 1) now++;
      else
      {
        int tmp = nums[now];
        nums[now] = nums[two];
        nums[two] = tmp;

        two--;
      }
    }
  }
}

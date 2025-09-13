// public class Solution
// {
//   public int LengthOfLongSubstring(string s)
//   {
//     if (string.IsNullOrEmpty(s)) return 0;

//     int left = 0, maxLen = 0;
//     var lastIndex = new Dictionary<char, int>();

//     string window = "";

//     for (int right = 0; right < s.Length; right++)
//     {
//       char c = s[right];
//       if (lastIndex.ContainsKey(c)) left = Math.Max(left, lastIndex[c] + 1);

//       lastIndex[c] = right;

//       window = s.Substring(left, right - left + 1);

//       maxLen = Math.Max(maxLen, window.Length);
//     }
//     return maxLen;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var sol = new Solution();
//     string s = "abba";
//     int result = sol.LengthOfLongSubstring(s);
//     Console.WriteLine(result);
//   }
// }


// public class ListNode
// {
//   public int value;
//   public ListNode next;

//   public ListNode(int value = 0, ListNode next = null) { this.value = value; this.next = next; }
// }

// public class Solution
// {
//   public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//   {
//     var dummy = new ListNode(-1);
//     var current = dummy;

//     while (list1 != null && list2 != null)
//     {
//       if (list1.value < list2.value)
//       {
//         current.next = list1;
//         list1 = list1.next;
//       }
//       else
//       {
//         current.next = list2;
//         list2 = list2.next;
//       }
//       current = current.next;
//     }

//     if (list1 != null) current.next = list1;
//     else current.next = list2;

//     return dummy.next;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
//     var list2 = new ListNode(2, new ListNode(3, new ListNode(4)));

//     var sol = new Solution();

//     PrintList(sol.MergeTwoLists(list1, list2));
//   }
//   static void PrintList(ListNode head)
//   {
//     while (head != null)
//     {
//       Console.Write(head.value);
//       if (head.next != null) Console.Write(" -> ");
//       head = head.next;
//     }
//     Console.WriteLine();
//   }
// }


// using System.Threading.Tasks;

// public class Solution
// {
//   public static int RemoveDuplicates(int[] a)
//   {
//     if (a == null) return 0;

//     int i = 0;
//     for (int j = 1; j < a.Length; j++)
//     {
//       if (a[j] != a[i])
//       {
//         i++;
//         a[i] = a[j];
//       }
//     }
//     return i + 1;
//   }

//   static void Main()
//   {
//     var a = new int[] { 1, 1, 2, 2, 3, 3, 4, 4 };
//     int result = RemoveDuplicates(a);
//     for (int i = 0; i < result; i++)
//     {
//       Console.Write(a[i]);
//     }
//     Console.WriteLine();
//   }
// }

public class Solution
{
  public static int[] TwoSum(int[] numbers, int target)
  {
    int left = 0;
    int right = numbers.Length - 1;

    while (left < right)
    {
      int sum = numbers[left] + numbers[right];

      if (sum == target) return new int[] { left + 1, right + 1 };
      else if (sum < target) left++;
      else right--;
    }
    return new int[0];
  }

  static void Main()
  {
    var a = new int[] {1, 2, 3, 4, 5, 6};
    int target = 9;
    var result = TwoSum(a, target);
    Console.WriteLine(string.Join(", ", result));
  }
}

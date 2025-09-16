// public class Program
// {
//   public static void InsertionSort(int[] arr)
//   {
//     if (arr == null) return;
//     int n = arr.Length;

//     for (int i = 1; i < n; i++)
//     {
//       int key = arr[i];
//       int j = i - 1;
//       while (j >= 0 && arr[j] > key)
//       {
//         arr[j + 1] = arr[j];
//         j--;
//       }
//       arr[j + 1] = key;
//     }
//   }
//   static void Main()
//   {
//     int[] arr = { 8, 5, 4, 1, 6 };
//     InsertionSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// public class Program
// {
//   public static void SelectionSort(int[] arr)
//   {
//     if (arr == null) return;
//     int n = arr.Length;

//     for (int i = 0; i < n - 1; i++)
//     {
//       int minIndex = i;
//       for (int j = i + 1; j < n; j++)
//       {
//         if (arr[minIndex] > arr[j]) minIndex = j;
//       }

//       if (minIndex != i)
//       {
//         int tmp = arr[i];
//         arr[i] = arr[minIndex];
//         arr[minIndex] = tmp;
//       }
//     }
//   }
//   static void Main()
//   {
//     int[] arr = { 6, 2, 7, 2, 9, 1 };
//     SelectionSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

// class Program
// {
//   static void BinaryInsertionSort(int[] arr)
//   {
//     if (arr == null) return;
//     int n = arr.Length;

//     for (int i = 1; i < n - 1; i++)
//     {
//       int key = i;
//       int left = 0, right = i - 1;
//       while (left <= right)
//       {
//         int mid = (right - left) / 2;
//         if (arr[mid] > key) right = mid - 1;
//         else left = mid + 1;
//       }

//       for (int j = i - 1; j >= left; i--)
//       {
//         arr[j + 1] = arr[j];
//       }
//       arr[left] = key;
//     }
//   }
// }

// class Solution
// {
//   public static void InsertionSort(int[] arr)
//   {
//     if (arr == null) return;
//     int n = arr.Length;

//     for (int i = 1; i < n; i++)
//     {
//       int key = arr[i];
//       int j = i - 1;
//       while (j >= 0 && arr[j] > key)
//       {
//         arr[j + 1] = arr[j];
//         j--;
//       }
//       arr[j + 1] = key;
//     }
//   }
//   static int HeightChecker(int[] heights)
//   {
//     if (heights == null) return -1;
//     int n = heights.Length;
//     var newArr = new int[n];
//     int i = 0, count = 0;
//     while (i < n)
//     {
//       newArr[i] = heights[i];
//       i++;
//     }
//     InsertionSort(newArr);
//     i = 0;
//     while (i < n)
//     {
//       if (newArr[i] != heights[i]) count++;
//       i++;
//     }
//     return count;
//   }

//   static void Main()
//   {
//     var heights = new int[] { 1, 1, 4, 2, 1, 3 };
//     // InsertionSort(heights);
//     // Console.WriteLine(string.Join(", ", heights));
//     Console.WriteLine(HeightChecker(heights));
//   }
// }

// class Program
// {
//   static int HeightChecker(int[] nums)
//   {
//     int n = nums.Length;
//     var newArr = new int[n];
//     Array.Copy(nums, newArr, n);
//     Array.Sort(newArr);

//     int i = 0, count = 0;
//     while (i < n)
//     {
//       if (nums[i] != newArr[i]) count++;
//       i++;
//     }
//     return count;
//   }

//   static void Main()
//   {
//     var arr = new int[] { 1, 1, 4, 2, 1, 3 };
//     Console.WriteLine(HeightChecker(arr));
//   }
// }

// public class ListNode
// {
//   public int val;
//   public ListNode next;

//   public ListNode(int val = 0, ListNode next = null)
//   {
//     this.val = val; this.next = next;
//   }
// }

// public class Solution
// {
//   public static ListNode MergeTwoList(ListNode list1, ListNode list2)
//   {
//     var dummy = new ListNode(-1);
//     var current = dummy;

//     while ((list1 != null) && (list2 != null))
//     {
//       if (list1.val <= list2.val)
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
//     if (list2 != null) current.next = list2;

//     return dummy.next;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
//     var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

//     var sol = Solution.MergeTwoList(list1, list2);
//     PrintListNode(sol);

//   }
//   static void PrintListNode(ListNode list)
//   {
//     if (list == null) return;
//     while (list != null)
//     {
//       Console.Write(list.val);
//       if (list.next != null) Console.Write(" -> ");
//       list = list.next;
//     }
//     Console.WriteLine();
//   }
// }


public class ListNode
{
  public int val;
  public ListNode next;
  public ListNode(int val = 0, ListNode next = null)
  {
    this.val = val;
    this.next = next;
  }
}

public class Solution
{
  public ListNode InsertionSortList(ListNode head)
  {
    if (head == null || head.next == null) return head;

    var dummy = new ListNode(0);
    var current = head;

    while (current != null)
    {
      var nextNode = current.next;

      var prev = dummy;
      while (prev.next != null && prev.next.val < current.val)
      {
        prev = prev.next;
      }

      current.next = prev.next;
      prev.next = current;

      current = nextNode;
    }
    return dummy.next;
  }
}

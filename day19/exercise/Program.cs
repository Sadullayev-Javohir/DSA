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
//   public static ListNode InsertionSortList(ListNode head)
//   {
//     if (head == null || head.next == null) return head;

//     var dummy = new ListNode(0);
//     var current = head;

//     while (current != null)
//     {
//       var nextNode = current.next;

//       var prev = dummy;

//       while (prev.next != null && prev.next.val < current.val) prev = prev.next;

//       current.next = prev.next;
//       prev.next = current;

//       current = nextNode;
//     }
//     return dummy.next;
//   }
//   static void PrintList(ListNode head)
//   {
//     if (head != null)
//     {
//       while (head != null)
//       {
//         Console.Write(head.val);
//         if (head.next != null) Console.Write(" -> ");
//         head = head.next;
//       }
//       Console.WriteLine();
//     }


//   }
//   static void Main()
//   {
//     var list = new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3))));
//     list = InsertionSortList(list);
//     PrintList(list);
//   }
// }

// class Program
// {
//   public static void MergeSort(int[] arr)
//   {
//     if (arr == null || arr.Length <= 1) return;
//     int[] aux = new int[arr.Length];

//     MergeSortRec(arr, aux, 0, arr.Length - 1);
//   }

//   private static void MergeSortRec(int[] arr, int[] aux, int left, int right)
//   {
//     if (left >= right) return;

//     int mid = left + (right - left) / 2;

//     MergeSortRec(arr, aux, left, mid);
//     MergeSortRec(arr, aux, mid + 1, right);
//     Merge(arr, aux, left, mid, right);
//   }

//   private static void Merge(int[] arr, int[] aux, int left, int mid, int right)
//   {
//     for (int i = left; i <= right; i++) aux[i] = arr[i];

//     int iLeft = left, iRight = mid + 1, curr = left;

//     while (iLeft <= mid && iRight <= right)
//     {
//       if (aux[iLeft] <= aux[iRight]) arr[curr++] = aux[iLeft++];
//       else arr[curr++] = aux[iRight++];
//     }

//     while (iLeft <= mid) arr[curr++] = aux[iLeft++];
//     while (iRight <= right) arr[curr++] = aux[iRight++];
//   }

//   static void Main()
//   {
//     int[] arr = { 5,1,1,2,0,0 };
//     MergeSort(arr);
//     Console.WriteLine(string.Join(", ", arr));
//   }
// }

public class ListNode
{
  public ListNode next;
  public int val;

  public ListNode(int val = 0, ListNode next = null)
  {
    this.next = next;
    this.val = val;
  }
}

public class Solution
{
  public static ListNode SortList(ListNode head)
  {
    if (head == null || head.next == null) return head;

    ListNode slow = head;
    ListNode fast = head;
    ListNode prev = null;

    while (fast != null && fast.next != null)
    {
      prev = slow;
      slow = slow.next;
      fast = fast.next.next;
    }

    prev.next = null;

    ListNode l1 = SortList(head);
    ListNode l2 = SortList(slow);

    return MergeTwoLists(l1, l2);
  }

  private static ListNode MergeTwoLists(ListNode l1, ListNode l2)
  {
    var dummy = new ListNode(-1);
    var curr = dummy;

    while (l1 != null && l2 != null)
    {
      if (l1.val < l2.val)
      {
        curr.next = l1;
        l1 = l1.next;
      }
      else
      {
        curr.next = l2;
        l2 = l2.next;
      }
      curr = curr.next;
    }

    if (l1 != null) curr.next = l1;
    if (l2 != null) curr.next = l2;

    return dummy.next;
  }

  static void PrintList(ListNode head)
  {
    if (head == null) return;

    while (head != null)
    {
      Console.Write(head.val);

      if (head.next != null) Console.Write(" -> ");
      head = head.next;
    }
    Console.WriteLine();
  }
  static void Main()
  {
    var list = new ListNode(5, new ListNode(3, new ListNode(1, new ListNode(2))));
    var list2 = SortList(list);
    PrintList(list2);
  }
}

public class Node
{
  public int val;
  public Node next;
  public Node(int val = 0, Node next = null)
  {
    this.val = val;
    this.next = next;
  }
}

public static class SinglyListOpt
{
  public static Node BuildFromArray(int[] arr)
  {
    if (arr == null || arr.Length == 0) return null;
    Node head = new Node(arr[0]);
    Node curr = head;

    for (int i = 1; i < arr.Length; i++)
    {
      curr.next = new Node(arr[i]);
      curr = curr.next;
    }
    return head;
  }

  public static Node Reverse(Node head)
  {
    Node prev = null;
    Node curr = head;
    while (curr != null)
    {
      Node nextTemp = curr.next;
      curr.next = prev;
      prev = curr;
      curr = nextTemp;
    }
    return prev;
  }

  public static Node ReverseRecursive(Node head)
  {
    if (head == null || head.next == null) return head;

    Node newHead = ReverseRecursive(head.next);

    head.next.next = head;
    head.next = null;

    return newHead;
  }

  public static bool HasCycle(Node head)
  {
    if (head == null) return false;
    Node slow = head, fast = head;

    while (fast != null && fast.next != null)
    {
      slow = slow.next;
      fast = fast.next.next;
      if (slow == fast) return true;
    }
    return false;
  }

  public static Node DetectCycleStart(Node head)
  {
    if (head == null) return null;
    Node slow = head, fast = head;
    bool hasCycle = false;
    while (fast != null && fast.next != null)
    {
      slow = slow.next;
      fast = fast.next.next;
      if (slow == fast) { hasCycle = true; break; }
    }
    if (!hasCycle) return null;

    Node ptr1 = head;
    Node ptr2 = slow;
    while (ptr1 != ptr2)
    {
      ptr1 = ptr1.next;
      ptr2 = ptr2.next;
    }
    return ptr1;
  }

  public static bool IsPalindrome(Node head)
  {
    if (head == null || head.next == null) return true;

    Node fast = head, slow = head;
    while (fast != null && fast.next != null)
    {
      slow = slow.next;
      fast = fast.next.next;
    }

    Node prev = null;
    while (slow != null)
    {
      Node temp = slow.next;
      slow.next = prev;
      prev = slow;
      slow = temp;
    }

    Node first = head, second = prev;

    while (second != null)
    {
      if (first.val != second.val) return false;
      first = first.next;
      second = second.next;
    }
    return true;
  }
  public static void PrintList(Node head)
  {
    if (head == null) return;
    Node curr = head;
    while (curr != null)
    {
      Console.Write(curr.val);
      if (curr.next != null) Console.Write(" -> ");

      curr = curr.next;
    }
    Console.WriteLine(" -> null");
  }
}

class Program
{
  static void Main()
  {
    int[] arr = { 1, 1, 2, 1 };

    Node head = SinglyListOpt.BuildFromArray(arr);

    Console.WriteLine(SinglyListOpt.IsPalindrome(head));
    // var tail = head;
    // while (tail.next != null) tail = tail.next;
    // tail.next = head.next;
    // Console.WriteLine(SinglyListOpt.HasCycle(head));

    // var start = SinglyListOpt.DetectCycleStart(head);
    // Console.WriteLine(start.val);
  }
}

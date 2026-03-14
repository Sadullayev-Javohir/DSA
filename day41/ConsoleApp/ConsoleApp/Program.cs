// class Node
// {
//     public int Value;
//     public Node Next;
//
//     public Node(int value) => Value = value;
// }
//
// class Program
// {
//     public static void Main()
//     {
//         Node head = null;
//
//         head = InsertLast(head, 1);
//         head = InsertLast(head, 2);
//         head = InsertLast(head, 3);
//         head = InsertLast(head, 4);
//         head = InsertLast(head, 5);
//         
//         Console.WriteLine((Search(head, 6) != null ? "Topildi" : "Topilmadi"));
//         Delete(ref head, 5);    
//         PrintList(head);
//         Console.WriteLine((Delete(ref head, 3) ? "O'chirildi" : "O'chirilmadi"));
//     }
//
//     static bool Delete(ref Node head, int value)
//     {
//         if (head == null) return false;
//         if (head.Next.Value == value) return true;
//
//         var current = head;
//
//         while (current.Next != null)
//         {
//             if (current.Next.Value == value)
//             {
//                 current.Next = current.Next.Next;
//                 return true;
//             }
//
//             current = current.Next;
//         }
//
//         return false;
//     }
//
//     static Node Search(Node head, int value)
//     {
//         Node current = head;
//
//         while (current != null)
//         {
//             if (current.Value == value) return current;
//             current = current.Next; 
//         }
//
//         return null;
//     }
//     static Node InsertLast(Node head, int value)
//     {
//         var newNode = new Node(value);
//         if (head == null) return newNode;
//
//         var current = head;
//
//         while (current.Next != null)
//         {
//             current = current.Next;
//         }
//
//         current.Next = newNode;
//         return head;
//     }
//
//     static void PrintList(Node head)
//     {
//         if (head == null) return;
//         
//         Console.WriteLine(head.Value + " ");
//         PrintList(head.Next);
//     }
//
//     static Node InsertFirst(Node head, int value)
//     {
//         Node newNode = new Node(value);
//         newNode.Next = head;
//         return newNode;
//     }
// }

// class Node
// {
//     public Node Next;
//     public int Value;
//
//     public Node(int value) => Value = value;
// }
//
// class Program
// {
//     static void Main()
//     {
//         // var head = new Node(1);
//         // head.Next = new Node(2);
//         // head.Next.Next = new Node(3);
//         //
//         // head = InsertFirst(head, 4);
//         // head = InsertFirst(head, 5);
//         // head = InsertLast(head, 6);
//         // head = InsertLast(head, 7);
//         Node head = null;
//         head = InsertLast(head, 1);
//         head = InsertLast(head, 2);
//         head = InsertLast(head, 3);
//         head = InsertLast(head, 4);
//         
//         Console.WriteLine();
//         // Console.WriteLine(Search(head, 10) ? "topildi" : "topilmadi");
//         // // Console.WriteLine(Delete(head, 1) ? "o'chirildi" : "o'chirilmadi");
//         // Console.WriteLine(Delete(head, 1) ? "O'chirildi" : "O'chirilmadi");
//         // Console.WriteLine(DeleteFirst(ref head) ? "Birinchi son o'chirildi" : "O'chirilmadi");
//         Console.WriteLine(DeleteLast(ref head) ? "Oxirgi son o'chirildi" : "O'chirilmadi");
//         Console.WriteLine(DeleteLast(ref head) ? "Oxirgi son o'chirildi" : "O'chirilmadi");
//         // Console.WriteLine(DeleteLast(ref head) ? "Oxirgi son o'chirildi" : "O'chirilmadi");
//         Traversal(head);
//     }
//
//     static bool DeleteLast(ref Node head)
//     {
//         if (head == null) return false;
//         if (head.Next == null)
//         {
//             head = null;
//             return true;
//         }
//
//         var current = head;
//         while (current.Next.Next != null) current = current.Next;
//         current.Next = null;
//         return true;
//     }
//     static bool DeleteFirst(ref Node head)
//     {
//         if (head == null) return false;
//         head = head.Next;
//         return true;
//     }
//     static bool Delete(Node head, int value)
//     {
//         if (head == null) return false;
//         if (head.Value == value)
//         {
//             head = head.Next;
//             return true;
//         };
//
//         var current = head;
//
//         while (current.Next != null)
//         {
//             if (current.Next.Value == value)
//             {
//                 current.Next = current.Next.Next;
//                 return true;
//             }
//             current = current.Next;
//         }
//         return false;
//     }
//     static bool Search(Node head, int value)
//     {
//         if (head.Value == value) return true;
//         var current = head;
//
//         while (current.Next != null)
//         {
//             if (current.Value == value) return true;
//             current = current.Next;
//         }
//
//         return false;
//     }
//     static Node InsertLast(Node head, int value)
//     {
//         var newNode = new Node(value);
//         if (head == null) return newNode;
//
//         var current = head;
//         while (current.Next != null) current = current.Next;
//         
//         current.Next = newNode;
//         return head;
//     }
//     static Node InsertFirst(Node head, int value)
//     {
//         var newNode = new Node(value);
//         newNode.Next = head;
//         return newNode;
//     }
//     static void Traversal(Node head)
//     {
//         while (head != null)
//         {
//             Console.Write(head.Value + " ");
//             head = head.Next;
//         }
//     }
// }

// using System.Globalization;

// class Node
// {
//     public int Value;
//     public Node Next;
//     public Node Prev;
//
//     public Node(int value) => Value = value;
// }
//
// class DoublyLinkedList
// {
//     public Node Head;
//     public Node Tail;
//
//     public void InsertAtBeginning(int value)
//     {
//         Node newNode = new Node(value);
//
//         if (Head == null)
//         {
//             Head = newNode;
//             Tail = newNode;
//             return;
//         }
//
//         newNode.Next = Head;
//         Head.Prev = newNode;
//         Head = newNode;
//     }
//
//     public void InsertAtEnd(int value)
//     {
//         var newNode = new Node(value);
//         if (Head == null)
//         {
//             Head = newNode;
//             Tail = newNode;
//             return;
//         }
//
//         Tail.Next = newNode;
//         newNode.Prev = Tail;
//         Tail = newNode;
//     }
//
//     public void PrintForward()
//     {
//         Node current = Head;
//         while (current != null)
//         {
//             Console.Write(current.Value);
//             if (current.Next != null) Console.Write(" <--> ");
//             current = current.Next;
//         }
//
//         Console.WriteLine();
//     }
//
//     public Node Search(int value)
//     {
//         var current = Head;
//
//         while (current != null)
//         {
//             if (current.Value == value) return current;
//             current = current.Next;
//         }
//
//         return null;
//     }
//
//     public void InsertAfter(int targetValue, int value)
//     {
//         Node current = Search(2);
//
//         if (current.Value != targetValue)
//         {
//             Console.WriteLine("Topilmadi");
//             return;
//         }
//
//         Node newNode = new Node(value);
//         if (current == Tail)
//         {
//             current.Next = newNode;
//             newNode.Prev = current;
//             Tail = newNode;
//             return;
//         }
//
//         newNode.Next = current.Next;
//         newNode.Prev = current;
//
//         current.Next.Prev = newNode;
//         current.Next = newNode;
//     }
//
//     public void InsertBefore(int targetValue, int value)
//     {
//         Node current = Search(2);
//         if (current == null)
//         {
//             Console.WriteLine("topilmadi");
//             return;
//         }
//
//         Node newNode = new Node(value);
//
//         if (current == Head)
//         {
//             newNode.Next = Head;
//             Head.Prev = newNode;
//             Head = newNode;
//             return;
//         }
//
//         newNode.Prev = current.Prev;
//         newNode.Next = current;
//
//         current.Prev.Next = newNode;
//         current.Prev = newNode;
//     }
//
//     public void DeleteFromBeginning()
//     {
//         if (Head == null)
//         {
//             Console.WriteLine("List bo'sh");
//             return;
//         }
//
//         if (Head == Tail)
//         {
//             Head = null;
//             Tail = null;
//             return;
//         }
//
//         Head = Head.Next;
//         Head.Prev = null;
//     }
//
//     public void DeleteFromEnding()
//     {
//         if (Tail == null)
//         {
//             Console.WriteLine("List bo'sh");
//             return;
//         }
//
//         if (Head == Tail)
//         {
//             Head = null;
//             Tail = null;
//             return;
//         }
//
//         Tail = Tail.Prev;
//         Tail.Next = null;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         DoublyLinkedList list = new DoublyLinkedList();
//         // list.InsertAtBeginning(20);
//         // list.InsertAtBeginning(30);
//         // list.InsertAtBeginning(40);
//         // list.InsertAtBeginning(50);
//         // list.InsertAtEnd(60);
//         // list.InsertAtEnd(70);
//         list.InsertAtEnd(1);
//         list.InsertAtEnd(2);
//         list.InsertAtEnd(3);
//         list.InsertAtEnd(4);
//
//         Console.WriteLine("Forward");
//         list.InsertAfter(2, 9);
//         list.InsertBefore(2, 10);
//         list.DeleteFromBeginning();
//         list.DeleteFromEnding();
//         list.PrintForward();
//
//         // Console.WriteLine(list.Search(9) != null ? "topildi " + (list.Search(50).Value) : "topilmadi");
//     }
// }

// class Node
// {
//     public int Value;
//     public Node Next;
//     public Node(int value) => Value = value;
// }
//
// class SinglyLinkedList
// {
//     public Node Head;
//     public Node Tail;
//
//     public void InsertAtBeginning(int value)
//     {
//         Node newNode = new Node(value);
//         if (Head == null)
//         {
//             Head = Tail = newNode;
//             return;
//         }
//
//         newNode.Next = Head;
//         Head = newNode;
//     }
//     public void InsertAtEnd(int value)
//     {
//         Node newNode = new Node(value);
//         if (Tail == null)
//         {
//             Head = Tail = newNode;
//         }
//
//         Tail.Next = newNode;
//         Tail = newNode;
//     }
//     public Node Search(int value)
//     {
//         var current = Head;
//         while (current != null)
//         {
//             if (current.Value == value)
//             {
//                 return current;
//                 break;
//             }
//
//             current = current.Next;
//         }
//         return null;
//     }
//
//     public void InsertAfter(int pos, int value)
//     {
//         var curr = Search(pos);
//         if (curr == null)
//         {
//             Console.WriteLine("Son topilmadi");
//             return;
//         }
//
//         var newNode = new Node(value);
//         if (Head == curr)
//         {
//             newNode.Next = Head;
//             Head = newNode;
//             return;
//         }
//
//         // curr.Next = newNode;
//         // newNode.Next = curr.Next;
//         newNode.Next = curr.Next;
//         curr.Next = newNode;
//     }
//
//     public bool DeleteFromBeginning()
//     {
//         if (Head == null)
//         {
//             Console.WriteLine("List bo'sh");
//             return false;
//         }
//
//         Head = Head.Next;
//         return true;
//     }
//
//     public bool DeleteFromEnd()
//     {
//         if (Tail == null) return false;
//
//         var curr = Head;
//
//         while (curr.Next != Tail) curr = curr.Next;
//         Tail = null;
//         curr.Next = Tail;
//         return true;
//     }
//
//     public bool DeleteByValue(int value)
//     {
//         var find = Search(value);
//         if (find == null)
//         {
//             Console.WriteLine("Topilmadi");
//             return false;
//         }
//         if (find == Head)
//         {
//             DeleteFromBeginning();
//             return true;
//         }
//
//         if (find == Tail)
//         {
//             DeleteFromEnd();
//             return true;
//         }
//         
//         var curr = Head;
//         while (curr.Next != find) curr = curr.Next;
//         curr.Next = curr.Next.Next;
//         return true;
//     }
//
//     public int Count()
//     {
//         int count = 0;
//         var curr = Head;
//         while (curr != null)
//         {
//             count++;
//             curr = curr.Next;
//         }
//
//         return count;
//     }
//     public void Print()
//     {
//         var current = Head;
//         while (current != null)
//         {
//             Console.Write(current.Value);
//             if (current.Next != null) Console.Write(" => ");
//             current = current.Next;
//         }
//     }
//
//     public void Reverse()
//     {
//         var curr = Head;
//         Node prev;
//         Node next = prev = null;
//
//         while (curr != null)
//         {
//             next = curr.Next;
//             curr.Next = prev;
//             prev = curr;
//             curr = next;
//         }
//
//         Head = prev;
//     }
//
//     public Node FindMiddle()
//     {
//         if (Head == null) return null;
//
//         Node slow = Head, fast = Head;
//
//         while (fast != null && fast.Next != null)
//         {
//             slow = slow.Next;
//             fast = fast.Next.Next;
//         }
//
//         return slow;
//     }
//
//     public void RemoveDuplicates()
//     {
//         var curr = Head;
//
//         while (curr != null && curr.Next != null)
//         {
//             if (curr.Value == curr.Next.Value) curr.Next = curr.Next.Next;
//             else curr = curr.Next;
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         SinglyLinkedList list = new SinglyLinkedList();
//         // list.InsertAtBeginning(1);
//         // list.InsertAfter(1, 2);
//         // list.InsertAfter(1, 3);
//         Console.WriteLine();
//         // Console.WriteLine((list.Search(2)) != null ? "topildi: " + list.Search(2).Value : "topilmadi");
//         Console.WriteLine();
//         // Console.WriteLine(list.DeleteFromBeginning() ? "o'chirildi" : "o'chirilmadi");
//         // list.InsertAtBeginning(4);
//         // list.InsertAtBeginning(3);
//         // list.InsertAtBeginning(2);
//         
//         // Console.WriteLine(list.DeleteFromEnd() ? "o'chirildi" : "o'chirilmadi");
//         // list.DeleteByValue(3);
//         // list.Reverse();
//         // list.Print();
//         // Console.WriteLine();
//         // Console.WriteLine(list.Count());
//         // Console.WriteLine($"MiddleNode: {list.FindMiddle().Value}");
//         
//         list.InsertAtBeginning(4);
//         list.InsertAtBeginning(3);
//         list.InsertAtBeginning(3);
//         list.InsertAtBeginning(2);
//         list.InsertAtBeginning(2);
//         list.RemoveDuplicates();
//         list.Print();
//         
//         
//     }
//     
// }


class Node
{
    public Node Next;
    public Node Prev;
    public int Value;
    public Node(int value) => Value = value;
}

class DoublyLinkedList
{
    public Node Head;
    public Node Tail;

    public void InsertAtBeginning(int value)
    {
        var newNode = new Node(value);
        if (Head == null)
        {
            Head = Tail = newNode;
            return;
        }

        newNode.Next = Head;
        Head.Prev = newNode;
        Head = newNode;
    }
    public void InsertAtEnd(int value)
    {
        var newNode = new Node(value);
        if (Tail == null)
        {
            Tail = Head = newNode;
            return;
        }

        Tail.Next = newNode;
        newNode.Prev = Tail;
        Tail = newNode;

    }

    public Node Search(int value)
    {
        var curr = Head;
        while (curr != null)
        {
            if (curr.Value == value) return curr;
            curr = curr.Next;
        }

        return null;
    }
    public void PrintForward()
    {
        var curr = Head;
        while (curr != null)
        {
            Console.Write(curr.Value);
            if (curr.Next != null) Console.Write(" <=> ");
            curr = curr.Next;
        }
    }

    public bool DeleteFromBeginning()
    {
        if (Head == null) return false;

        Head = Head.Next;
        return true;
    }

    public bool DeleteFromEnd()
    {
        if (Tail == null) return false;
        if (Tail == Head)
        {
            Head = Tail = null;
            return true;
        }

        Tail = Tail.Prev;
        Tail.Next = null;
        return true;
    }

    public bool DeleteByValue(int value)
    {
        Node find = Search(value);
        if (find == null) return false;

        if (find == Head)
        {
            DeleteFromBeginning();
            return true;
        }
        if (find == Tail)
        {
            DeleteFromEnd();
            return true;
        }

        
        find.Prev.Next = find.Next;
        find.Next.Prev = find.Prev;
        return true;
    }

    public bool InsertAfter(int pos, int value)
    {
        var find = Search(pos);
        if (find == null) return false;

        var newNode = new Node(value);
        
        if (find == Tail)
        {
            InsertAtEnd(value);
            return true;
        }
        newNode.Next = find.Next;
        find.Next.Prev = newNode;

        find.Next = newNode;
        newNode.Prev = find;
        return true;
    }

    public bool InsertBefore(int pos, int value)
    {
        var find = Search(pos);
        if (find == null) return false;
        
        if (Head == find)
        {
            InsertAtBeginning(value);
            return true;
        }

        var newNode = new Node(value);
        find.Prev.Next = newNode;
        newNode.Prev = find.Prev;

        newNode.Next = find;
        find.Prev = newNode;
        return true;
    }
    public void PrintBackward()
    {
        Node curr = Tail;
        while (curr != null)
        {
            Console.Write(curr.Value);
            if (curr != null) Console.Write(" <==> ");
            curr = curr.Prev;
        }
        Console.WriteLine("null");
    }
    public int Count()
    {
        var curr = Head;
        int count = 0;

        while (curr != null)
        {
            count++;
            curr = curr.Next;
        }

        return count;
    }

    public void Reverse()
    {
        var curr = Head;
        Node temp = null;
        while (curr != null)
        {
            temp = curr.Prev;
            curr.Prev = curr.Next;
            curr.Next = temp;
            curr = curr.Prev;
        }

        if (temp != null)
        {
            Head = temp.Prev;
        }
        
    }
    
}

class Program
{
    static void Main()
    {
        DoublyLinkedList list = new DoublyLinkedList();
        list.InsertAtBeginning(3);
        list.InsertAtBeginning(2);
        list.InsertAtBeginning(1);
        list.Reverse();
        list.PrintForward();
        // list.InsertBefore(3, 5);
        // list.InsertAfter(1, 4);
        // list.InsertAfter(3, 5);
        // list.DeleteByValue(3);
        // list.DeleteFromEnd();
        // list.DeleteFromBeginning();
        // list.PrintForward();
        // list.PrintBackward();
        // Console.WriteLine(list.Count());

        // Console.WriteLine((list.Search(2) != null ? "Topildi" + list.Search(2).Value : "Topilmadi"));
    } 
}
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

// class  Program
// {
//     static void Main()
//     {
//         List<int> heap = new List<int>();
//         
//         heap.Add(10);
//         Console.WriteLine(string.Join(", ", heap));
//         
//         heap.Add(30);
//         int i = heap.Count - 1;
//
//         while (i > 0)
//         {
//             int parent = (i - 1) / 2;
//             if (heap[i] <= heap[parent]) break;
//
//             (heap[i], heap[parent]) = (heap[parent], heap[i]);
//             i = parent;
//         }
//         
//         Console.WriteLine(string.Join(", ", heap));
//         
//         heap.Add(20);
//         i = heap.Count - 1;
//
//         while (i > 0)
//         {
//             int parent = (i - 1) / 2;
//             if (heap[i] <= heap[parent]) break;
//
//             (heap[i], heap[parent]) = (heap[parent], heap[i]);
//             i = parent;
//         }
//         Console.WriteLine(string.Join(", ", heap));
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         List<int> heap = new List<int>() { 50, 20, 30, 10 };
//         Console.WriteLine("Boshlanish: " + string.Join(", ", heap));
//
//         int max = heap[0];
//
//         heap[0] = heap[heap.Count - 1];
//         heap.Remove(heap[heap.Count - 1]);
//
//         int i = 0, lastIndex = heap.Count - 1;
//
//         while (true)
//         {
//             int left = 2 * i + 1, right = 2 * i + 2, largest = i;
//
//             if (left <= lastIndex && heap[left] > heap[largest]) largest = left;
//             if (right <= lastIndex && heap[right] > heap[largest]) largest = right;
//             if (largest == i) break;
//
//             (heap[i], heap[largest]) = (heap[largest], heap[i]);
//
//             i = largest;
//             
//             Console.WriteLine("Olingan max: " + max);
//             Console.WriteLine("Yangi heap: " + string.Join(", ", heap));
//         }
//     }
// }
//
// class MaxHeap
// {
//     private List<int> heap = new List<int>();
//
//     public void Insert(int value)
//     {
//         heap.Add(value);
//         HeapifyUp(heap.Count - 1);
//     }
//
//     public int ExtractMath()
//     {
//         int max = heap[0];
//         heap[0] = heap[heap.Count - 1];
//         heap.Remove(heap[heap.Count - 1]);
//
//         HeapifyDown(0);
//         return max;
//     }
//
//     private void HeapifyUp(int i)
//     {
//         while (i > 0)
//         {
//             int parent = (i - 1) / 2;
//             if (heap[i] <= heap[parent]) break;
//             Swap(i, parent);
//             i = parent;
//         }
//     }
//
//     private void HeapifyDown(int i)
//     {
//         int lastIndex = heap.Count - 1;
//
//         while (true)
//         {
//             int left = 2 * i + 1, right = 2 * i + 2, largest = i;
//
//             if (left <= lastIndex && heap[left] > heap[largest]) largest = left;
//             if (right <= lastIndex && heap[right] > heap[largest]) largest = right;
//
//             if (largest == i) break;
//             Swap(i, largest);
//             i = largest;
//         }
//     }
//
//     private void Swap(int i, int j)
//     {
//         (heap[i], heap[j]) = (heap[j], heap[i]);
//     }
//
//     public void Print() => Console.WriteLine(string.Join(", ", heap));
// }
//
// class Program
// {
//     static void Main()
//     {
//         MaxHeap MHeap = new MaxHeap();
//         MHeap.Insert(10);
//         MHeap.Insert(50);
//         MHeap.Insert(30);
//         MHeap.Insert(20);
//         
//         MHeap.Print();
//
//         Console.WriteLine("Max: " + MHeap.ExtractMath());
//         
//         MHeap.Print();
//     }
// }

// class PriorityQueue<T>
// {
//     private List<(T Item, int Priority)> heap = new();
//
//     public int Count => heap.Count;
//
//     public void Enqueu(T Item, int priority)
//     {
//         heap.Add((Item, priority));
//         HeapifyUp(heap.Count - 1);
//     }
//
//     public T Dequeue()
//     {
//         if (heap.Count == 0) throw new InvalidOperationException("Queue bo'sh");
//         T root = heap[0].Item;
//
//         heap[0] = heap[heap.Count - 1];
//         heap.RemoveAt(heap.Count - 1);
//
//         if (heap.Count > 0) HeapifyDown(0);
//         return root;
//     }
//
//     public void HeapifyUp(int index)
//     {
//         while (index > 0)
//         {
//             int parent = (index - 1) / 2;
//             if (heap[index].Priority >= heap[parent].Priority) break;
//
//             (heap[parent], heap[index]) = (heap[index], heap[parent]);
//             index = parent;
//         }
//     }
//
//     private void HeapifyDown(int index)
//     {
//         while (true)
//         {
//             int left = 2 * index + 1, right = 2 * index + 2, smallest = index;
//
//             if (left < heap.Count && heap[left].Priority < heap[smallest].Priority) smallest = left;
//             if (right < heap.Count && heap[right].Priority < heap[smallest].Priority) smallest = right;
//             if (smallest == index) break;
//
//             (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
//             index = smallest;
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         PriorityQueue<string> pq = new();
//         
//         pq.Enqueu("Low", 3);
//         pq.Enqueu("High", 1);
//         pq.Enqueu("Medium", 2);
//
//         while (pq.Count > 0)
//         {
//             Console.WriteLine(pq.Dequeue());
//         }
//     }
// }

// class PriorityQueue<T>
// {
//     private List<(T item, int priority)> heap = new();
//
//     public void Enqueue(T item, int priority)
//     {
//         heap.Add((item, priority));
//         HeapifyUp(heap.Count - 1);
//     }
//
//     public int Count => heap.Count;
//
//     private void HeapifyUp(int index)
//     {
//         while (index > 0)
//         {
//             int parent = (index - 1) / 2;
//
//             if (heap[index].priority >= heap[parent].priority) break;
//             (heap[index], heap[parent]) = (heap[parent], heap[index]);
//             index = parent;
//         }
//     }
//
//     public T Dequeue()
//     {
//         if (heap.Count == 0) throw new InvalidOperationException("Bo'sh");
//
//         T root = heap[0].item;
//         heap[0] = heap[heap.Count - 1];
//         heap.RemoveAt(heap.Count - 1);
//
//         if (heap.Count != 0) HeapifyDown(0);
//         return root;
//     }
//
//
//     private void HeapifyDown(int index)
//     {
//         while (true)
//         {
//             int left = 2 * index + 1, right = 2 * index + 2, smallest = index;
//             if (left < heap.Count && heap[left].priority <= heap[smallest].priority) smallest = left;
//             if (right < heap.Count && heap[right].priority <= heap[smallest].priority) smallest = right;
//             if (smallest == index) break;
//             (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
//             index = smallest;
//         }
//     }
//
//     public T Peek()
//     {
//         if (heap.Count == 0) throw new InvalidOperationException("Bo'sh");
//         return heap[0].item;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         PriorityQueue<string> pq = new();
//         
//         pq.Enqueue("High", 1);
//         pq.Enqueue("Medium", 2);
//         pq.Enqueue("Low", 3);
//
//         while (pq.Count > 0)
//         {
//             Console.WriteLine(pq.Dequeue());
//         }
//         
//     }
// }

class PriorityQueue<T>
{
    private List<(T item, int priority)> heap = new();

    public void Enqueue(T item, int priority)
    {
        heap.Add((item, priority));
         HeapifyUp(heap.Count - 1);
    }

    public T Dequeue()
    {
        if (heap.Count == 0) throw new InvalidOperationException("bo'sh queue");
        T removed = heap[0].item;
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        if (heap.Count > 0) HeapifyDown(0);
        return removed;
    }

    public T Peek()
    {
        if (heap.Count == 0) throw new InvalidOperationException("Queue bo'sh");
        return heap[0].item;
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;
            if (heap[parent].priority < heap[index].priority) break;
            Swap(index, parent);
            index = parent;
        }
    }

    private void HeapifyDown(int index)
    {
        while (true)
        {
            int left = 2 * index + 1, right = 2 * index + 2, smallest = index;

            if (left < heap.Count && heap[left].priority < heap[smallest].priority) smallest = left;
            if (right < heap.Count && heap[right].priority < heap[smallest].priority) smallest = right;
            
            if (smallest == index) break;
            Swap(smallest, index);
            index = smallest;
        }
    }

    private void Swap(int i, int j)
    {
        (heap[i], heap[j]) = (heap[j], heap[i]);
    }

    public int Count => heap.Count;
}

class Program
{
    static void Main()
    {
        PriorityQueue<string> pq = new();
        
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 2);
        pq.Enqueue("High", 3);
        
        while (pq.Count > 0) Console.WriteLine(pq.Dequeue());
    }
}
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 10, 3, 5, 1 };

        HeapSort(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--) Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            Heapify(arr, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1, right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest]) largest = left;
        if (right < n && arr[right] > arr[largest]) largest = right;

        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}
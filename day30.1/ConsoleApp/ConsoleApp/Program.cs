using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        int[] arr = { 8, 3, 5, 9, 1 };

        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int pivotIndex = Random.Shared.Next(left, right + 1);
        int pivot = arr[pivotIndex];

        int index = Partition(arr, left, right, pivot);

        QuickSort(arr, left, index - 1);
        QuickSort(arr, index, right);
    }

    static int Partition(int[] arr, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (arr[left] < pivot) left++;
            while (arr[right] > pivot) right--;

            if (left <= right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }
        }

        return left;
    }
}
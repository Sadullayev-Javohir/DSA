// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, 4, 5 };
//         Console.WriteLine((BinarySearch(arr, 1) != -1) ? "Topildi" : "Topilmadi");
//     }
//
//     static int BinarySearch(int[] arr, int target)
//     {
//         int left = 0, n = arr.Length - 1, right = n;
//
//
//         while (left <= right)
//         {
//             int mid = (left + right) / 2;
//             if (arr[mid] == target) return mid;
//             else if (arr[mid] > target) right = mid - 1;
//             else left = mid + 1;
//         }
//
//         return -1;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2, 3, 4, 5 };
//         Console.WriteLine((BinarySearch(arr, 1) != -1) ? "Topildi" : "Topilmadi");
//     }
//
//     static int BinarySearch(int[] arr, int target)
//     {
//         int left = 0, right = arr.Length - 1;
//         return BinarySearch(arr, left, right, target);
//     }
//
//     private static int BinarySearch(int[] arr, int left, int right, int target)
//     {
//         if (left > right) return -1;
//
//         int mid = (left + right) / 2;
//
//         if (arr[mid] == target) return mid;
//         if (arr[mid] < target) BinarySearch(arr, mid + 1, right, target);
//         return BinarySearch(arr, left, mid - 1, target);
//     }
// }

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine((RecursiveBinarySearch(arr, 1)) != -1 ? "Topildi" : "Topilmadi");
    }

    // Iterative BinarySearch
    static int BinarySearch(int[] arr, int target)
    {
        int n = arr.Length - 1, left = 0, right = n;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target) return mid;
            else if (arr[mid] > target) right = mid - 1;
            else left = mid + 1;
        }

        return -1;
    }
    
    // Recursive BinarySearch
    static int RecursiveBinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        return RecursiveBinarySearch(arr, left, right, target);
    }

    private static int RecursiveBinarySearch(int[] arr, int left, int right, int target)
    {
        if (left > right) return -1;
        int mid = (left + right) / 2;

        if (arr[mid] == target) return mid;
        if (arr[mid] < target) return RecursiveBinarySearch(arr, mid + 1, right, target);
        return RecursiveBinarySearch(arr, left, mid - 1, target);
    }

}
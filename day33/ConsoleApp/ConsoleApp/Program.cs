// class Program
// {
//     static void Main()
//     {
//         int[] arr = { 6, 2, 3, 7 };
//         int target = 4;
//         
//         Console.WriteLine((BinarySearch(arr, target) != -1) ? "Topildi" : "Topilmadi");
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
//         if (left >= right) return -1;
//         
//         int mid = (left + right) / 2;
//     
//         if (arr[mid] == target) return mid;
//         if (arr[mid] < target) return BinarySearch(arr, mid + 1, right, target);
//         else return BinarySearch(arr, right, mid - 1, target);
//     }
//     // static int BinarySearch(int[] arr, int target)
//     // {
//     //     int left = 0, right = arr.Length - 1;
//     //
//     //     while (left <= right)
//     //     {
//     //         int mid = (left + right) / 2;
//     //
//     //         if (arr[mid] == target) return mid;
//     //         else if (arr[mid] < target) left = mid + 1;
//     //         else right = mid - 1;
//     //     }
//     //
//     //     return -1;
//     // }
//     // static int LinearSearch(int[] arr, int target)
//     // {
//     //     int n = arr.Length;
//     //     int last = arr[n - 1];
//     //     arr[n - 1] = target;
//     //     int i = 0;
//     //
//     //     while (arr[i] != target) i++;
//     //
//     //     arr[n - 1] = last;
//     //     if (i < n - 1 || last == target) return i;
//     //     return -1;
//     // }
//     // static int LinearSearch(int[] arr, int target)
//     // {
//     //     for (int i = 0; i < arr.Length - 1; i++)
//     //     {
//     //         if (arr[i] == target) return i;
//     //     }
//     //
//     //     return -1;
//     // }
// }


// class Program
// {
//     static void Main()
//     {
//         // int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
//         // int k = 3;
//         // int result = MaxSumSubarray(arr, k);
//         // Console.WriteLine("Max: " + result );
//         // Console.WriteLine(IsPalindrome(arr) == true ? "Palindrom" : "Palindrom emas");
//         // TwoPointer(arr, 15);
//         // RemoveDuplicates(arr);
//         // Console.WriteLine(string.Join(", ", arr));
//
//         int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
//         int result = MaxArea(height);
//         
//         Console.WriteLine(result);
//     }
//     
//     // Container Problem
//     static int MaxArea(int[] height)
//     {
//         int left = 0, right = height.Length - 1;
//         int maxArea = 0;
//
//         while (left < right)
//         {
//             int h = Math.Min(height[left], height[right]);
//             int width = right - left;
//             int area = h * width;
//
//             maxArea = Math.Max(maxArea, area);
//             if (height[left] < height[right]) left++;
//             else right--;
//         }
//
//         return maxArea;
//     }
//  
//     // Two Pointer
//     static void TwoPointer(int[] arr, int target)
//     {
//         int left = 0, right = arr.Length - 1;
//
//         while (left < right)
//         {
//             int sum = arr[left] + arr[right];
//
//             if (sum == target)
//             {
//                 Console.WriteLine($"{arr[left]} + {arr[right]} = {target}");
//                 return;
//             }
//             else if (sum < target) left++;
//             else right--;
//         }
//
//         Console.WriteLine("Topilmadi");
//     }
//
//     // Remove Duplicates
//     static void RemoveDuplicates(int[] arr)
//     {
//         int slow = 0;
//         for (int fast = 1; fast < arr.Length; fast++)
//         {
//             if (arr[fast] != arr[slow])
//             {
//                 slow++;
//                 arr[slow] = arr[fast];
//             }
//         }
//
//         for (int i = slow + 1; i < arr.Length; i++)
//         {
//             arr[i] = 0;
//         }
//     }
//
//     // IsPalindrome
//     static bool IsPalindrome(int[] arr)
//     {
//         int left = 0, right = arr.Length - 1;
//
//         while (left < right)
//         {
//             if (arr[left] != arr[right]) return false;
//             left++;
//             right--;
//         }
//
//         return true;
//     }
//
//     // Sliding Window
//     static int MaxSumSubarray(int[] arr, int k)
//     {
//         int windowSum = 0;
//
//         for (int i = 0; i < k; i++)
//         {
//             windowSum += arr[i];
//         }
//
//         int maxSum = windowSum;
//
//         for (int right = k; right < arr.Length; right++)
//         {
//             windowSum += arr[right];
//             windowSum -= arr[right - k];
//
//             maxSum = Math.Max(windowSum, maxSum);
//         }
//
//         return maxSum;
//     }
// }

class Program
{
    static void Main()
    {
        Console.WriteLine(RemoveDuplicates(new int[] {0,0,1,1,1,2,2,3,3,4 }));
    }

    public static int RemoveDuplicates(int[] nums)
    {
        int slow = 0;
        for (int fast = 1; fast < nums.Length; fast++)
        {
            if (nums[slow] != nums[fast])
            {
                slow++;
                nums[slow] = nums[fast];
            }
        }

        return slow + 1;
    }

    // static void Main()
    // {
    //
    //     int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
    //     Console.WriteLine("Max Area: " + MaxArea(height));
    // }
    //
    // public static int MaxArea(int[] height)
    // {
    //     int maxArea = 0;
    //     int left = 0, right = height.Length - 1;
    //     
    //     while (left < right)
    //     {
    //         int h = Math.Min(height[left], height[right]);
    //         int width = right - left;
    //         int area = h * width;
    //         maxArea = Math.Max(area, maxArea);
    //
    //         if (height[left] < height[right]) left++;
    //         else right--;
    //     }
    //
    //     return maxArea;
    // }
    // static void Main()
    // { 
    //     // int[] arr = {2,7,11,15};
    //     int[] arr = {-1, 0};
    //     
    //     int target = -1;
    //     int[] result = TwoSum(arr, target);
    //     Console.WriteLine(string.Join(", ", result));
    // }
    // public static int[] TwoSum(int[] numbers, int target)
    // {
    //     int left = 0, right = numbers.Length - 1;
    //     
    //     while (left < right)
    //     {
    //         int sum = numbers[left] + numbers[right];
    //
    //         if (sum == target) return new int[] {left + 1, right + 1};
    //         if (sum < target) left++;
    //         else right--;
    //     }
    //
    //     return new int[] { -1, -1 };
    // }
}
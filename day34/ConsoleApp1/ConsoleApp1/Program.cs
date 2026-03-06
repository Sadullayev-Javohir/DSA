// class Program
// {
//     static void Main()
//     {
//         // Console.WriteLine(string.Join(", ", TwoSum( new int[] {2, 7, 11, 15}, 26)));
//         // Console.WriteLine(IsPalindrome(new int[] {1, 1, 2, 3, 2, 1}));
//         
//         // Console.WriteLine(RemoveDuplicates(new int[] {1, 1, 2, 2, 3, 3, 4, 4, 4, 4}));
//         
//         Console.WriteLine(SlidingWindow(new int[] {2, 1, 5, 1, 3, 2}, 3));
//     }
//
//     static int SlidingWindow(int[] arr, int k)
//     {
//         int windowSum = 0;
//
//         for (int i = 0; i < k; i++) windowSum += arr[i];
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
//
//     }
//     
//     static int RemoveDuplicates(int[] arr)
//     {
//         int slow = 0;
//
//         for (int fast = 1; fast < arr.Length; fast++)
//         {
//             if (arr[fast] != arr[slow])
//             {
//                 slow++;
//                 arr[slow] = arr[fast];
//             }
//         }
//
//         return slow + 1;
//     }
//     
//
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
//     static int[] TwoSum(int[] arr, int target)
//     {
//         int sum = 0;
//     
//         int left = 0, right = arr.Length - 1;
//     
//         while (left < right)
//         {
//             sum = arr[left] + arr[right];
//     
//             if (sum == target) return new int[] {left, right};
//             if (sum < target) left++;
//             else right--;
//         }
//     
//         return new int[] { -1, -1 };
//     }
// }

// class Program
// {
//     static int MinSubArray(int[] arr, int target)
//     {
//         int left = 0, sum = 0, minLength = int.MaxValue;
//
//         for (int right = 0; right <= arr.Length - 1; right++)
//         {
//             sum += arr[right];
//
//             while (sum >= target)
//             {
//                 minLength = Math.Min(minLength, right - left + 1);
//                 sum -= arr[left];
//                 left++;
//             }
//         }
//
//         return (minLength == int.MaxValue) ? 0 : minLength;
//     }
//     
//     static int LengthOfLongestSubstring(string s)
//     {
//         int left = 0, maxLength = 0;
//         HashSet<char> seen = new HashSet<char>();
//
//         for (int right = 0; right < s.Length; right++)
//         {
//             while (seen.Contains(s[right])) seen.Remove(s[left++]);
//             seen.Add(s[right]);
//             int currentLength = right - left + 1;
//             maxLength = Math.Max(currentLength, maxLength);
//         }
//
//         return maxLength;
//     }
//     
//     
//     static void Main()
//     {
//         // Console.WriteLine(MinSubArray(new int[] {2, 3, 1, 2, 4, 3}, 7));
//         Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
//     }
//     
// }

// class Node
// {
//     public int Value;
//     public Node Next;
// }
//
// class Program
// {
//     static bool HasCycle(Node head)
//     {
//         Node slow = head;
//         Node fast = head;
//
//         while (fast != null && fast.Next != null)
//         {
//             slow = slow.Next;
//             fast = fast.Next.Next;
//
//             if (slow == fast) return true;
//         }
//
//         return false;
//     }
//
//     static void Main()
//     {
//         // Node n1 = new Node() { Value = 1 };
//         // Node n2 = new Node() { Value = 2 };
//         // Node n3 = new Node() { Value = 3 };
//         // Node n4 = new Node() { Value = 4 };
//         // Node n5 = new Node() { Value = 5 };
//         // n1.Next = n2;
//         // n2.Next = n3;
//         // n3.Next = n4;
//         // n4.Next = n5;
//         //
//         // n5.Next = n3;
//         //
//         // Console.WriteLine(HasCycle(n1));
//
//         int[] arr = { 16, 1, 3, 6, 4 };
//         var result = arr.Where(x => x > 3);
//         Console.WriteLine(string.Join(", ", result));
//     } 
// }
//
// class Program
// {
//     public static double FindMaxAverage(int[] nums, int k)
//     {
//         int windowSum = 0;
//         
//         for (int i = 0; i < k; i++)
//         {
//             windowSum += nums[i];
//         }
//
//         int maxSum = windowSum;
//
//         for (int right = k; right < nums.Length; right++)
//         {
//             windowSum += nums[right];
//             windowSum -= nums[right - k];
//
//             maxSum = Math.Max(maxSum, windowSum);
//         }
//
//         return (double)maxSum / k;
//     }
//     
//     
//
//     static void Main()
//     {
//         int[] arr = { 1, 12, -5, -6, 50, 3 };
//         Console.WriteLine(FindMaxAverage(arr, 4));
//     }
// }

// class Program
// {
//     public static bool ContainsNearbyDuplicate(int[] nums, int k)
//     {
//         HashSet<int> window = new HashSet<int>();
//         
//         for (int i = 0; i < nums.Length; i++)
//         {
//             if (window.Contains(nums[i])) return true;
//             window.Add(nums[i]);
//             
//             if (window.Count > k) window.Remove(nums[i - k]);
//         }
//
//         return false;
//     }
//
//     static void Main()
//     {
//         int[] arr = {2,2,3,1,2,3 };
//         Console.WriteLine(ContainsNearbyDuplicate(arr, 2));
//     }
// }

class Program
{
    public static int MinimumRecolors(string blocks, int k)
    {
        int windowSum = 0;

        for (int i = 0; i < k; i++) if (blocks[i] == 'W') windowSum++;

        int MinSum = windowSum;

        for (int right = k; right < blocks.Length; right++)
        {
            if (blocks[right - k] == 'W') windowSum--;
            if (blocks[right] == 'W') windowSum++;

            MinSum = Math.Min(windowSum, MinSum);
        }

        return MinSum;


    }

    static void Main()
    {
        Console.WriteLine(MinimumRecolors("WBBWWBBWBW", 7));
    }
}
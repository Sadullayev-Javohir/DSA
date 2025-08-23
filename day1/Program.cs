using System;


// class Program1
// {
//   static void Main(string[] args)
//   {
//     Console.Write("Birinchi sonni kiriting: ");
//     string inputA = Console.ReadLine();

//     Console.Write("Ikkinchi sonni kiriting: ");
//     string inputB = Console.ReadLine();

//     if (!long.TryParse(inputA?.Trim(), out long a))
//     {
//       Console.WriteLine("Birinchi kiritishda xatolik. Iltimos butun son kiriting: ");
//       return;
//     }

//     if (!long.TryParse(inputB?.Trim(), out long b))
//     {
//       Console.WriteLine("Ikkinchi kiritishda xatolik. Iltimos butun son kiriting: ");
//       return;
//     }

//     try
//     {
//       long sum = checked(a + b);
//       Console.WriteLine($"Natija: {sum}");
//     }
//     catch (OverflowException)
//     {
//       Console.WriteLine("Xatolik: Qiyamt yig'indisi long tipidan chiqib ketdi");
//     }
//   }
// }


// O(1)
// class Program2
// {
//   static void Main()
//   {
//     int[] numbers = { 10, 20, 30, 40, 50 };

//     int value = numbers[2];

//     Console.WriteLine("Qiymat: " + value);
//   }
// }


// O(log n)
// class Program3
// {
//   static void Main()
//   {
//     int[] numbers = { 2, 4, 6, 8, 9, 10, 12, 14, 16, 18, 20 };

//     int target = 2;
//     int left = 0;
//     int right = numbers.Length - 1;

//     while (left <= right)
//     {
//       int mid = (left + right) / 2;

//       if (numbers[mid] == target)
//       {
//         Console.WriteLine($"Qiymat topildi: {numbers[mid]} (index {mid})");
//         return;
//       }
//       else if (numbers[mid] < target)
//       {
//         left = mid + 1;
//       }
//       else
//       {
//         right = mid - 1;
//       }
//     }
//     Console.WriteLine("Qiymat topilmadi");
//   }
// }


// O(n)
// class Program
// {
//   static void Main()
//   {
//     int[] numbers = { 2, 4, 6, 8, 10 };
//     int sum = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
//       sum += numbers[i];
//     }

//     Console.WriteLine("Yig'indi: " + sum);
//   }
// }


// O(n²)
// class Program4
// {
//   static void Main()
//   {
//     int[] numbers = { 5, 2, 9, 1, 5 };

//     for (int i = 0; i < numbers.Length; i++)
//     {
//       for (int j = 0; j < numbers.Length - 1; j++)
//       {
//         if (numbers[j] > numbers[j + 1])
//         {
//           int temp = numbers[j];
//           numbers[j] = numbers[j + 1];
//           numbers[j + 1] = temp;
//         }
//       }
//     }
//     Console.WriteLine("Saralangan array: ");
//     foreach (var num in numbers)
//     {
//       Console.WriteLine(num + " ");
//     }
//   }
// }

// O(n**3)
// class Program5
// {
//   static void Main()
//   {
//     int n = 3;
//     int[,,] cube = new int[n, n, n];

//     int count = 1;

//     for (int i = 0; i < n; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         for (int k = 0; k < n; k++)
//         {
//           cube[i, j, k] = count;
//           Console.WriteLine($"cube[{i},{j},{k}] = {count}");
//           count++;
//         }
//       }
//     }
//   }
// }

// class Program6
// {
//   static void Subsets(int[] nums, List<int> current, int index)
//   {
//     if (index == nums.Length)
//     {
//       Console.WriteLine(string.Join(" ", current));
//       return;
//     }

//     Subsets(nums, current, index + 1);

//     current.Add(nums[index]);
//     Subsets(nums, current, index + 1);
//     current.RemoveAt(current.Count - 1);
//   }

//   static void Main()
//   {
//     int[] nums = { 1, 2, 3 };
//     Subsets(nums, new List<int>(), 0);
//   }
// }


// O(n!)



// class Program7
// {
//   // constant-time access
//   public static int GetElementAt(int[] arr, int index)
//   {
//     if (arr == null) throw new ArgumentNullException(nameof(arr));
//     if (index < 0 || index >= arr.Length) throw new IndexOutOfRangeException();
//     return arr[index];
//   }

//   // Linear search
//   public static int LinearSearch(int[] arr, int target)
//   {
//     if (arr == null) return -1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if (arr[i] == target) return i;
//     }
//     return -1;
//   }

//   // Binary search
//   public static int BinarySearch(int[] sortedArr, int target)
//   {
//     if (sortedArr == null) return -1;
//     int low = 0, high = sortedArr.Length - 1;
//     while (low <= high)
//     {
//       int mid = low + (high - low) / 2;
//       if (sortedArr[mid] == target) return mid;
//       if (sortedArr[mid] < target) low = mid + 1;
//       else high = mid - 1;
//     }
//     return -1;
//   }

//   public static void SelectionSort(int[] arr)
//   {
//     if (arr == null) return;
//     int n = arr.Length;
//     for (int i = 0; i < n - 1; i++)
//     {
//       int minIndex = i;

//       for (int j = i + 1; j < n; j++)
//       {
//         if (arr[j] < arr[minIndex]) minIndex = j;
//       }

//       if (minIndex != i)
//       {
//         int temp = arr[i];
//         arr[i] = arr[minIndex];
//         arr[minIndex] = temp;
//       }
//     }
//   }

//   static void Main()
//   {
//     // int[] arr = new int[] { 2, 7, 11, 15 };
//     // Console.WriteLine("GetElementAt(arr, 2) " + GetElementAt(arr, 2));

//     // Console.WriteLine("LinearSearch(arr, 11) = " + LinearSearch(arr, 11));
//     // Console.WriteLine("LinearSearch(arr, 5) = " + LinearSearch(arr, 5));

//     // int[] sorted = new int[] { 1, 3, 5, 7, 9, 11 };
//     // Console.WriteLine("Binary: " + BinarySearch(sorted, 7));
//     // Console.WriteLine("Binary: " + BinarySearch(sorted, 2));

//     // int[] toSort = new int[] { 64, 25, 12, 22, 11 };
//     // SelectionSort(toSort);
//     // Console.WriteLine("SelectionSort: " + string.Join(",", toSort));

//   }
// }


// class Program8
// {
//   static int GetElementAt(int[] arr, int index)
//   {
//     if (arr == null) return -1;
//     if (index < 0 || index >= arr.Length) throw new IndexOutOfRangeException();
//     return arr[index];
//   }

//   static int LinearSearch(int[] arr, int target)
//   {
//     if (arr == null) return -1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if (arr[i] == target) return i;
//     }
//     return -1;
//   }
//   static void Main()
//   {
//     int[] arr = { 1, 2, 3, 4 };
//     Console.WriteLine("Index Access: " + GetElementAt(arr, 3));
//     Console.WriteLine("Linear search: " + LinearSearch(arr, 3));
//   }
// }

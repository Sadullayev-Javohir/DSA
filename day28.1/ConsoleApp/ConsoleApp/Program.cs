// class Program
// {
//     static List<int[]> Merge(int[][] intervals)
//     {
//         Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
//
//         var merged = new List<int[]>() {intervals[0]};
//         foreach (var curr in intervals)
//         {
//             var last = merged[merged.Count - 1];
//
//             if (curr[0] <= last[1]) last[1] = Math.Max(curr[1], last[1]);
//             else merged.Add(curr);
//         }
//
//         return merged;
//     }
//     static void Main()
//     {
//         int[][] intervals = new int[][]
//         {
//             new int[] {1, 3},
//             new int[] {2, 5},
//             new int[] {7, 8},
//             new int[] {9, 10},
//         };
//
//         var result = Merge(intervals);
//         
//         foreach (var interval in result)
//         {
//             Console.WriteLine($"[{interval[0]}, {interval[1]}]");
//         }
//     }
// }


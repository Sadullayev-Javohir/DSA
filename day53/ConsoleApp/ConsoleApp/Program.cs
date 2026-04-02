// public class Graph
// {
//     private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
//
//     public void AddEdge(int v1, int v2, bool isDirected = false)
//     {
//         if (!adjList.ContainsKey(v1)) adjList[v1] = new List<int>();
//         if (!adjList.ContainsKey(v2)) adjList[v2] = new List<int>();
//
//         adjList[v1].Add(v2);
//         if (!isDirected) adjList[v2].Add(v1);
//     }
//
//     public void BFS(int start)
//     {
//         var queue = new Queue<int>();
//         var visited = new HashSet<int>();
//         queue.Enqueue(start);
//         visited.Add(start);
//
//         while (queue.Count > 0)
//         {
//             var node = queue.Dequeue();
//             Console.Write(node + " ");
//             foreach (var neighbor in adjList[node])
//             {
//                 if (!visited.Contains(neighbor))
//                 {
//                     queue.Enqueue(neighbor);
//                     visited.Add(neighbor);
//                 }
//             }
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Graph g = new Graph();
//         g.AddEdge(1, 2);
//         g.AddEdge(1, 3);
//         g.AddEdge(2, 4);
//         g.AddEdge(3, 5);
//         
//         Console.WriteLine("BFS traversal: ");
//         g.BFS(1);       
//     }
// }

// class MatrixGraph
// {
//     private int[,] matrix;
//     private int size;
//
//     public MatrixGraph(int size) {
//         this.size = size;
//         matrix = new int[size, size];
//     }
//
//     public void Add(int v1, int v2, bool isDirected = false)
//     {
//         matrix[v1, v2] = 1;
//         if (!isDirected) matrix[v2, v1] = 1;
//     }
//
//     public void Print()
//     {
//         for (int i = 0; i < size; i++)
//         {
//             for (int j = 0; j < size; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         MatrixGraph m = new MatrixGraph(4);
//         m.Add(1, 2);
//         m.Add(0, 3);
//         m.Print();
//     }
// }

class Graph
{
    private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

    public void AddEdge(int v1, int v2)
    {
        if (!adjList.ContainsKey(v1)) adjList[v1] = new List<int>();
        if (!adjList.ContainsKey(v2)) adjList[v2] = new List<int>();
        
        adjList[v1].Add(v2);
        adjList[v2].Add(v1);
    }

    public void DFS(int start, HashSet<int> visited)
    {
        Console.Write(start + " ");
        visited.Add(start);

        foreach (var neighbor in adjList[start])
        {
            if (!visited.Contains(neighbor)) DFS(neighbor, visited);
        }
    }

    public void DFS_Iterative(int start)
    {
        var stack = new Stack<int>();
        var visited = new HashSet<int>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            int node = stack.Pop();
            if (!visited.Contains(node))
            {
                Console.Write(node + " ");
                visited.Add(node);

                foreach (var neighbor in adjList[node])
                {
                    if (!visited.Contains(neighbor)) stack.Push(neighbor);
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph();
        
        g.AddEdge(1, 2);
        g.AddEdge(1, 3);
        g.AddEdge(2, 4);
        g.AddEdge(3, 5);
        g.DFS(1, new HashSet<int>());
    }
}
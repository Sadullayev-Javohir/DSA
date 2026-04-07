// using System.Collections;
//
// class Graph
// {
//     private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
//
//     public void AddEdge(int v1, int v2)
//     {
//         if (!adjList.ContainsKey(v1)) adjList[v1] = new List<int>();
//         if (!adjList.ContainsKey(v2)) adjList[v2] = new List<int>();
//
//         adjList[v1].Add(v2);
//     }
//
//     public void BFS(int start)
//     {
//         var visited = new HashSet<int>();
//         var queue = new Queue<int>();
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
//
//     public void DFS(int start, HashSet<int> visited)
//     {
//         Console.Write(start + " ");
//         visited.Add(start);
//         foreach (var neighbor in adjList[start])
//         {
//             if (!visited.Contains(neighbor)) DFS(neighbor, visited);
//         }
//     }
//
//     public void DFSIterative(int start)
//     {
//         var visited = new HashSet<int>();
//         var stack = new Stack<int>();
//         stack.Push(start);
//
//
//         while (stack.Count > 0)
//         {
//             var node = stack.Pop();
//             if (!visited.Contains(node))
//             {
//                 Console.Write(node + " ");
//                 visited.Add(node);
//             }
//
//             foreach (var neighbor in adjList[node])
//             {
//                 if (!visited.Contains(neighbor)) stack.Push(neighbor);
//             }
//         }
//     }
//
//     public List<int> TopologicalSortBFS(int V, List<int>[] adj)
//     {
//         int[] indegree = new int[V];
//
//         for (int i = 0; i < V; i++)
//         {
//             foreach (var neighbor in adj[i])
//             {
//                 indegree[neighbor]++;
//             }
//         }
//
//         var queue = new Queue<int>();
//         for (int i = 0; i < V; i++)
//         {
//             if (indegree[i] == 0) queue.Enqueue(i);
//         }
//
//         var result = new List<int>();
//         while (queue.Count > 0)
//         {
//             var node = queue.Dequeue();
//             result.Add(node);
//             foreach (var neighbor in adj[node])
//             {
//                 indegree[neighbor]--;
//                 if (indegree[neighbor] == 0) queue.Enqueue(neighbor);
//             }
//         }
//
//         if (V != result.Count) Console.WriteLine("Cycle mavjud");
//
//         return result;
//     }
//
//     public void DFS(int node, bool[] visited, Stack<int> stack, List<int>[] adj)
//     {
//         visited[node] = true;
//
//         foreach (var neighbor in adj[node])
//         {
//             if (!visited[neighbor]) DFS(neighbor, visited, stack, adj);
//         }
//         stack.Push(node);
//     }
//
//     public List<int> TopologicalSortDFS(int V, List<int>[] adj)
//     {
//         bool[] visited = new bool[V];
//         Stack<int> stack = new Stack<int>();
//
//         for (int i = 0; i < V; i++)
//         {
//             if (!visited[i]) DFS(i, visited, stack, adj);
//         }
//
//         List<int> result = new List<int>();
//         while (stack.Count > 0) result.Add(stack.Pop());
//         
//         return result;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         // Console.WriteLine("BFS: ");
//         // // g.BFS(0);
//         // // g.DFS(0, new HashSet<int>());
//         // g.DFSIterative(0);
//
//         int V = 4;
//         List<int>[] adj = new List<int>[V];
//         for (int i = 0; i < V; i++) adj[i] = new List<int>();
//         adj[0].Add(1);
//         adj[0].Add(2);
//         adj[1].Add(3);
//         adj[2].Add(3);
//
//         Graph g = new Graph();
//         List<int> sorted = g.TopologicalSortDFS(V, adj);
//
//
//         Console.WriteLine("Topoligical sort: ");
//         foreach (var node in sorted)
//         {
//             Console.Write(node + " ");
//         }
//     }
// }

using System.Collections;
using System.Runtime.InteropServices;

class Program
{
    static void BFS(int start, List<int>[] adj)
    {
        var queue = new Queue<int>();
        bool[] visited = new bool[4];

        queue.Enqueue(start);
        visited[start] = true;

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            Console.Write(node + " ");
            foreach (var neighbor in adj[node])
            {
                if (!visited[neighbor])
                {
                    queue.Enqueue(neighbor);
                    visited[neighbor] = true;
                }
            }
        }
    }

    static void DFS(int node, List<int>[] adj, bool[] visited)
    {
        visited[node] = true;
        Console.Write(node + " ");

        foreach (var neighbor in adj[node])
        {
            if (!visited[neighbor]) DFS(neighbor, adj, visited);
        }
    }

    static List<int> TopologicalSort(List<int>[] adj, int V)
    {
        int[] indegree = new int[V];

        for (int i = 0; i < V; i++)
        {
            foreach (var neighbor in adj[i])
            {
                indegree[neighbor]++;
            }
        }

        var queue = new Queue<int>();
        for (int i = 0; i < V; i++)
        {
            if (indegree[i] == 0) queue.Enqueue(i);
        }

        var list = new List<int>();

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            list.Add(node);

            foreach (var neighbor in adj[node])
            {
                indegree[neighbor]--;
                if (indegree[neighbor] == 0) queue.Enqueue(neighbor);
            }
        }

        return list;
    }

    static void DFSHelper(int node, bool[] visited, Stack<int> stack, List<int>[] adj)
    {
        visited[node] = true;

        foreach (var neighbor in adj[node])
        {
            if (!visited[neighbor]) DFSHelper(neighbor, visited, stack, adj);
        }
        
        stack.Push(node);
    }

    static List<int> TopologicalSortDFS(int V, List<int>[] adj)
    {
        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            if (!visited[i]) DFSHelper(i, visited, stack, adj);
        }

        var result = new List<int>();
        while (stack.Count > 0)
        {
            result.Add(stack.Pop());
        }
        return result;
    }
    
    static void Main()
    {
        int V = 4;
        List<int>[] adj = new List<int>[V];

        for (int i = 0; i < V; i++) adj[i] = new List<int>();

        adj[0].Add(1);
        adj[0].Add(2);
        adj[1].Add(3);
        adj[2].Add(3);

        // BFS(0, adj);

        // bool[] visited = new bool[4];
        // DFS(0, adj, visited);
        var result = TopologicalSortDFS(V, adj);
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
    }
}
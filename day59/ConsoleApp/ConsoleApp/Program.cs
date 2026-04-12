// class Program
// {
//     static void Main()
//     {
//         var graph = new Dictionary<string, List<(string, int)>>()
//         {
//             ["A"] = new List<(string, int)>() {("B", 5), ("C", 2)},
//             ["B"] = new List<(string, int)>() {("D", 1)},
//             ["C"] = new List<(string, int)>() {("B", 1), ("D", 7)},
//             ["D"] = new List<(string, int)>()
//         };
//         
//         Djikstra(graph, "A");
//     }
//
//     static void Djikstra(Dictionary<string, List<(string, int)>> graph, string start)
//     {
//         var distances = new Dictionary<string, int>();
//         var pq = new PriorityQueue<string, int>();
//
//         foreach (var node in graph.Keys)
//         {
//             distances[node] = int.MaxValue;
//         }
//
//         distances[start] = 0;
//         pq.Enqueue(start, 0);
//
//         while (pq.Count > 0)
//         {
//             var current = pq.Dequeue();
//             foreach (var (neighbor, weight) in graph[current])
//             {
//                 int newDist = distances[current] + weight;
//                 if (newDist < distances[neighbor])
//                 {
//                     distances[neighbor] = newDist;
//                     pq.Enqueue(neighbor, newDist);
//                 }
//             }
//         }
//
//         foreach (var d in distances)
//         {
//             Console.WriteLine($"{d.Key} : {d.Value}");
//         }
//     }
//     
// }

// class Program
// {
//     static void BellmanFord(List<(string u, string v, int w)> edges, List<string> nodes, string start)
//     {
//         var dist = new Dictionary<string, int>();
//
//         foreach (var node in nodes)
//         {
//             dist[node] = int.MaxValue;
//         }
//
//         dist[start] = 0;
//
//         for (int i = 0; i < nodes.Count - 1; i++)
//         {
//             foreach (var (u, v, w) in edges)
//             {
//                 if (dist[u] != int.MaxValue && dist[u] + w < dist[v])
//                 {
//                     dist[v] = dist[u] + w;
//                 }
//             }
//         }
//         
//         foreach (var (u, v, w) in edges)
//         {
//             if (dist[u] != int.MaxValue && dist[u] + w < dist[v])
//             {
//                 Console.WriteLine("Cycle bor");
//                 return;
//             }
//         }
//
//         foreach (var d in dist)
//         {
//             Console.WriteLine($"{d.Key} : {d.Value}");
//         }
//     }
//     static void Main()
//     {
//         var nodes = new List<string> { "A", "B", "C", "D" };
//         var edges = new List<(string, string, int)>
//         {
//             ("A", "B", 4),
//             ("A", "C", 2),
//             ("C", "B", -3),
//             ("B", "D", 2),
//         };
//
//         BellmanFord(edges, nodes, "A");
//     }
// }

// class Program
// {
//     static void BellmanFord(int vertices, List<(int u, int v, int w)> edges, int start)
//     {
//         int[] dist = new int[vertices];
//
//         for (int i = 0; i < vertices; i++)
//         {
//             dist[i] = int.MaxValue;
//         }
//
//         dist[start] = 0;
//         for (int i = 0; i < vertices - 1; i++)
//         {
//             foreach (var (u, v, w) in edges)
//             {
//                 if (dist[u] != int.MaxValue && dist[u] + w < dist[v]) dist[v] = dist[u] + w;
//             }
//         }
//
//         foreach (var (u, v, w) in edges)
//         {
//             if (dist[u] != int.MaxValue && dist[u] + w < dist[v])
//             {
//                 Console.WriteLine("Cycle mavjud");
//                 return;
//             }
//         }
//         
//         for (int i =0 ; i < vertices; i++)
//             Console.WriteLine($"Node {i}: {dist[i]}");
//     }
//     static void Main()
//     {
//         var graph = new List<(int, int, int)>()
//         {
//             (0, 1, 4),
//             (0, 2, 5),
//             (1, 2, -3),
//             (2, 3, 2)
//         };
//         BellmanFord(4, graph, 0);
//     }
// }

// class Program
// {
//     static void BellManFord(List<string> graph, List<(string from, string to, int weight)> edges, string start)
//     {
//         var dist = new Dictionary<string, int>();
//         foreach (var node in graph)
//         {
//             dist[node] = int.MaxValue;
//         }
//
//         dist[start] = 0;
//
//         for (int i = 0; i < dist.Count - 1; i++)
//         {
//             foreach (var (from, to, weight) in edges)
//             {
//                 if (dist[from] != int.MaxValue && dist[from] + weight < dist[to])
//                 {
//                     dist[to] = dist[from] + weight;
//                 }
//             }
//         }
//
//         foreach (var (from, to, weight) in edges)
//         {
//             if (dist[from] != int.MaxValue && dist[from] + weight < dist[to])
//             {
//                 Console.WriteLine("Cycle has");
//                 return;
//             }
//         }
//
//         foreach (var d in dist)
//         {
//             Console.WriteLine($"{d.Key} : {d.Value}");
//         }
//     }
//     static void Main()
//     {
//         var graph = new List<string>() { "A", "B", "C", "D" };
//
//         var edges = new List<(string, string, int)>()
//         {
//            ("A", "B", 4),
//            ("A", "C", 2),
//            ("B", "D", 2),
//            ("C", "B", -3)
//         };
//         
//         BellManFord(graph, edges, "A");
//         
//         
//     }
// }

class Program
{
    static void BellmanFord(List<(string from, string to, int weight)> edges, List<string> graph, string start)
    {
        var dist = new Dictionary<string, int>();

        foreach (var node in graph)
        {
            dist[node] = int.MaxValue;
        }

        dist[start] = 0;

        for (int i = 0; i < dist.Count - 1; i++)
        {
            foreach ( var (from, to, weight) in edges)
            {
                if (dist[from] != int.MaxValue && dist[from] + weight < dist[to])
                {
                    dist[to] = dist[from] + weight;
                }
            }
        }
        
        foreach ( var (from, to, weight) in edges)
        {
            if (dist[from] != int.MaxValue && dist[from] + weight < dist[to])
            {
                Console.WriteLine("cycle bor");
                return;
            }
        }

        foreach (var d in dist)
        {
            Console.WriteLine($"{d.Key} : {d.Value}");
        }
    }
    static void Main()
    {
        var graph = new List<string>() { "A", "B", "C", "D" };

        var edges = new List<(string, string, int)>()
        {
            ("A", "B", 4),
            ("A", "C", 2),
            ("B", "D", 2),
            ("C", "B", -3)
        };

        BellmanFord(edges, graph, "A");
    }
}
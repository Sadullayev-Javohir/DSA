// public class Graph
// {
//     private Dictionary<int, List<int>> adjList;
//
//     public Graph() => adjList = new Dictionary<int, List<int>>();
//
//     public void AddVertex(int v)
//     {
//         if (!adjList.ContainsKey(v)) adjList[v] = new List<int>();
//     }
//
//     public void AddEdge(int v1, int v2)
//     {
//         if (!adjList.ContainsKey(v1)) AddVertex(v1);
//         if (!adjList.ContainsKey(v2)) AddVertex(v2);
//         
//         adjList[v1].Add(v2);
//         adjList[v2].Add(v1);
//     }
//
//     public void PrintGraph()
//     {
//         foreach (var vertex in adjList)
//         {
//             Console.Write(vertex.Key + " -> ");
//             foreach (var neighbor in vertex.Value)
//             {
//                 Console.Write(neighbor + " ");
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
//         Graph g = new Graph();
//         
//         g.AddEdge(1, 2);
//         g.AddEdge(1, 3);
//         g.AddEdge(2, 4);
//         
//         g.PrintGraph();
//     }
// }

// class Graph
// {
//     private Dictionary<int, List<int>> adjList;
//     public Graph() => adjList = new Dictionary<int, List<int>>();
//
//     private void AddVertex(int v)
//     {
//         if (!adjList.ContainsKey(v)) adjList[v] = new List<int>();
//     }
//
//     public void AddEdge(int v1, int v2)
//     {
//         if (!adjList.ContainsKey(v1)) adjList[v1] = new List<int>();
//         if (!adjList.ContainsKey(v2)) adjList[v2] = new List<int>();
//         
//         adjList[v1].Add(v2);
//         adjList[v2].Add(v1);
//     }
//
//     public void PrintGraph()
//     {
//         if (adjList == null) return;
//
//         foreach (var vertex in adjList)
//         {
//             Console.Write(vertex.Key + " -> ");
//             foreach (var neighbor in vertex.Value)
//             {
//                 Console.Write(neighbor + " ");
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
//         Graph g = new Graph();
//         
//         g.AddEdge(1, 2);
//         g.AddEdge(2, 3);
//         g.AddEdge(3, 1);
//         
//         g.PrintGraph();
//     }
// }

class DirectedGraph
{
    private Dictionary<int, List<int>> adjList;
    public DirectedGraph() => adjList = new Dictionary<int, List<int>>();

    private void addVertex(int v)
    {
        if (!adjList.ContainsKey(v)) adjList[v] = new List<int>();
    }

    public void AddEdge(int from, int to)
    {
        if (!adjList.ContainsKey(from)) adjList[from] = new List<int>();
        if (!adjList.ContainsKey(to)) adjList[to] = new List<int>();
        
        adjList[from].Add(to);
    }

    public void PrintGraph()
    {
        if (adjList == null) return;

        foreach (var vertex in adjList)
        {
            Console.Write(vertex.Key + " => ");
            foreach (var neighbor in vertex.Value)
            {
                Console.Write(neighbor + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        DirectedGraph dg = new DirectedGraph();
        
        dg.AddEdge(1, 2);
        dg.AddEdge(1, 3);
        dg.AddEdge(2, 4);
        
        dg.PrintGraph();
    }
}
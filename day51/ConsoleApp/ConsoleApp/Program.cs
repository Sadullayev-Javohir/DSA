// class GraphMatrix
// {
//     private int[,] matrix;
//     private int size;
//
//     public GraphMatrix(int size)
//     {
//         this.size = size;
//         matrix = new int[size, size];
//     }
//
//     public void AddEdge(int v1, int v2, bool isDirected = false)
//     {
//         matrix[v1, v2] = 1;
//
//         if (!isDirected) matrix[v2, v1] = 1;
//     }
//
//     public bool HasEdge(int v1, int v2) => matrix[v1, v2] == 1;
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
//         var graph = new GraphMatrix(4);
//         
//         graph.AddEdge(0, 1, true);
//         graph.AddEdge(0, 2, true);
//         graph.AddEdge(1, 3, true);
//         graph.AddEdge(2, 3, true);
//
//         graph.Print();
//         // Console.WriteLine(graph.HasEdge(1, 1));
//     }
// }

// class GraphMatrix
// {
//     public int size;
//     public int[,] matrix;
//
//     public GraphMatrix(int size)
//     {
//         this.size = size;
//         matrix = new int[size, size];
//     }
//
//     public void Add(int v1, int v2, bool isDirected = false)
//     {
//         matrix[v1, v2] = 1;
//
//         if (!isDirected) matrix[v2, v1] = 1;
//     }
//
//     public bool HasEdge(int v1, int v2) => matrix[v1, v2] == 1;
//
//     public void Print()
//     {
//         for (int i = 0; i < size; i++)
//         {
//             for (int j = 0; j < size; j++)
//             {
//                 Console.Write($"{matrix[i, j]} ");
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
//         GraphMatrix g = new GraphMatrix(4);
//         g.Add(0, 1, true);
//         g.Add(0, 2, true);
//         g.Add(1, 3, true);
//         g.Add(2, 3, true);
//         g.Add(3, 3, true);
//         
//         g.Print();
//         Console.WriteLine(g.HasEdge(3, 3));
//         
//     }
// }

class GraphList
{
    public Dictionary<int, List<int>> adjacencyList;
    public GraphList() => adjacencyList = new Dictionary<int, List<int>>();

    public void AddVertex(int v)
    {
        if (!adjacencyList.ContainsKey(v)) adjacencyList[v] = new List<int>();
    }

    public void AddEdge(int v1, int v2, bool isDirected = false)
    {
        AddVertex(v1);
        AddVertex(v2);
        
        adjacencyList[v1].Add(v2);
        
        if (!isDirected) adjacencyList[v2].Add(v1);
    }

    public bool HasEdge(int v1, int v2)
    {
        if (!adjacencyList.ContainsKey(v1)) return false;
        return adjacencyList[v1].Contains(v2);
    }

    public void Print()
    {
        foreach (var vertex in adjacencyList)
        {
            Console.Write(vertex.Key + " -> ");
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
        GraphList g = new GraphList();
        
        g.AddEdge(2, 3);
        g.AddEdge(4, 3);
        g.AddEdge(1, 3);
        g.AddEdge(0, 0);
        
        g.Print();
        Console.WriteLine(g.HasEdge(0, 0));
    }
}
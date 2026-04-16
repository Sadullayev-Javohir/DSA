// class Program
// {
//     static void BellmanFord(List<string> graph, List<(string, string, int)> edges, string start)
//     {
//         var dists = new Dictionary<string, int>();
//         foreach (var node in graph)
//         {
//             dists[node] = int.MaxValue;
//         }
//
//         dists[start] = 0;
//
//         for (int i = 0; i < dists.Count; i++)
//         {
//             foreach (var (from, to, weight) in edges)
//             {
//                 if (dists[from] != int.MaxValue && dists[from] + weight < dists[to])
//                 {
//                     dists[to] = dists[from] + weight;
//                 }
//             }
//         }
//         foreach (var (from, to, weight) in edges)
//         {
//             if (dists[from] != int.MaxValue && dists[from] + weight < dists[to])
//             {
//                 Console.WriteLine("Cycle bor");
//                 return;
//             }
//         }
//
//         foreach (var node in dists)
//         {
//             Console.WriteLine($"{node.Key} : {node.Value}");
//         }
//     }
//     static void Main()
//     {
//         var graph = new List<string>() { "A", "B", "C", "D" };
//         var edges = new List<(string, string, int)>()
//         {
//             ("A", "B", 4),
//             ("A", "C", 2),
//             ("B", "D", 2),
//             ("C", "B", -3)
//         };
//
//         BellmanFord(graph, edges, "A");
//     }
// }

// class Node
// {
//     public int X, Y;
//     public int G, H;
//     public int F => G + H;
//     public Node Parent;
//
//     public Node(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
// }

// class AStar
// {
//     private static int[,] grid =
//     {
//         {0, 0, 0, 0, 0},
//         {0, 1, 1, 1, 0},
//         {0, 0, 0, 1, 0},
//         {0, 1, 0, 0, 0},
//         {0, 0, 0, 1, 0}
//     };
//
//     private static int rows = grid.GetLength(0);
//     private static int cols = grid.GetLength(1);
//
//     static List<Node> GetNeighbors(Node node)
//     {
//         int[] dx = { 0, 1, 0, -1 };
//         int[] dy = { 1, 0, -1, 0 };
//
//         var neighbors = new List<Node>();
//
//         for (int i = 0; i < 4; i++)
//         {
//             int nx = node.X + dx[i];
//             int ny = node.Y + dy[i];
//
//             if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && grid[nx, ny] == 0)
//             {
//                 neighbors.Add(new Node(nx, ny));
//             }
//         }
//
//         return neighbors;
//     }
//
//     static int Heuristic(Node a, Node b)
//     {
//         return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
//     }
//     
//     public static 
// }

// class Program
// {
//     private static int[,] grid =
//     {
//         { 0, 0, 0, 0, 0 },
//         { 0, 1, 1, 1, 0 },
//         { 0, 0, 0, 1, 0 },
//         { 0, 1, 0, 0, 0 },
//         { 0, 0, 0, 1, 0 }
//     };
//
//     static void Main()
//     {
//         int x = 2, y = 2;
//         int[] dx = { 0, 1, 0, -1 };
//         int[] dy = { 1, 0, -1, 0 };
//
//         int rows = grid.GetLength(0);
//         int cols = grid.GetLength(1);
//         
//         Console.WriteLine($"Current Node: ({x}, {y})");
//         Console.WriteLine("Valid moves: ");
//         for (int i = 0; i < 4; i++)
//         {
//             int newX = x + dx[i];
//             int newY = y + dy[i];
//
//             if (newX >= 0 && newY >= 0 && newX < rows && newY < cols && grid[newX, newY] == 0)
//             {
//                 Console.WriteLine($"({newX}, {newY})");
//             }
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Node start = new Node(2, 2);
//         Node goal = new Node(5, 5);
//
//         int h = Heuristic(start, goal);
//         
//         
//     }
//
//     static int Heuristic(Node a, Node b)
//     {
//         return Math.Abs(a.X - b.X) + Math.Abs(a.Y + b.Y);
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         Node start = new Node(0, 0);
//
//         Node a = new Node(0, 1);
//         a.Parent = start;
//         
//         Node b = new Node(0, 2);
//         b.Parent = a;
//
//         Node goal = b;
//
//         var path = ReconstructPath(goal);
//         
//         Console.WriteLine("Path: ");
//         foreach (var node in path)
//         {
//             Console.WriteLine($"({node.X}, {node.Y})");
//         }
//     }
//
//     static List<Node> ReconstructPath(Node node)
//     {
//         var path = new List<Node>();
//
//         while (node != null)
//         {
//             path.Add(node);
//             node = node.Parent;
//         }
//
//         path.Reverse();
//         return path;
//     }
// }


using System.ComponentModel;

// class Node
// {
//     public int X, Y;
//     public Node Parent;
//     public int G, H;
//     public int F => G + H;
//
//     public Node(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Node n1 = new Node(0, 0);
//         Node n2 = new Node(1, 0);
//         Node n3 = new Node(2, 0);
//
//         n2.Parent = n1;
//         n3.Parent = n2;
//
//         var path = new List<Node>();
//
//         Node curr = n3;
//
//         while (curr != null)
//         {
//             path.Add(curr);
//             curr = curr.Parent;
//         }
//
//         path.Reverse();
//
//         foreach (var n in path)
//         {
//             Console.WriteLine($"({n.X},{n.Y})");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var closedList = new HashSet<string>();
//         closedList.Add("1,1");
//
//         Node neighbor = new Node(1, 1);
//         if (closedList.Contains($"{neighbor.X},{neighbor.Y}"))
//         {
//             Console.WriteLine("Bu node allaqachon mavjud");
//         }
//         else
//         {
//             Console.WriteLine("Yangi node");
//         }
//     }
// }

// class Program
// {
//     static int Heuristic(Node a, Node b)
//     {
//         return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
//     }
//
//     static void Main()
//     {
//         Node curr = new Node(0, 0);
//         curr.G = 0;
//
//         Node neighbor = new Node(1, 0);
//
//         int tentativeG = curr.G + 1;
//         int h = Heuristic(neighbor, new Node(4, 4));
//
//         neighbor.G = tentativeG;
//         neighbor.H = h;
//         
//         Console.WriteLine($"Neighbor: ({neighbor.X}, {neighbor.Y})");
//         Console.WriteLine($"G={neighbor.G}, H={neighbor.H}, F = {neighbor.F}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var list = new List<Node>();
//
//         var n1 = new Node(0, 1) { G = 1, H = 5 };
//         var n2 = new Node(1, 0) { G = 2, H = 2 };
//         var n3 = new Node(1, 1) { G = 3, H = 3 };
//         
//         list.Add(n1);
//         list.Add(n2);
//         list.Add(n3);
//
//         Node current = list[0];
//
//         foreach (var node in list)
//         {
//             if (node.F < current.F) current = node;
//         }
//         Console.WriteLine($"Tanlangan: ({current.X}, {current.Y}) F={current.F}");
//     }
// }

// class Program
// {
//     private static int[,] grid =
//     {
//         { 0, 0, 0, },
//         { 0, 1, 0 },
//         { 0, 0, 0 }
//     };
//
//     private static int cols = grid.GetLength(0);
//     private static int rows = grid.GetLength(1);
//
//     static List<Node> GetNeighbors(Node node)
//     {
//         int[] dx = { 0, 1, 0, -1 }, dy = { 1, 0, -1, 0 };
//         var neighbors = new List<Node>();
//
//         for (int i = 0; i < 4; i++)
//         {
//             int nx = node.X + dx[i];
//             int ny = node.Y + dy[i];
//
//             if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && grid[nx, ny] == 0)
//             {
//                 neighbors.Add(new Node(nx, ny));
//             }
//         }
//
//         return neighbors;
//     }
//
//     static void Main()
//     {
//         Node n = new Node(1, 0);
//         var neighbors = GetNeighbors(n);
//         foreach (var item in neighbors)
//         {
//             Console.WriteLine($"({item.X}, {item.Y})");
//         }
//     }
// }

//
// class Program
// {
//     static int Heuristic(Node a, Node b) => Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
//     
//     static void Main()
//     {
//         Node a = new Node(1, 2);
//         Node b = new Node(4, 4);
//
//         int h = Heuristic(a, b);
//         Console.WriteLine($"H = {h}");
//     }
// }

//
// class Program
// {
//     static void Main()
//     {
//         Node node = new Node(2, 3);
//
//         node.G = 5;
//         node.H = 7;
//         
//         Console.WriteLine($"X={node.X}, Y = {node.Y}");
//         Console.WriteLine($"G={node.G}, H = {node.H}, F = {node.F}");
//     }
// }
using System;
using System.Collections.Generic;

// class Node
// {
//     public int X, Y;
//     public int G, H;
//     public int F => G + H;
//     public Node Parent;
//
//     public Node(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
// }
//
// class AStar
// {
//     static int[,] grid =
//     {
//         {0, 0, 0, 0, 0},
//         {0, 1, 1, 1, 0},
//         {0, 0, 0, 1, 0},
//         {0, 1, 0, 0, 0},
//         {0, 0, 0, 1, 0}
//     };
//
//     static int rows = grid.GetLength(0);
//     static int cols = grid.GetLength(1);
//
//     static List<Node> GetNeighbors(Node node)
//     {
//         int[] dx = {0, 1, 0, -1};
//         int[] dy = {1, 0, -1, 0};
//
//         var neighbors = new List<Node>();
//
//         for (int i = 0; i < 4; i++)
//         {
//             int nx = node.X + dx[i];
//             int ny = node.Y + dy[i];
//
//             if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && grid[nx, ny] == 0)
//             {
//                 neighbors.Add(new Node(nx, ny));
//             }
//         }
//
//         return neighbors;
//     }
//
//     static int Heuristic(Node a, Node b)
//     {
//         // Manhattan Distance
//         return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
//     }
//
//     public static List<Node> FindPath(Node start, Node goal)
//     {
//         var openList = new List<Node>();
//         var closedList = new HashSet<string>();
//
//         openList.Add(start);
//
//         while (openList.Count > 0)
//         {
//             // Eng kichik F ni topamiz
//             Node current = openList[0];
//             foreach (var node in openList)
//                 if (node.F < current.F)
//                     current = node;
//
//             if (current.X == goal.X && current.Y == goal.Y)
//                 return ReconstructPath(current);
//
//             openList.Remove(current);
//             closedList.Add($"{current.X},{current.Y}");
//
//             foreach (var neighbor in GetNeighbors(current))
//             {
//                 if (closedList.Contains($"{neighbor.X},{neighbor.Y}"))
//                     continue;
//
//                 int tentativeG = current.G + 1;
//
//                 Node existing = openList.Find(n => n.X == neighbor.X && n.Y == neighbor.Y);
//
//                 if (existing == null)
//                 {
//                     neighbor.G = tentativeG;
//                     neighbor.H = Heuristic(neighbor, goal);
//                     neighbor.Parent = current;
//                     openList.Add(neighbor);
//                 }
//                 else if (tentativeG < existing.G)
//                 {
//                     existing.G = tentativeG;
//                     existing.Parent = current;
//                 }
//             }
//         }
//
//         return null; // yo‘l topilmadi
//     }
//
//     static List<Node> ReconstructPath(Node node)
//     {
//         var path = new List<Node>();
//         while (node != null)
//         {
//             path.Add(node);
//             node = node.Parent;
//         }
//         path.Reverse();
//         return path;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Node start = new Node(0, 0);
//         Node goal = new Node(4, 4);
//
//         var path = AStar.FindPath(start, goal);
//
//         if (path == null)
//         {
//             Console.WriteLine("Yo‘l topilmadi!");
//             return;
//         }
//
//         Console.WriteLine("Topilgan yo‘l:");
//         foreach (var node in path)
//         {
//             Console.WriteLine($"({node.X}, {node.Y})");
//         }
//     }
// }

class Node
{
    public int X, Y;
    public int G, H;
    public int F => G + H;
    public Node Parent;

    public Node(int x, int y)
    {
        X = x;
        Y = y;
    }
}
//
// class Program
// {
//     private static int[,] grid =
//     {
//         { 0, 0, 0 },
//         { 0, 1, 0 },
//         { 0, 0, 0 }
//     };
//
//     static List<Node> GetNeighbors(Node node)
//     {
//         int rows = grid.GetLength(0);
//         int cols = grid.GetLength(1);
//
//         int[] dx = { 0, 1, 0, -1 }, dy = { 1, 0, -1, 0 };
//
//         var list = new List<Node>();
//
//         for (int i = 0; i < 4; i++)
//         {
//             int nx = node.X + dx[i], ny = node.Y + dy[i];
//
//             if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && (grid[nx, ny]) == 0)
//             {
//                 list.Add(new Node(nx, ny));
//             }
//         }
//
//         return list;
//     }
//
//     static int Heuristic(Node a, Node b) => Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
//
//     static void Main()
//     {
//         var openList = new List<Node>();
//         Node current = new Node(0, 0);
//         current.G = 0;
//
//         Node neighbor = new Node(1, 0);
//         int tentativeG = current.G + 1;
//         Node existing = openList.Find(n => n.X == neighbor.X && n.Y == neighbor.Y);
//
//         if (existing == null)
//         {
//             neighbor.G = tentativeG;
//             neighbor.H = 5;
//             neighbor.Parent = current;
//             
//             openList.Add(neighbor);
//             Console.WriteLine("Yangi node qo'shildi");
//         }
// var list = new List<Node>
// {
//     new Node(0, 1){G = 1, H = 5},
//     new Node(1, 0) {G=1, H=2},
//     new Node(1, 1) {G = 2, H = 2}
// };
// Node current = list[0];
//
// foreach (var n in list)
// {
//     if (n.F < current.F) current = n;
// }
// Console.WriteLine($"Tanlandi: ({current.X},{current.Y}) F={current.F}");
// var openList = new List<Node>();
// var closedList = new HashSet<string>();
//
// var n = new Node(0, 0);
//
// openList.Add(n);
// closedList.Add($"{n.X},{n.Y}");
//
// Console.WriteLine("OpenList: 1 ta");
// Console.WriteLine("ClosedList: (0,0)");

// var a = new Node(1, 1);
// var b = new Node(4, 4);
// Console.WriteLine(Heuristic(a, b));
// var result = GetNeighbors(new Node(1, 1));
// foreach (var n in result)
// {
//     Console.WriteLine(n.X + "," + n.Y);
// }
// int rows = grid.GetLength(0);
// int cols = grid.GetLength(1);
// Console.WriteLine($"Rows={rows}, Cols={cols}");
// Console.WriteLine($"(1, 1) = {grid[1, 1]}");
// Node node = new Node(1, 2);
// node.G = 3;
// node.H = 4;
// Console.WriteLine($"F = {node.F}");
//     }
// }

// class AStar
// {
//     private static int[,] grid =
//     {
//         { 0, 0, 0, 0, 0 },
//         { 0, 1, 1, 1, 0 },
//         { 0, 0, 0, 1, 0 },
//         { 0, 1, 0, 0, 0 },
//         { 0, 0, 0, 1, 0 }
//     };
//
//     private static int rows = grid.GetLength(0);
//     private static int cols = grid.GetLength(1);
//
//     static List<Node> GetNeighbors(Node node)
//     {
//         int[] dx = { 0, 1, 0, -1 }, dy = { 1, 0, -1, 0 };
//
//         var neighbors = new List<Node>();
//
//         for (int i = 0; i < 4; i++)
//         {
//             int nx = node.X + dx[i], ny = node.Y + dy[i];
//
//             if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && grid[nx, ny] == 0)
//             {
//                 neighbors.Add(new Node(nx, ny));
//             }
//         }
//
//         return neighbors;
//     }
//     static int Heuristic(Node a, Node b) => Math.Abs(a.X - a.Y) + Math.Abs(b.X - b.Y);
//
//     public static List<Node> FindPath(Node start, Node goal)
//     {
//         var openList = new List<Node>();
//         var closedList = new HashSet<string>();
//
//         openList.Add(start);
//
//         while (openList.Count > 0)
//         {
//             Node current = openList[0];
//             foreach (var n in openList)
//             {
//                 if (n.F < current.F) current = n;
//             }
//
//             if (current.X == goal.X && current.Y == goal.Y) return ReconstructPath(current);
//
//             openList.Remove(current);
//             closedList.Add($"{current.X},{current.Y}");
//
//             foreach (var neighbor in GetNeighbors(current))
//             {
//                 if (closedList.Contains($"{neighbor.X},{neighbor.Y}")) continue;
//
//                 int tentativeG = current.G + 1;
//                 Node existing = openList.Find(n => n.X == neighbor.X && n.Y == neighbor.Y);
//
//                 if (existing == null)
//                 {
//                     neighbor.G = tentativeG;
//                     neighbor.H = Heuristic(neighbor, goal);
//                     neighbor.Parent = current;
//                     openList.Add(neighbor);
//                 }
//                 else if (tentativeG < existing.G)
//                 {
//                     existing.G = tentativeG;
//                     existing.Parent = current;
//                 }
//             }
//         }
//
//         return null;
//     }
//
//     static List<Node> ReconstructPath(Node node)
//     {
//         var path = new List<Node>();
//         while (node != null)
//         {
//             path.Add(node);
//             node = node.Parent;
//         }
//
//         path.Reverse();
//         return path;
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Node start = new Node(0, 0);
//         Node goal = new Node(4, 4);
//
//         var path = AStar.FindPath(start, goal);
//         
//         if (path == null)
//         {
//             Console.WriteLine("Yo'l topilmadi");
//             return;
//         }
//         Console.WriteLine("Topilgan yo'l");
//         foreach (var node in path)
//         {
//             Console.WriteLine($"{node.X}, {node.Y}");
//         }
//     }
// }

class AStar
{
    private static int[,] grid =
    {
        { 0, 0, 0, 0, 0 },
        { 0, 1, 1, 1, 0 },
        { 0, 0, 0, 1, 0 },
        { 0, 1, 0, 0, 0 },
        { 0, 0, 0, 1, 0 }
    };

    private static int rows = grid.GetLength(0);
    private static int cols = grid.GetLength(1);

    static List<Node> GetNeighbors(Node node)
    {
        var neighbors = new List<Node>();

        for(int i = 0; i < 4; i++)
        {
            int[] dx = { 1, 0, -1, 0 }, dy = { 0, 1, 0, -1 };
            int nx = node.X + dx[i], ny = node.Y + dy[i];
            
            if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && (grid[nx, ny]) == 0) neighbors.Add(new Node(nx, ny));
        }

        return neighbors;
    }

    static int Heuristic(Node a, Node b) => Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);

    public static List<Node> FindPath(Node start, Node goal)
    {
        var openList = new List<Node>();
        var closedList = new HashSet<string>();
        
        start.G = 0;
        start.H = Heuristic(start, goal);
        openList.Add(start);

        while (openList.Count > 0)
        {
            var current = openList[0];
            foreach (var n in openList)
            {
                if (n.F < current.F) current = n;
            }

            if (current.X == goal.X && current.Y == goal.Y) return ReconstructPath(current);
            openList.Remove(current);
            closedList.Add($"{current.X},{current.Y}");

            foreach (var neighbor in GetNeighbors(current))
            {
                if (closedList.Contains($"{neighbor.X},{neighbor.Y}")) continue;

                int tentativeG = current.G + 1;
                Node existing = openList.Find(n => n.X == neighbor.X && n.Y == neighbor.Y);
                
                if (existing == null)
                {
                    neighbor.G = tentativeG;
                    neighbor.H = Heuristic(neighbor, goal);
                    neighbor.Parent = current;
                    openList.Add(neighbor);
                }
                else if (tentativeG < existing.G)
                {
                    neighbor.G = existing.G;
                    neighbor.Parent = current;
                }
            }
        }

        return null;
    }

    static List<Node> ReconstructPath(Node node)
    {
        var path = new List<Node>();

        while (node != null)
        {
            path.Add(node);
            node = node.Parent;
        }

        path.Reverse();
        return path;
    }
}

class Program
{
    static void Main()
    {
        Node start = new Node(0, 0), goal = new Node(4, 4);

        var path = AStar.FindPath(start, goal);
        
        if (path == null)
        {
            Console.WriteLine("Yo'l topilmadi");
            return;
        }
        
        Console.WriteLine("Topilgan yo'l: ");
        foreach (var n in path)
        {
            Console.WriteLine($"{n.X}, {n.Y}");
        }
    }
}
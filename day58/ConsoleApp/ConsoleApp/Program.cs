class Program
{
    static void Dijkstra(Dictionary<string, List<(string, int)>> graph, string start)
    {
        var distances = new Dictionary<string, int>();
        var pq = new PriorityQueue<string, int>();

        foreach (var node in graph.Keys)
        {
            distances[node] = int.MaxValue;
        }
        
        pq.Enqueue(start, 0);
        distances[start] = 0;

        while (pq.Count > 0)
        {
            var curr = pq.Dequeue();

            foreach (var (neighbor, weight) in graph[curr])
            {
                int newDist = distances[curr] + weight;

                if (newDist < distances[neighbor])
                {
                    distances[neighbor] = newDist;
                    pq.Enqueue(neighbor, newDist);
                }
            }
        }

        foreach (var node in distances)
        {
            Console.WriteLine($"{node.Key} : {node.Value}");
        }
    }

static void Main()
    {
        var graph = new Dictionary<string, List<(string, int)>>()
        {
            ["A"] = new List<(string, int)> { ("B", 5), ("C", 1)},
            ["B"] = new() {("D", 1)},
            ["C"] = new() {("B", 1), ("D", 7)},
            ["D"] = new()
        };
        Dijkstra(graph, "A");
    }
}
class SocialGraph
{
    private Dictionary<string, List<string>> adjust = new();

    public void AddPerson(string name)
    {
        if (!adjust.ContainsKey(name)) adjust[name] = new List<string>();
    }

    public void AddFriendship(string person1, string person2)
    {
        AddPerson(person1);
        AddPerson(person2);
        adjust[person1].Add(person2);
        adjust[person2].Add(person1);
        
    }

    public List<string> BFS(string start)
    {
        var queue = new Queue<string>();
        var V = adjust.Count;
        Dictionary<string, bool> visited = new Dictionary<string, bool>();
        var result = new List<string>();
        
        queue.Enqueue(start);
        visited[start] = true;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            result.Add(node);
            Console.WriteLine(node + " ");

            foreach (var neighbor in adjust[node])
            {
                if (!visited.ContainsKey(neighbor))
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        SocialGraph socialFriend = new SocialGraph();
        socialFriend.AddFriendship("Ali", "Vali");
        socialFriend.AddFriendship("Vali", "Hasan");
        socialFriend.AddFriendship("Ali", "Karim");

        socialFriend.BFS("Ali");
        for(int i=0;i<5;i++)
        for(int j=0;j<i;j++)
            Console.WriteLine(i+j);
    }
    static int Add(int x, int y = 5)
    {
        return x + y;
    }
}


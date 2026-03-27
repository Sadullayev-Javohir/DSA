// public class TrieNode
// {
//     public char Value { get; set; }
//     public bool IsEndOfWord { get; set; }
//     public Dictionary<char, TrieNode> Children { get; set; }
//
//     public TrieNode(char value)
//     {
//         Value = value;
//         IsEndOfWord = false;
//         Children = new Dictionary<char, TrieNode>();
//     }
// }
//
// public class Trie
// {
//     private readonly TrieNode root;
//
//     public Trie() => root = new TrieNode(' ');
//
//     public void Insert(string word)
//     {
//         TrieNode curr = root;
//         foreach (char c in word)
//         {
//             if (!curr.Children.ContainsKey(c)) curr.Children[c] = new TrieNode(c);
//             curr = curr.Children[c];
//         }
//
//         curr.IsEndOfWord = true;
//     }
//
//     public bool Search(string word)
//     {
//         TrieNode current = root;
//         foreach (char c in word)
//         {
//             if (!current.Children.ContainsKey(c)) return false;
//             current = current.Children[c];
//         }
//
//         return current.IsEndOfWord;
//     }
//
//     public bool StartsWith(string prefix)
//     {
//         TrieNode current = root;
//
//         foreach (var c in prefix)
//         {
//             if (!current.Children.ContainsKey(c)) return false;
//             current = current.Children[c];
//         }
//
//         return true;
//     }
//
//     public List<string> GetWordsWithPrefix(string prefix)
//     {
//         List<string> result = new List<string>();
//         TrieNode current = root;
//
//         foreach (char c in prefix)
//         {
//             if (!current.Children.ContainsKey(c)) return result;
//             current = current.Children[c];
//         }
//         DFS(current, prefix, result);
//         return result;
//     }
//     
//     void DFS(TrieNode node, string currWord, List<string> result)
//     {
//         if (node.IsEndOfWord) result.Add(currWord);
//         foreach (var child in node.Children.Values)
//         {
//             DFS(child, currWord + child.Value, result);
//         }
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Trie trie = new Trie();
//         
//         trie.Insert("cat");
//         trie.Insert("car");
//         trie.Insert("cap");
//         trie.Insert("dog");
//         trie.Insert("dot");
//         trie.Insert("dove");   
//         
//         Console.WriteLine(trie.Search("cat"));
//         Console.WriteLine(trie.Search("ca"));
//
//         var words = trie.GetWordsWithPrefix("do");
//         Console.WriteLine("Words with prefix 'do': " + string.Join(", ", words));
//         
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         TrieNode root = new TrieNode(' ');
//         if (!root.Children.ContainsKey('c')) root.Children['c'] = new TrieNode('c');
//         if (!root.Children['c'].Children.ContainsKey('a')) root.Children['c'].Children['a'] = new TrieNode('a');
//         if (!root.Children['c'].Children['a'].Children.ContainsKey('c'))
//             root.Children['c'].Children['a'].Children['t'] = new TrieNode('t');
//
//         root.Children['c'].Children['a'].Children['t'].IsEndOfWord = true;
//       
//         Console.WriteLine("cat qo'shildi");
//     }
// }


public class TrieNode
{
    public char Value { get; set; }
    public bool IsEndOfWord { get; set; }
    public Dictionary<char, TrieNode> Children { get; set; }

    public TrieNode(char value)
    {
        Value = value;
        IsEndOfWord = false;
        Children = new Dictionary<char, TrieNode>();
    }
}

public class Trie
{
    private readonly TrieNode root;

    public Trie() => root = new TrieNode(' ');

    public void Insert(string word)
    {
        TrieNode curr = root;
        foreach (char c in word)
        {
            if (!curr.Children.ContainsKey(c)) curr.Children[c] = new TrieNode(c);
            curr = curr.Children[c];
        }

        curr.IsEndOfWord = true;
    }

    public bool Search(string word)
    {
        TrieNode curr = root;
        foreach (char c in word)
        {
            if (!curr.Children.ContainsKey(c)) return false;
            curr = curr.Children[c];
        }

        return curr.IsEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode curr = root;
        foreach (char c in prefix)
        {
            if (!curr.Children.ContainsKey(c)) return false;
            curr = curr.Children[c];
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Trie trie = new Trie();

        trie.Insert("cat");
            trie.Insert("cut");
            bool check = trie.StartsWith("c");
            Console.WriteLine(check);
            Console.WriteLine(trie.Search("cat"));
    }
}   
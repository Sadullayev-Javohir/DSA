// class TrieNode
// {
//     public Dictionary<char, TrieNode> Children = new();
//     public bool IsEndOfWord;
// }
//
// class Trie
// {
//     private TrieNode root = new TrieNode();
//
//     public void Insert(string word)
//     {
//         var node = root;
//
//         foreach (var c in word)
//         {
//             if (!node.Children.ContainsKey(c)) node.Children[c] = new TrieNode();
//             node = node.Children[c];
//         }
//
//         node.IsEndOfWord = true;
//     }
//
//     public bool Search(string word)
//     {
//         var node = root;
//
//         foreach (var c in word)
//         {
//             if (!node.Children.ContainsKey(c)) return false;
//             node = node.Children[c];
//         }
//
//         return node.IsEndOfWord;
//     }
//     
//     public bool StartsWith(string prefix)
//     {
//         var node = root;
//
//         foreach (var c in prefix)
//         {
//             if (!node.Children.ContainsKey(c)) return false;
//             node = node.Children[c];
//         }
//
//         return true;
//     }
//
//     public void PrintAll()
//     {
//         PrintHelper(root, "");
//     }
//
//     private void PrintHelper(TrieNode node, string currWord)
//     {
//         if (node.IsEndOfWord) Console.WriteLine(currWord);
//
//         foreach (var pair in node.Children)
//         {
//             PrintHelper(pair.Value, currWord + pair.Key);
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
//         trie.Insert("cash");
//         
//         Console.WriteLine(trie.Search("cash"));
//         Console.WriteLine(trie.StartsWith("ca"));
//         
//         trie.PrintAll();
//     }
// }

// class TrieNode
// {
//     public Dictionary<char, TrieNode> Children = new ();
//     public bool IsEndOfWord;
// }
//
// public class Trie
// {
//     private TrieNode root = new TrieNode();
//
//     public void Insert(string word)
//     {
//         var node = root;
//
//         foreach (var c in word)
//         {
//             if (!node.Children.ContainsKey(c)) node.Children[c] = new TrieNode();
//             node = node.Children[c];
//         }
//
//         node.IsEndOfWord = true;
//     }
//
//     public bool Search(string word)
//     {
//         var node = root;
//
//         foreach (var c in word)
//         {
//             if (!node.Children.ContainsKey(c)) return false;
//             node = node.Children[c];
//         }
//
//         return node.IsEndOfWord;
//     }
//
//     public bool StartsWith(string prefix)
//     {
//         var node = root;
//
//         foreach (var c in prefix)
//         {
//             if (!node.Children.ContainsKey(c)) return false;
//             node = node.Children[c];
//         }
//
//         return true;
//     }
//
//     public void PrintAll()
//     {
//         PrintHelper(root, "");
//     }
//
//     private void PrintHelper(TrieNode node, string currWord)
//     {
//         if (node.IsEndOfWord) Console.WriteLine(currWord);
//         foreach (var pair in node.Children)
//         {
//             PrintHelper(pair.Value, currWord + pair.Key);
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
//         trie.Insert("cash");
//         trie.Insert("car");
//         trie.Insert("cal");
//         trie.Insert("caz");
//         
//         trie.PrintAll();
//     }
// }


public class Node
{
    public Node left;
    public Node right;
    public int value;
    public Node(int value) => this.value = value;
}

public class BST
{
    Node root;

    public BST() => root = null;
    
    public void BFS()
    {
        var queue = new Queue<Node>();
        
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();
            Console.Write(curr.value + " ");
            
            if (curr.left != null) queue.Enqueue(curr.left);
            if (curr.right != null) queue.Enqueue(curr.right);
        }
    }


    public void Insert(int value)
    {
        root = Insert(root, value);
    }
    private Node Insert(Node node, int value)
    {
        if (node == null) return new Node(value);

        if (value < node.value) node.left = Insert(node.left, value);
        else if (value > node.value) node.right = Insert(node.right, value);

        return node;
    }
    public void DFSRecursive(Node root)
    {
        if (root == null) return;
        
        Console.Write(root.value + " ");
        if (root.left != null) DFSRecursive(root.left);
        if (root.right != null) DFSRecursive(root.right);
    }

    public void DFSIterator(Node root)
    {
        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            
            Console.Write(curr.value + " ");
            if (curr.right != null) stack.Push(curr.right);
            if (curr.left != null) stack.Push(curr.left);
        }
    }
}


class Program
{
    static void Main()
    {
        BST bst = new BST();
        
        bst.Insert(5);
        bst.Insert(20);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(15);
        
        bst.BFS();
        // bst.BFS(root);
    }
}
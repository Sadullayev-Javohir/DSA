public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value) => Value = value;
}

class BST
{
    public Node Root;
    public BST() => Root = null;

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, int value)
    {
        if (root == null) return new Node(value);

        if (root.Value > value) root.Left = InsertRec(root.Left, value);
        else if (root.Value < value) root.Right = InsertRec(root.Right, value);

        return root;
    }

    public void InOrder()
    {
        InOrderRec(Root);
    }

    private void InOrderRec(Node root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write(root.Value + " ");
            InOrderRec(root.Right);
        }
    }

    public bool Search(int value) => Search(Root, value) != null ? true : false;


    public Node Search(Node root, int value)
    {
        if (root == null) return null;
        if (root.Value == value) return root;

        if (root.Value > value) return Search(root.Left, value);
        else if (root.Value < value) return Search(root.Right, value);
        return null;
    }

    public bool Delete(int value) => Delete(Root, value) != null ? true : false;

    private Node Delete(Node root, int value)
    {
        if (root == null) return null;

        if (root.Value > value) root.Left = Delete(root.Left, value);
        else if (root.Value < value) root.Right = Delete(root.Right, value);
        else
        {
            if (root.Left == null) return root.Right;
            if (root.Right == null) return root.Left;

            var min = FindMin(root.Right);
            root.Value = min.Value;
            root.Right = Delete(root.Right, value);
        }

        return root;
    }

    private Node FindMin(Node root)
    {
        var curr = root;
        while (curr != null) curr = curr.Left;
        return curr;
    }

    public void PreOrder()
    {
        PreOrder(Root);
    }

    private void PreOrder(Node root)
    {
        if (root == null) return;
        Console.Write(root.Value + " ");
        PreOrder(root.Left);
        PreOrder(root.Right);
    }

    public void PostOrder()
    {
        PostOrder(Root);
    }

    private void PostOrder(Node root)
    {
        if (root == null) return;
        PostOrder(root.Left);
        PostOrder(root.Right);
        Console.Write(root.Value + " ");
    }

    public Node FindMin()
    {
        var curr = Root;
        while (curr.Left != null) curr = curr.Left;
        return curr;
    }

    public Node FindMax()
    {
        var curr = Root;
        while (curr.Right != null) curr = curr.Right;
        return curr;
    }

    public int CountNodes()
    {
        return CountNodesRec(Root);
    }

    private int CountNodesRec(Node root)
    {
        if (root == null) return 0;
        return 1 + CountNodesRec(root.Left) + CountNodesRec(root.Right);
    }
}

class Program
{
    static void Main()
    {
        BST tree = new BST();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        // tree.Delete(30);
        tree.InOrder();
        Console.WriteLine();
        // tree.PreOrder();
        // Console.WriteLine();
        // tree.PostOrder();
        Console.WriteLine(tree.FindMin().Value);
        Console.WriteLine(tree.FindMax().Value);
        Console.WriteLine(tree.CountNodes());
        // Console.WriteLine(tree.Search(50));
    }
}
using System;

class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Value = value;
        Left = Right = null;
    }
}

class BST
{
    public Node Root;

    public BST()
    {
        Root = null;
    }

   // Dodawanie
    public void Insert(int value)
    {
        Root = Inserter(Root, value);
    }


    private Node Inserter(Node root, int value)
    {
      
        if (root == null)
        {
            root = new Node(value);
            return root;
        }

      
        if (value < root.Value)
        {
            root.Left = Inserter(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = Inserter(root.Right, value);
        }

      
        return root;
    }

    // In-Order
    public void InOrder()
    {
        InOrderator(Root);
    }

    private void InOrderator(Node root)
    {
        if (root != null)
        {
            InOrderator(root.Left);
            Console.Write(root.Value + " ");
            InOrderator(root.Right);
        }
    }

    //Pre-Order
    public void PreOrder()
    {
        PreOrderator(Root);
    }

    private void PreOrderator(Node root)
    {
        if (root != null)
        {
            Console.Write(root.Value + " ");
            PreOrderator(root.Left);
            PreOrderator(root.Right);
        }
    }

    // Post-Order
    public void PostOrder()
    {
        PosrOrderator(Root);
    }

    private void PosrOrderator(Node root)
    {
        if (root != null)
        {
            PosrOrderator(root.Left);
            PosrOrderator(root.Right);
            Console.Write(root.Value + " ");
        }
    }

    //Znajdywanie
    public bool Search(int value)
    {
        return Finder(Root, value);
    }

    private bool Finder(Node root, int value)
    {
        if (root == null)
            return false;

        if (root.Value == value)
            return true;

        if (value < root.Value)
            return Finder(root.Left, value);

        return Finder(root.Right, value);
    }

    // Usuwanie
    public void Delete(int value)
    {
        Root = Deletator(Root, value);
    }

    private Node Deletator(Node root, int value)
    {
        
        if (root == null)
            return root;

       
        if (value < root.Value)
            root.Left = Deletator(root.Left, value);
        else if (value > root.Value)
            root.Right = Deletator(root.Right, value);
        else
        {
            
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            
            root.Value = MinValue(root.Right);

            
            root.Right = Deletator(root.Right, root.Value);
        }

        return root;
    }

    //Znajdywanie najmniejszego
    private int MinValue(Node root)
    {
        int minValue = root.Value;
        while (root.Left != null)
        {
            minValue = root.Left.Value;
            root = root.Left;
        }
        return minValue;
    }
}

class Program
{
    static void Main()
    {
        BST tree = new BST();

        
        tree.Insert(8);
        tree.Insert(7);
        tree.Insert(12);
        tree.Insert(13);
        tree.Insert(1);
        tree.Insert(9);
        tree.Insert(12);

        Console.WriteLine("In-order:");
        tree.InOrder();

        Console.WriteLine("\nPre-order:");
        tree.PreOrder();

        Console.WriteLine("\nPost-order:");
        tree.PostOrder();

        Console.WriteLine("\nSzukanie 13");
        Console.WriteLine(tree.Search(13));

        Console.WriteLine("\nUsuwanie 7");
        tree.Delete(7);
        tree.InOrder();

        Console.WriteLine("\nUsuwanie 1");
        tree.Delete(1);
        tree.InOrder();

      
    }
}

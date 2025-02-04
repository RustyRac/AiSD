﻿// See https://aka.ms/new-console-template for more information


class Kruskal
{
    public class Edge
    {
        public int Node1, Node2, Cost;

        public Edge(int node1, int node2, int cost)
        {
            Node1 = node1;
            Node2 = node2;
            Cost = cost;
        }
    }

    public class DisjointSet
    {
        private int[] parent, rank;

        public DisjointSet(int n)
        {
            parent = new int[n];
            rank = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }
        }

        public int Find(int u)
        {
            if (parent[u] != u)
            {
                parent[u] = Find(parent[u]);
            }
            return parent[u];
        }

       
        public void Union(int u, int v)
        {
            int root1 = Find(u);
            int root2 = Find(v);

            if (root1 != root2)
            {
                
                if (rank[root1] < rank[root2])
                {
                    parent[root1] = root2;
                }
                else if (rank[root1] > rank[root2])
                {
                    parent[root2] = root1;
                }
                else
                {
                    parent[root2] = root1;
                    rank[root1]++;
                }
            }
        }
    }

  
    public static List<Edge> Kruskaler(List<Edge> edges, int numVertices)
    {
        
        edges.Sort((e1, e2) => e1.Cost.CompareTo(e2.Cost));

      
        DisjointSet ds = new DisjointSet(numVertices);
        List<Edge> result = new List<Edge>();

      
        foreach (var edge in edges)
        {
         
            if (ds.Find(edge.Node1) != ds.Find(edge.Node2))
            {
                ds.Union(edge.Node1, edge.Node2);
                result.Add(edge);
            }
        }

        return result;
    }

    static void Main()
    {
     
        List<Edge> edges = new List<Edge>
        {
            new Edge(0, 1, 4),
            new Edge(0, 2, 3),
            new Edge(0, 3, 10),
            new Edge(1, 3, 15),
            new Edge(2, 3, 7)
        };

      
        int numVertices = 4;

      
        var minTree = Kruskaler(edges, numVertices);

      
        Console.WriteLine("Minimalne drzewo");
        foreach (var edge in minTree)
        {
            Console.WriteLine(edge.Node1 +" - "+ edge.Node2  + "  Koszt:  " + edge.Cost);
        }
    }
}
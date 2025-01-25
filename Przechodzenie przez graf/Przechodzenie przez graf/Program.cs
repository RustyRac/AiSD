// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Graph
{
    private Dictionary<int, List<int>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }

    // Dodanie krawędzi do grafu
    public void AddEdge(int u, int v)
    {
        if (!adjacencyList.ContainsKey(u))
        {
            adjacencyList[u] = new List<int>();
        }
        adjacencyList[u].Add(v);
    }

    // Przechodzenie grafu w głąb (DFS)
    public void DFS(int start)
    {
        bool[] visited = new bool[adjacencyList.Count + 1];
        DFSUtil(start, visited);
    }

    // Pomocnicza metoda DFS (rekursywna)
    private void DFSUtil(int node, bool[] visited)
    {
        // Odwiedź węzeł
        Console.WriteLine(node);
        visited[node] = true;

        // Rekurencyjne przechodzenie po sąsiadach
        foreach (var neighbor in adjacencyList[node])
        {
            if (!visited[neighbor])
            {
                DFSUtil(neighbor, visited);
            }
        }
    }

    // Przechodzenie grafu w szerz (BFS) bez użycia kolejki
    public void BFS(int start)
    {
        bool[] visited = new bool[adjacencyList.Count + 1];
        List<int> list = new List<int>();

        // Rozpocznij od węzła początkowego
        visited[start] = true;
        list.Add(start);

        int index = 0;
        while (index < list.Count)
        {
            // Usuwamy pierwszy element z listy (symulacja działania kolejki)
            int node = list[index];
            index++;
            Console.WriteLine(node);

            // Przejdź po sąsiadach węzła
            foreach (var neighbor in adjacencyList[node])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    list.Add(neighbor);
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph();
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(2, 5);
        graph.AddEdge(3, 6);

        Console.WriteLine("Przechodzenie grafu w głąb (DFS):");
        graph.DFS(1);

        Console.WriteLine("\nPrzechodzenie grafu w szerz (BFS):");
        graph.BFS(1);
    }
}
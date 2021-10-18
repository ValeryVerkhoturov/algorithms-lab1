using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab2
{
    public class WeightedDirectedGraph
    {
        private int[,] AdjacencyMatrix { get; }
        private List<int> Vertexes { get; }

        public WeightedDirectedGraph(int size)
        {
            Vertexes = new List<int>();
            AdjacencyMatrix = new int[size, size];
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                    AdjacencyMatrix[i, j] = 0;
        }

        public void AddEdge(int from, int to, int weight)
        {
            if (from > AdjacencyMatrix.GetLength(
                0) || to > AdjacencyMatrix.GetLength(1))
                throw new ArgumentOutOfRangeException();
            AdjacencyMatrix[from, to] = weight;
            if (!Vertexes.Contains(from))
                Vertexes.Add(from);
            if (!Vertexes.Contains(to))
                Vertexes.Add(to);
        }

        public int CountVertexes()
        {
            return Vertexes.Count;
        }

        public int[] BreadthFirstTraversal(int vertex)
        {
            if (!Vertexes.Contains(vertex))
                throw new ArgumentException();
            var mark = new bool[CountVertexes()]; // visited
            var parent = new int[CountVertexes()];
            for (int i = 0; i < CountVertexes(); i++)
            {
                mark[i] = false;
                parent[i] = 0;
            }

            Queue<int> queue = new Queue<int>();
            mark[vertex] = true;
            queue.Enqueue(vertex);
            while (queue.Count > 0)
            {
                vertex = queue.Dequeue();
                for (int i = 0; i < CountVertexes(); i++)
                {
                    if (AdjacencyMatrix[vertex, i] == 0 || mark[i])
                        continue;
                    mark[i] = true;
                    queue.Enqueue(i);
                    parent[i] = vertex;
                    // Console.Write($"{i} ");
                }

                mark[vertex] = true;
            }
            
            foreach (var VARIABLE in parent)
            {
                Console.Write($"{VARIABLE} ");
            }
            PrintPath(parent, 2, 4);
            return parent;
        }

        public void PrintPath(int[] parent, int begin, int end)
        {
            int u = parent[end];
            if (u == begin)
            {
                Console.Write(" {0} {1} ", u, end);
                return;
            }
            else if (parent[end] == 0)
            {
                Console.WriteLine(" Пути из {0} в {1} нет", begin, end);
            }
            else PrintPath(parent, begin, u);
            Console.Write("{0} ", end);
        }
        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                output += "[ ";
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                    output += AdjacencyMatrix[i, j].ToString() + " ";
                output += "]\n";
            }
            
            return output;
        }
    }
    
}
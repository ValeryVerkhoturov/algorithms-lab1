using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Lab2
{
    public class WeightedDirectedGraph
    {
        // в каждой ячейке  матрицы соответствующим координатам
        // лежит ребро с направлением (откуда, куда) и вес
        private Edge[,] AdjacencyMatrix;

        public WeightedDirectedGraph(int size)
        {
            AdjacencyMatrix = new Edge[size, size];
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                    AdjacencyMatrix[i, j] = new Edge(0, -1, -1);
        }

        public void AddVertex(Edge edge)
        {
            int x = edge.From;
            int y = edge.To;
            if (x > AdjacencyMatrix.Length || y > AdjacencyMatrix.Length)
                throw new ArgumentOutOfRangeException();
            AdjacencyMatrix[x, y] = edge;
            AdjacencyMatrix[y, x] = edge;
        }

        public string ToStringWithoutDirection()
        {
            string output = "";
                for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
                {
                    output += "[ ";
                    for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                        output += AdjacencyMatrix[i, j].Weight + ", ";
                    output += "]\n";
                }
            return output;
        }
        
        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < AdjacencyMatrix.GetLength(0); i++)
            {
                output += "[";
                for (int j = 0; j < AdjacencyMatrix.GetLength(1); j++)
                {
                    output += AdjacencyMatrix[i, j].ToString();
                }
                output += "]\n";
            }
            
            return output;
        }
    }
    
}
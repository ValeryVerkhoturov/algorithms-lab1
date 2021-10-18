using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightedDirectedGraph weightedDirectedGraph =
                new WeightedDirectedGraph(7);
            // weightedDirectedGraph.AddEdge(1,2, 1);
            // weightedDirectedGraph.AddEdge(1,4, 2);
            // weightedDirectedGraph.AddEdge(4,2, 3);
            // weightedDirectedGraph.AddEdge(2,5, 4);
            // weightedDirectedGraph.AddEdge(5,4, 5);
            // weightedDirectedGraph.AddEdge(3,5, 6);
            // weightedDirectedGraph.AddEdge(3,6, 7);
            // weightedDirectedGraph.AddEdge(6,6, 8);
            weightedDirectedGraph.AddEdge(2,1, 1);
            weightedDirectedGraph.AddEdge(1,4, 2);
            weightedDirectedGraph.AddEdge(2,4, 3);
            weightedDirectedGraph.AddEdge(5,2, 4);
            weightedDirectedGraph.AddEdge(4,5, 5);
            weightedDirectedGraph.AddEdge(3,5, 6);
            weightedDirectedGraph.AddEdge(3,6, 7);
            weightedDirectedGraph.AddEdge(6,6, 8);
            Console.WriteLine(weightedDirectedGraph);
            weightedDirectedGraph.BreadthFirstTraversal(3);
        }
    }
}
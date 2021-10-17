using System;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightedDirectedGraph weightedDirectedGraph =
                new WeightedDirectedGraph(10);
            weightedDirectedGraph.AddVertex(new Edge(10, 2, 3));
            Console.WriteLine(weightedDirectedGraph.ToStringWithoutDirection());
        }
    }
}
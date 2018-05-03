using System;
using System.Collections.Generic;

namespace TopologicalOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            var topological = new TopologicalOrdering();
            var graph = new List<Vertex>();

            graph.Add(new Vertex("0"));
            graph.Add(new Vertex("1"));
            graph.Add(new Vertex("2"));
            graph.Add(new Vertex("3"));
            graph.Add(new Vertex("4"));
            graph.Add(new Vertex("5"));

            graph[2].NeighbourList.Add(graph[3]);
            graph[3].NeighbourList.Add(graph[1]);

            graph[4].NeighbourList.Add(graph[0]);
            graph[4].NeighbourList.Add(graph[1]);

            graph[5].NeighbourList.Add(graph[0]);
            graph[5].NeighbourList.Add(graph[2]);

            foreach (var item in graph) {
                if (!item.Visited) {
                    topological.Dfs(item);
                }
            }

            Stack<Vertex> stack = topological.Stack;

            while (stack.Count > 0) {
                var v = stack.Pop();
                Console.WriteLine(v);
            }

            Console.ReadKey();
        }
    }
}

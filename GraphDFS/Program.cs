using System;
using System.Collections.Generic;

namespace GraphDFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vertex("A");
            var v2 = new Vertex("B");
            var v3 = new Vertex("C");
            var v4 = new Vertex("D");
            var v5 = new Vertex("E");

            v1.Neighbours.Add(v2);
            v1.Neighbours.Add(v3);
            v2.Neighbours.Add(v4);
            v4.Neighbours.Add(v5);

            var list = new List<Vertex>() { v1, v2, v4 };

            var dfs = new DFS();
            dfs.dfs(list);

            Console.ReadKey();
        }
    }
}

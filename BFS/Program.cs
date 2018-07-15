using System;
using System.Collections;
using System.Collections.Generic;

namespace BFS
{
    class Program
    {
        static void Main(String[] args)
        {

            // Queries
            var q = Convert.ToInt32(Console.ReadLine());

            // Iterate Queries
            for (int i = 0; i < q; i++)
            {
                var l = Console.ReadLine().Split(' ');
                var n = Convert.ToInt32(l[0]); // Number of nodes
                var m = Convert.ToInt32(l[1]); // Number of connections
                var u = 0; // Edge Origin
                var v = 0; // Edge Destination

                // Iterate connections
                for (int j = 0; j < m; j++)
                {
                    var uv = Console.ReadLine().Split(' ');
                    u = Convert.ToInt32(uv[0]);
                    v = Convert.ToInt32(uv[1]);
                }

                // Starting Node
                var s = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public class Node
    {
        bool isVisited = false;
        int data = 0;
        HashSet<int> neighboors = new HashSet<int>();        
    }

    public class Graph
    {

    }
}

using System;
using System.Collections.Generic;

namespace CycleDetectionDFS
{
    public class CycleDetection
    {
        public void detectCycle(List<Vertex> vertexList)
        {
            foreach (Vertex v in vertexList)
            {
                if (!v.Visited)
                {
                    dfs(v);
                }
            }
        }

        private void dfs(Vertex vertex)
        {
            Console.WriteLine("DFS on vertex " + vertex);
            vertex.BeingVisited = true;

            foreach (var v in vertex.AdjacencyList)
            {
                Console.WriteLine("Visiting neigbour of vertex: " + v);

                if (v.BeingVisited)
                {
                    Console.WriteLine("Cycle Detected!");
                    return;
                }

                if(!v.Visited)
                {
                    v.Visited = true;
                    dfs(v);
                }
            }

            Console.WriteLine("Set vertex " + vertex + " recursively...");
            vertex.BeingVisited = false;
            vertex.Visited = true;
        }
    }
}

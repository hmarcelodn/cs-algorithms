using System;

namespace CycleDetectionDFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex v1 = new Vertex("1");
            Vertex v2 = new Vertex("2");
            Vertex v3 = new Vertex("3");
            Vertex v4 = new Vertex("4");
            Vertex v5 = new Vertex("5");
            Vertex v6 = new Vertex("6");

            v1.AdjacencyList.Add(v2);
            v2.AdjacencyList.Add(v3);
            v3.AdjacencyList.Add(v1);

            v1.AdjacencyList.Add(v4);
            v4.AdjacencyList.Add(v5);
            v5.AdjacencyList.Add(v6);
            v6.AdjacencyList.Add(v4);

            CycleDetection cd = new CycleDetection();
            cd.detectCycle(new System.Collections.Generic.List<Vertex>()
            {
                v1,v2,v3,v4,v5,v6
            });

            Console.ReadKey();
        }
    }
}

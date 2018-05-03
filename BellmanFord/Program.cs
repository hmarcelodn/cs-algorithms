using System;

namespace BellmanFord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Bellman-Ford!");
            Vertice v1 = new Vertice("A");
            Vertice v2 = new Vertice("B");
            Vertice v3 = new Vertice("C");
            Vertice v4 = new Vertice("D");

            Arista a1 = new Arista(4, v1, v2);
            Arista a2 = new Arista(2, v1, v4);
            Arista a3 = new Arista(6, v2, v3);
            Arista a4 = new Arista(-9, v3, v4);

            BellmanFord bellmanFord = new BellmanFord(
                new System.Collections.Generic.List<Arista>() { a1, a2, a3, a4 },
                new System.Collections.Generic.List<Vertice>() { v1, v2, v3, v4 }
                );

            bellmanFord.AlgoritmoBellmanFord(v1);
            bellmanFord.CaminoMasCortoHacia(v4);
        }
    }
}

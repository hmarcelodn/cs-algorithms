using System;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertice v1 = new Vertice("A");
            Vertice v2 = new Vertice("B");
            Vertice v3 = new Vertice("C");
            Vertice v4 = new Vertice("D");
            Vertice v5 = new Vertice("E");

            v1.AgregarVecino(new Arista(2, v1, v2));
            v1.AgregarVecino(new Arista(1, v1, v3));
            v2.AgregarVecino(new Arista(5, v2, v3));
            v2.AgregarVecino(new Arista(2, v2, v4));
            v3.AgregarVecino(new Arista(1, v3, v4));
            v4.AgregarVecino(new Arista(1, v4, v5));

            Dijkstra dijkstra = new Dijkstra();
            dijkstra.CalcularPaths(v1);

            foreach (Vertice v in dijkstra.ObtenerCaminoCorto(v5))
            {
                Console.Write(v.Nombre + " -> ");
            }

            Console.Write(v5.Nombre);
            Console.ReadKey();
        }
    }
}

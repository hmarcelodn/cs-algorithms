using System;
using System.Collections.Generic;

namespace Kruskal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vertice> listaVertices = new List<Vertice>();
            listaVertices.Add(new Vertice("A"));
            listaVertices.Add(new Vertice("B"));
            listaVertices.Add(new Vertice("C"));
            listaVertices.Add(new Vertice("D"));
            listaVertices.Add(new Vertice("E"));
            listaVertices.Add(new Vertice("F"));
            listaVertices.Add(new Vertice("G"));
            listaVertices.Add(new Vertice("H"));

            List<Arista> listaAristas = new List<Arista>();
            listaAristas.Add(new Arista(1, listaVertices[0], listaVertices[1]));
            listaAristas.Add(new Arista(2, listaVertices[0], listaVertices[2]));
            listaAristas.Add(new Arista(5, listaVertices[0], listaVertices[3]));
            listaAristas.Add(new Arista(13, listaVertices[1], listaVertices[5]));
            listaAristas.Add(new Arista(2, listaVertices[1], listaVertices[3]));
            listaAristas.Add(new Arista(5, listaVertices[2], listaVertices[4]));
            listaAristas.Add(new Arista(2, listaVertices[2], listaVertices[3]));
            listaAristas.Add(new Arista(4, listaVertices[3], listaVertices[4]));
            listaAristas.Add(new Arista(6, listaVertices[3], listaVertices[5]));
            listaAristas.Add(new Arista(3, listaVertices[3], listaVertices[6]));
            listaAristas.Add(new Arista(6, listaVertices[4], listaVertices[6]));
            listaAristas.Add(new Arista(2, listaVertices[5], listaVertices[6]));
            listaAristas.Add(new Arista(3, listaVertices[5], listaVertices[7]));
            listaAristas.Add(new Arista(6, listaVertices[6], listaVertices[7]));

            KruskalAlgorithm kruskalAlgorithm = new KruskalAlgorithm();
            kruskalAlgorithm.SpanningTree(listaVertices, listaAristas);

            Console.ReadKey();
        }
    }
}

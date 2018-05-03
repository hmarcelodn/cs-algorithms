using System;
using System.Collections.Generic;

namespace Prim
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vertice> listaVertices = new List<Vertice>();
            Vertice vertex0 = new Vertice("A");
            Vertice vertex1 = new Vertice("B");
            Vertice vertex2 = new Vertice("C");

            listaVertices.Add(vertex0);
            listaVertices.Add(vertex1);
            listaVertices.Add(vertex2);

            vertex0.AgregarVecino(new Arista(100, vertex0, vertex1));
            vertex0.AgregarVecino(new Arista(10, vertex0, vertex2));
            vertex0.AgregarVecino(new Arista(1, vertex1, vertex2));

            vertex1.AgregarVecino(new Arista(100, vertex1, vertex0));
            vertex2.AgregarVecino(new Arista(10, vertex2, vertex0));
            vertex2.AgregarVecino(new Arista(1, vertex2, vertex1));

            PrimAlgorithm prim = new PrimAlgorithm(listaVertices);
            prim.Prim(vertex2);
            prim.MostrarMST();
            Console.ReadKey();
        }
    }
}

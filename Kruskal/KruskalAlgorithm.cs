using System;
using System.Collections.Generic;

namespace Kruskal
{
    public class KruskalAlgorithm
    {
        public void SpanningTree(List<Vertice> listaVertices, List<Arista> listaAristas)
        {
            DisjointSet disjointSet = new DisjointSet(listaVertices);
            List<Arista> mst = new List<Arista>();
            listaAristas.Sort();

            foreach (Arista a in listaAristas)
            {
                Vertice u = a.VerticeOrigen;
                Vertice v = a.VerticeDestino;

                if (disjointSet.Find(u.Nodo) != disjointSet.Find(v.Nodo))
                {
                    mst.Add(a);
                    disjointSet.Union(u.Nodo, v.Nodo);
                }
            }

            foreach (Arista a in mst)
            {
                Console.Write(string.Format("{0} {1} -- ", a.VerticeOrigen, a.VerticeDestino));
            }
        }
    }
}

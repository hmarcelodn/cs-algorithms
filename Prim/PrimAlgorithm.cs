using System;
using System.Collections.Generic;
using System.Text;

namespace Prim
{
    public class PrimAlgorithm
    {
        private List<Vertice> _verticesNoVisitados;
        private List<Arista> _arbolExpandido;
        private PriorityQueue _aristaHeap;
        private double _fullCost;

        public PrimAlgorithm(List<Vertice> verticesNoVisitados)
        {
            this._arbolExpandido = new List<Arista>();
            this._verticesNoVisitados = new List<Vertice>(verticesNoVisitados);
            this._aristaHeap = new PriorityQueue();
        }

        public void Prim(Vertice v)
        {
            this._verticesNoVisitados.Remove(v);

            while (this._verticesNoVisitados.Count > 0)
            {
                foreach (Arista a in v.ListaAdyacencias)
                {
                    if (this._verticesNoVisitados.Contains(a.VerticeDestino))
                    {
                        this._aristaHeap.Enqueue(a);
                    }
                }

                Arista minArista = this._aristaHeap.Dequeue();
                this._arbolExpandido.Add(minArista);
                this._fullCost += minArista.Peso;

                v = minArista.VerticeDestino;
                this._verticesNoVisitados.Remove(v);

            }
        }

        public void MostrarMST()
        {
            Console.WriteLine("Min Spanning Tree");
            foreach (Arista a in this._arbolExpandido)
            {
                Console.WriteLine(a.VerticeOrigen + " - " + a.VerticeDestino);
            }
        }

    }
}

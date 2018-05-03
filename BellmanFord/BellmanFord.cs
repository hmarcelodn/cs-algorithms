using System;
using System.Collections.Generic;

namespace BellmanFord
{
    public class BellmanFord
    {
        private List<Arista> _aristas;
        private List<Vertice> _vertices;

        public BellmanFord(List<Arista> aristas, List<Vertice> vertices)
        {
            this._aristas = aristas;
            this._vertices = vertices;
        }

        public void AlgoritmoBellmanFord(Vertice verticeOrigen)
        {
            verticeOrigen.DistanciaMinima = 0;

            // | V - 1 | Iteraciones
            for (int i = 0; i < this._vertices.Count - 1; i++)
            {
                foreach (Arista arista in this._aristas)
                {
                    Vertice u = arista.VerticeInicial;
                    Vertice v = arista.VerticeFinal;

                    if (u.DistanciaMinima != double.MaxValue)
                    {
                        double nuevaDistancia = u.DistanciaMinima + arista.Peso;

                        // Relajación de Vertices
                        if (nuevaDistancia < v.DistanciaMinima)
                        {
                            v.DistanciaMinima = nuevaDistancia;
                            v.Predecesor = u;
                        }
                    }
                }
            }

            // | N-th | Iteración de Ciclos
            foreach (Arista arista in this._aristas)
            {
                if (arista.VerticeInicial.DistanciaMinima != double.MaxValue)
                {
                    if (HasCycle(arista))
                    {
                        Console.WriteLine("Cycle Detected.");
                        return;
                    }
                }
            }
        }

        public void CaminoMasCortoHacia(Vertice verticeDestino)
        {
            if (verticeDestino.DistanciaMinima != double.MaxValue)
            {
                Console.WriteLine("Exite un camino más corto.");

                Vertice actual = verticeDestino;
                Console.Write(string.Format("{0} - ", actual));

                while (actual.Predecesor != null)
                {
                    actual = actual.Predecesor;
                    Console.Write(string.Format("{0} - ", actual));
                }
            }
            else
            {
                Console.WriteLine("No existe camino más corto");
            }
        }

        // Detección de Ciclos
        protected bool HasCycle(Arista arista)
        {
            return arista.VerticeInicial.DistanciaMinima + arista.Peso < arista.VerticeFinal.DistanciaMinima;
        }
    }
}

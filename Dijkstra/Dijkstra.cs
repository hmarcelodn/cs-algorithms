using System.Collections.Generic;

namespace Dijkstra
{
    public class Dijkstra
    {
        public void CalcularPaths(Vertice verticeOrigen)
        {
            verticeOrigen.DistanciaMinima = 0;
            PriorityQueue priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue(verticeOrigen);

            while (!priorityQueue.Vacio())
            {
                Vertice verticeActual = priorityQueue.Dequeue();

                foreach (Arista a in verticeActual.ListaAdyacencias)
                {
                    Vertice v = a.VerticeFinal;

                    double nuevaDistancia = a.Peso + verticeActual.DistanciaMinima;

                    if (nuevaDistancia < v.DistanciaMinima)
                    {                       
                        v.DistanciaMinima = nuevaDistancia;
                        v.Predecesor = verticeActual;
                        priorityQueue.Enqueue(v);
                    }
                }
            }
        }

        public List<Vertice> ObtenerCaminoCorto(Vertice verticeFinal)
        {
            List<Vertice> vertices = new List<Vertice>() { };

            while (verticeFinal.Predecesor != null)
            {
                vertices.Add(verticeFinal.Predecesor);
                verticeFinal = verticeFinal.Predecesor;
            }

            vertices.Reverse();

            return vertices;
        }
    }
}

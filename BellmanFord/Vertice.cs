using System;
using System.Collections.Generic;

namespace BellmanFord
{
    public class Vertice
    {
        private string _nombre;
        private List<Arista> _listaAdyacencias;
        private Vertice _predecesor;
        private double _distanciaMinima = Double.MaxValue;

        public Vertice(string nombre)
        {
            this.Nombre = nombre;
            this.ListaAdyacencias = new List<Arista>();
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public List<Arista> ListaAdyacencias { get => _listaAdyacencias; set => _listaAdyacencias = value; }
        public double DistanciaMinima { get => _distanciaMinima; set => _distanciaMinima = value; }
        public Vertice Predecesor { get => _predecesor; set => _predecesor = value; }

        public void AgregarVecino(Arista arista)
        {
            this.ListaAdyacencias.Add(arista);
        }

        public override string ToString()
        {
            return this._nombre;
        }
    }
}

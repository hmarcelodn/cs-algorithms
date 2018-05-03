using System;
using System.Collections.Generic;
using System.Text;

namespace Dijkstra
{
    public class Arista
    {
        private double _peso;
        private Vertice _verticeInicial;
        private Vertice _verticeFinal;

        public double Peso { get => _peso; set => _peso = value; }
        internal Vertice VerticeFinal { get => _verticeFinal; set => _verticeFinal = value; }
        internal Vertice VerticeInicial { get => _verticeInicial; set => _verticeInicial = value; }

        public Arista(double peso, Vertice verticeInicial, Vertice verticeFinal)
        {
            this.Peso = peso;
            this._verticeInicial = verticeInicial;
            this._verticeFinal = verticeFinal;
        }
    }
}

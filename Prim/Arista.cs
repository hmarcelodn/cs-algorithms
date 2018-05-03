using System;

namespace Prim
{
    public class Arista: IComparable<Arista>
    {
        private double _peso;
        private Vertice _verticeOrigen;
        private Vertice _verticeDestino;

        public Arista(double peso, Vertice verticeOrigen, Vertice verticeDestino)
        {
            this.Peso = peso;
            this.VerticeOrigen = verticeOrigen;
            this.VerticeDestino = verticeDestino;
        }

        public double Peso { get => _peso; set => _peso = value; }
        public Vertice VerticeOrigen { get => _verticeOrigen; set => _verticeOrigen = value; }
        public Vertice VerticeDestino { get => _verticeDestino; set => _verticeDestino = value; }

        public int CompareTo(Arista other)
        {
            return this.Peso.CompareTo(other.Peso);
        }
    }
}

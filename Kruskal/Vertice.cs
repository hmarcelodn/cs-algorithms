using System;
using System.Collections.Generic;
using System.Text;

namespace Kruskal
{
    public class Vertice
    {
        private string _nombre;
        private Nodo _nodo;

        public Vertice(string name)
        {
            this._nombre = name;
        }

        public Nodo Nodo { get => _nodo; set => _nodo = value; }

        public void SetNodo(Nodo nodo)
        {
            this.Nodo = nodo;
        }

        public override string ToString()
        {
            return this._nombre;
        }
    }
}

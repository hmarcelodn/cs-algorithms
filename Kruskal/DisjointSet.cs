using System.Collections.Generic;

namespace Kruskal
{
    public class DisjointSet
    {
        private int _nodoContador = 0;
        private int _setContador = 0;
        private List<Nodo> _rootNodos; // Representativos

        public DisjointSet(List<Vertice> vertices)
        {
            this._rootNodos = new List<Nodo>(vertices.Count);
            MakeSets(vertices);
        }

        public void MakeSets(List<Vertice> vertices)
        {
            foreach (Vertice v in vertices)
            {
                MakeSet(v);
            }
        }

        private void MakeSet(Vertice v)
        {
            Nodo n = new Nodo(0, _rootNodos.Count, null);
            v.SetNodo(n);
            this._rootNodos.Add(n);
            this._setContador++;
            this._nodoContador++;
        }

        public int Find(Nodo n)
        {
            Nodo nodoActual = n;

            while (nodoActual.Padre != null)
            {
                nodoActual = nodoActual.Padre;
            }

            Nodo rootNodo = nodoActual;
            nodoActual = n;

            // Path Compression
            while (nodoActual != rootNodo)
            {
                Nodo temp = nodoActual.Padre;
                nodoActual.Padre = rootNodo;
                nodoActual = temp;
            }

            return rootNodo.Id;
        }

        public void Union(Nodo n1, Nodo n2)
        {
            int indice1 = Find(n1);
            int indice2 = Find(n2);

            if (indice1 == indice2)
            {
                return;
            }

            Nodo raiz1 = _rootNodos[indice1];
            Nodo raiz2 = _rootNodos[indice2];

            // Rank Balancing
            if (raiz1.Rank < raiz2.Rank)
            {
                raiz1.Padre = raiz2;
            }
            else if (raiz1.Rank > raiz2.Rank)
            {
                raiz2.Padre = raiz1;
            }
            else
            {
                raiz2.Padre = raiz1;
                raiz1.Rank++;
            }

            this._setContador--;
        }
    }
}

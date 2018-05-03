namespace Dijkstra
{
    public class PriorityQueue
    {
        private Node _root;

        public PriorityQueue()
        { }

        public void Enqueue(Vertice v)
        {
            Node nuevoNodo = new Node();
            nuevoNodo.Distance = v.DistanciaMinima;
            nuevoNodo.Vertice = v;

            if (this._root == null || v.DistanciaMinima < this._root.Distance)
            {
                nuevoNodo.Next = this._root;
                this._root = nuevoNodo;
            }
            else
            {
                Node aux = this._root;

                while (aux.Next != null && v.DistanciaMinima >= aux.Distance)
                {
                    aux = aux.Next;
                }

                nuevoNodo.Next = aux.Next;
                aux.Next = nuevoNodo;
            }

            return;
        }

        public Vertice Dequeue()
        {
            var v = this._root.Vertice;
            this._root = this._root.Next;

            return v;
        }

        public Vertice Poll()
        {
            return this._root.Vertice;
        }

        public bool Vacio()
        {
            return this._root == null;
        }
    }

    public class Node
    {
        public double Distance;
        public Vertice Vertice;
        public Node Next;
    }
}

namespace Prim
{
    public class PriorityQueue
    {
        private Node _root;

        public PriorityQueue()
        { }

        public void Enqueue(Arista a)
        {
            Node nuevoNodo = new Node();
            nuevoNodo.Peso = a.Peso;
            nuevoNodo.Arista = a;

            if (this._root == null || a.Peso < this._root.Peso)
            {
                nuevoNodo.Next = this._root;
                this._root = nuevoNodo;
            }
            else
            {
                Node aux = this._root;

                while (aux.Next != null && a.Peso >= aux.Peso)
                {
                    aux = aux.Next;
                }

                nuevoNodo.Next = aux.Next;
                aux.Next = nuevoNodo;
            }

            return;
        }

        public Arista Dequeue()
        {
            var v = this._root.Arista;
            this._root = this._root.Next;

            return v;
        }

        public Arista Poll()
        {
            return this._root.Arista;
        }

        public bool Vacio()
        {
            return this._root == null;
        }
    }

    public class Node
    {
        public double Peso;
        public Arista Arista;
        public Node Next;
    }
}

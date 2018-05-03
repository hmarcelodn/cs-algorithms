using System;
using System.Collections.Generic;
using System.Text;

namespace Kruskal
{
    public class Nodo
    {
        private int _id;
        private int _rank;
        private Nodo _padre;

        public Nodo(int rank, int id, Nodo padre)
        {
            this.Id = id;
            this.Rank = rank;
            this.Padre = padre;
        }

        public int Id { get => _id; set => _id = value; }
        public int Rank { get => _rank; set => _rank = value; }
        public Nodo Padre { get => _padre; set => _padre = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GraphDFS
{
    public class Vertex
    {
        private string _name;
        private bool _visited;
        private IList<Vertex> _neighbours;

        public IList<Vertex> Neighbours { get => _neighbours; set => _neighbours = value; }
        public string Name { get => _name; set => _name = value; }
        public bool Visited { get => _visited; set => _visited = value; }

        public Vertex(string name)
        {
            this._name = name;
            this._visited = false;
            this._neighbours = new List<Vertex>();
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}

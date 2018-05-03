using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalOrdering
{
    public class Vertex
    {
        private string data;
        private bool visited;
        private List<Vertex> neighbourList;

        public Vertex(string data)
        {
            this.Data = data;
            this.NeighbourList = new List<Vertex>();
        }

        public List<Vertex> NeighbourList { get => neighbourList; set => neighbourList = value; }
        public bool Visited { get => visited; set => visited = value; }
        public string Data { get => data; set => data = value; }


        public override string ToString()
        {
            return this.data;
        }
    }
}

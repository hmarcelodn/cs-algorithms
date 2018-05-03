using System;
using System.Collections.Generic;
using System.Text;

namespace CycleDetectionDFS
{
    public class Vertex
    {
        private string name;
        private bool visited;
        private bool beingVisited;
        private List<Vertex> adjacencyList;

        public Vertex(string name)
        {
            this.Name = name;
            this.AdjacencyList = new List<Vertex>();
        }

        public List<Vertex> AdjacencyList { get => adjacencyList; set => adjacencyList = value; }
        public bool BeingVisited { get => beingVisited; set => beingVisited = value; }
        public bool Visited { get => visited; set => visited = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

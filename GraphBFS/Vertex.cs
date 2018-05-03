using System;
using System.Collections.Generic;
using System.Text;

namespace GraphBFS
{
    public class Vertex
    {
        private int data;
        private bool visited;
        private IList<Vertex> neighbourList;

        public Vertex(int data)
        {
            this.data = data;
            this.neighbourList = new List<Vertex>();
        }

        public int getData() {
            return this.data;
        }

        public void setData(int data) {
            this.data = data;
        }

        public void setVisited(bool isVisited) {
            this.visited = isVisited;
        }

        public bool isVisited() {
            return this.visited;
        }

        public IList<Vertex> getNeighbourList() {
            return this.neighbourList;
        }

        public void setNeighbourList(IList<Vertex> neighbourList) {
            this.neighbourList = neighbourList;
        }

        public override string ToString()
        {
            return "" + this.data;
        }

        public void addNeighbourVertex(Vertex v) {
            this.neighbourList.Add(v);
        }
    }
}

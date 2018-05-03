using System;

namespace GraphBFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new BFS();

            var vertex1 = new Vertex(1);
            var vertex2 = new Vertex(2);
            var vertex3 = new Vertex(3);
            var vertex4 = new Vertex(4);
            var vertex5 = new Vertex(5);

            vertex1.addNeighbourVertex(vertex2);
            vertex1.addNeighbourVertex(vertex4);
            vertex4.addNeighbourVertex(vertex5);
            vertex2.addNeighbourVertex(vertex3);

            graph.Bfs(vertex1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GraphBFS
{
    public class BFS
    {
        public void Bfs(Vertex root) {
            var queue = new Queue<Vertex>();

            root.setVisited(true);

            queue.Enqueue(root);

            while (queue.Count != 0) {
                var actualVertex = queue.Dequeue();

                Console.WriteLine(actualVertex);

                foreach (var v in actualVertex.getNeighbourList()) {
                    if (!v.isVisited()) {
                        v.setVisited(true);
                        queue.Enqueue(v);
                    }
                }
            }
        }
    }
}

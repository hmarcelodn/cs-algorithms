using System;
using System.Collections.Generic;

namespace GraphDFS
{
    public class DFS
    {
        protected IList<Vertex> _vertexList;

        public void dfs(IList<Vertex> vertexList)
        {
            foreach (var v in vertexList) {
                if (!v.Visited) {
                    v.Visited = true;
                    //dfsWithStack(v);
                    dfsRecursive(v);
                }
            }
        }

        private void dfsRecursive(Vertex rootVertex) {
            rootVertex.Visited = true;
            Console.WriteLine(rootVertex);

            foreach (var v in rootVertex.Neighbours) {
                if (!v.Visited) {
                    v.Visited = true;
                    dfsRecursive(v);
                }
            }
        }

        private void dfsWithStack(Vertex rootVertex) {
            var stack = new Stack<Vertex>();
            stack.Push(rootVertex);

            while (stack.Count > 0) {
                var root = stack.Pop();

                Console.WriteLine(root);

                foreach (var v in root.Neighbours) {
                    if (!v.Visited) {
                        v.Visited = true;
                        stack.Push(v);
                    }
                }
            }
        }

    }
}

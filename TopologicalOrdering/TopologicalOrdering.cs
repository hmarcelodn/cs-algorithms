using System.Collections.Generic;

namespace TopologicalOrdering
{
    public class TopologicalOrdering
    {
        private Stack<Vertex> _stack;

        public TopologicalOrdering()
        {
            this._stack = new Stack<Vertex>();
        }

        public Stack<Vertex> Stack { get => _stack; }

        public void Dfs(Vertex root)
        {
            root.Visited = true;

            foreach (var v in root.NeighbourList)
            {
                if (!v.Visited)
                {
                    Dfs(v);
                }
            }

            this.Stack.Push(root);
        }
    }
}

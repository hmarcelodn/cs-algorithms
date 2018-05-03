using System;
using System.Linq;
using System.Collections;

namespace SpecialFamily
{
    class Program
    {
        class Node
        {
            public Node(int root) {
                this.value = root; 
            }

            public int value;
            public Node left, right;
        }

        static int len = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inOrder = new int[] { 4, 2, 1, 5, 3, 6 };
            int[] postOrder = new int[] { 1, 2, 4, 3, 5, 6 };
            len = inOrder.Length;

            var t = restoreBinaryTree(inOrder, postOrder);
        }

        static Node restoreBinaryTree(int[] inOrder, int[] preOrder)
        {
            // Base Case
            if (inOrder.Length == 0 || preOrder.Length == 0) return null;

            // Recursive
            int root = preOrder[0];
            int index = inOrder.ToList().IndexOf(root);

            Node t = new Node(root);

            t.left = restoreBinaryTree(
                SubArray(inOrder,0, index),
                SubArray(preOrder, 1, index)
            );

            t.right = restoreBinaryTree(
                SubArray(inOrder, index + 1, inOrder.Length - 1),
                SubArray(preOrder, index + 1, preOrder.Length - 1)
            );

            return t;
        }

        static int[] SubArray(int[] values, int start_index, int end_index)
        {
            int num_items = end_index - start_index + 1;
            int[] result = new int[num_items];
            Array.Copy(values, start_index, result, 0, num_items);
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutateArrayDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Permuting Array Dynamic Programming";
            Console.WriteLine("Permuting Array Dynamic Programming");

            int[] a = { 1, 2, 3, 4, 5 };
            List<int[]> arr = PermutateArray(a);

            Console.WriteLine();
            foreach (var aux in arr)
            {
                for (int i = 0; i < aux.Length; i++)
                {
                    Console.Write(string.Format("{0} ", aux[i]));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        // Bottom-Up Approach
        static List<int[]> PermutateArray(int[] a)
        {
            // Base Case
            if (a.Length <= 1) { return new List<int[]>() { a }; }

            // Recursion            

            // Get Last Element
            int el = a[a.Length - 1];

            // Permutate             

            // Tomo el ultimo caracter, permuto el resto, luego por cada permutación
            // intercalo el caracter ultimo.
            List<int[]> laux = PermutateArray(a.ToList().GetRange(0, a.Length - 1).ToArray());            
            List<int[]> res = new List<int[]>();

            foreach (var aux in laux)
            {                
                for (int i = 0; i < aux.Length + 1; i++)
                {
                    List<int> permutation = new List<int>();
                    permutation.AddRange(aux);
                    permutation.Insert(i, el);
                    res.Add(permutation.ToArray());
                }
            }

            return res;
        }
    }
}

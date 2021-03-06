﻿using System;
using System.Collections;
using System.Diagnostics;

namespace Codility
{
    class Program
    {
        static int max = -1;
        static Hashtable _cache = new Hashtable();

        static void Main(string[] args)
        {
            int p = 0;
            int q = 1;
            int r = 2;
            int[] A = new int[10] { 0, 1, 3, -2, 0, 1, 0, -3, 2, 3 };

            // Recursion
            Stopwatch sw = new Stopwatch();
            sw.Start();
            recurse(A, p, q, r);
            sw.Stop();

            Console.WriteLine("");
            Console.WriteLine(string.Format("Max Deepth: {0}", max));
            Console.WriteLine(string.Format("Elapsed: {0}", sw.Elapsed));

            Console.ReadKey();
        }

        static void recurse(int[] A, int p, int q, int r)
        {
            // Base cases
            if ((p == A.Length - 3 || q == A.Length - 2 || r == A.Length - 1) || (p > q || q > r))
            {
                return;
            }

            // Pit Detections
            if (A[p] > A[q] && A[q] < A[r])
            {
                bool valid = true;
                string k = p.ToString() + q.ToString() + r.ToString();

                // Memoization
                if(!_cache.ContainsKey(k)) {
                    // Checking constraints
                    
                    // Descending
                    for (int i = p; i < q - 1; i++)
                    {
                        if (A[i + 1] > A[i])
                        {
                            valid = false;
                            break;
                        }
                    }

                    if (valid) {
                        // Ascending
                        for (int i = q; i < r - 1; i++)
                        {
                            if (A[i + 1] < A[i])
                            {
                                valid = false;
                                break;
                            }
                        }
                    }

                    if (valid)
                    {
                        Console.WriteLine(string.Format("P: {0} , Q: {1}, R: {2}", p, q, r));
                        // Depths
                        int depth = Math.Min(A[p] - A[q], A[r] - A[q]);
                        if (depth > max)
                        {
                            max = depth;
                            Console.WriteLine("MaxDetected: " + max);
                        }
                    }

                    _cache.Add(k, valid);
                }
            }

            // Recursive bottom-up
            recurse(A, p, q, r + 1);
            recurse(A, p, q + 1, r);
            recurse(A, p + 1, q, r);
        }
    }
}

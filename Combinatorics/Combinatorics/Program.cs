using System;

namespace Combinatorics
{
    class Program
    {
        static void Permutations(int k, int n, int[] s, bool[] b) //permutations of n
        {
            if (k >= n)
            {
                for (int i = 0; i < n; ++i)
                    Console.Write(s[i]);
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; ++i)
                    if (b[i] == false)
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        Permutations(k + 1, n, s, b);
                        b[i] = false;
                    }
            }
        }

        static void Arrangements(int k, int p, int n, int[] s, bool[] b) // arrangements of n taken as p
        {
            if (k >= p)
            {
                for (int i = 0; i < p; ++i)
                    Console.Write(s[i]);
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; ++i)
                    if (b[i] == false)
                    {
                        b[i] = true;
                        s[k] = i + 1;
                        Arrangements(k + 1, p, n, s, b);
                        b[i] = false;
                    }
            }
        }

        static void Combinations(int k, int p, int n, int[] s) // combinations of n taken as p
        {
            if (k > p)
            {
                for (int i = 1; i <= p; ++i)
                    Console.Write(s[i]);
                Console.WriteLine();
            }
            else
            {
                for (int i = s[k - 1] + 1; i <= n; ++i)
                {
                    s[k] = i;
                    Combinations(k + 1, p, n, s);
                }
            }
        }
        static void Main(string[] args)
        {
            /* FOR PERMUTATIONS
             int n;
            n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            bool[] b = new bool[n];
            for (int i = 0; i < n; ++i)
                b[i] = false;
            Permutations(0, n, s,b);
            Console.ReadKey();
              */


            /* FOR ARRANGEMENTS
              int n, p;
           n = int.Parse(Console.ReadLine());
           p = int.Parse(Console.ReadLine());
           int[] s = new int[n];
           bool[] b = new bool[n];
           for (int i = 0; i < n; ++i)
               b[i] = false;
           Arrangements(0,p, n, s, b);
           Console.ReadKey();
              */


            /* FOR COMBINATIONS
              int n, p;
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            int[] s = new int[n+1];
            bool[] b = new bool[n+1];
            s[0] = 0;
            for (int i = 1; i < n; ++i)
                b[i] = false;
            Combinations(1, p, n, s);
            Console.ReadKey();
             */
        }
    }
}

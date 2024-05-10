using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cee_suck_lab_1
{
    internal class Program
    {
        static int fibonacci_memorization(int n, Dictionary<int, int> cache)
        {
            if (cache.ContainsKey(n))
                return cache[n];
            int res;
            if (n == 0)
                res = 0;
            else if (n == 1)
                res = 1;
            else
                res = fibonacci_memorization(n - 1, cache) + fibonacci_memorization(n - 2, cache);
            cache[n] = res;
            return res;
        }
        static int fibonacci_tabulation(int n)//time O(n)
        {
            if (n == 0) {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int[] table = new int[n + 1];
                table[0] = 0;
                table[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    table[i] = table[i - 1] + table[i - 2];
                }
                return table[n];
            }
        }
        static int fibonacci(int n) //time O(2^n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else 
                return fibonacci(n-1) + fibonacci(n-2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int> cache = new Dictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                int res_mem = fibonacci_memorization(i, cache);
                Console.Write(res_mem + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                int res_tabulation = fibonacci_tabulation(i);
                Console.Write(res_tabulation + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                int res = fibonacci(i);
                Console.Write(res + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

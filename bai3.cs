using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cee_suck_lab_1
{
    internal class bai3
    { 
        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            if (isPrime(n))
            {
                Console.WriteLine("{0} là số nguyên tố", n);
            }
            else
            {
                Console.WriteLine("{0} không phải là số nguyên tố", n);
            }
            Console.ReadLine();
        }
    }
}

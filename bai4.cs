using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cee_suck_lab_1
{
    internal class bai4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ((a + b > c) &&  (b + c > a) && (a+c>b) && (a > 0) && (b > 0) && (c > 0)){
                if (c * c == a * a + b * b || a * a == b * b + c * c || b * b == a * a + c * c)
                {
                    Console.WriteLine("Tam giác vuông");
                }
                else if(a == b && b == c)
                {
                    Console.WriteLine("tam giác đều");
                }
                else if (a==b|| a==c||b == c)
                {
                    Console.WriteLine("tam giác cân");
                }
                else if(a*a> b*b+c*c || b*b > a*a + c*c || c*c > b * b + a * a)
                {
                    Console.WriteLine("Tam giác tù");
                }
                else
                {
                    Console.WriteLine("tam giác nhọn");
                }
            }
            Console.ReadLine();
        }
    }
}

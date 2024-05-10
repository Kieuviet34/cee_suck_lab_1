using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cee_suck_lab_1
{
    internal class bai2
    {
        
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            //tam giac dac
            for(int i = 0; i < h; i++)
            {
                for (int j = 0;j<= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine('\n');
            //hinh vuong rong
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (i == 0 || i == h - 1|| j == 0 || j == h -1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine('\n');
            //tam giac vuong rong
            for (int  i = 0; i < h; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == h - 1 || j == 0 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

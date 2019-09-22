using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i != 1) Console.WriteLine();
                for (int j = n - i - 1; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 6;
            staircase(n);
            Console.ReadLine();
        }
    }
}

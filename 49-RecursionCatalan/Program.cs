using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 卡特兰数，​1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862...递推公式为 f(n) = f(n-1)*(4*n-2)/(n+1)
 */
namespace _49_RecursionCatalan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int ret = Catalan(i);
                Console.WriteLine($"{i}~{ret}");
            }
            Console.ReadKey();
        }

        private static int Catalan(int i)
        {
            return i == 0 || i == 1 ? 1 : Catalan(i - 1) * (4 * i - 2) / (i + 1);
        }
    }
}

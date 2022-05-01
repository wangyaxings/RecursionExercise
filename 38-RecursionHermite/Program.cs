using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 求解Hermite多项式,物理学中Hermite多项式给出了量子谐振子的本征态
 * H0(x)=1,H1(x)=2x,H(n)(x)=2*x*H(n-1)(x)-2*(n-1)H(n-2)(x),n>=2
 */
namespace _38_RecursionHermite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int x = 9;
            long ret = Hermite(n,x);
            Console.WriteLine($"H{n}({x}) = {ret}");
            Console.ReadKey();
        }

        private static long Hermite(int n, int x)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 2 * x;
            }
            else
            {
                return 2 * x * Hermite(n - 1, x) - 2 * (n - 1) * Hermite(n - 2, x);
            }

        }
    }
}

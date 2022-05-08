using System;
/*
 * 1x1和2x2的此状不重叠地铺满Nx3的地板，共有多少种方案
 */
namespace _45_RecursionTiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                int ret = Tiling(i);
                Console.WriteLine($"{i}~{ret}");
            }
            Console.ReadKey();
        }

        private static int Tiling(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 3;
            }
            else
            {
                return Tiling(n - 1) + 2 * Tiling(n - 2);
            }
        }
    }
}

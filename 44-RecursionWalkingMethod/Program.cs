using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 从原点出发，每一步只能向右，上，左走，走N步且不经过已走的点共有多少种走法
 */
namespace _44_RecursionWalkingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                int ret = WalkMethods(i);
                Console.WriteLine($"{i}~{ret}");
            }
            Console.ReadKey();
        }

        private static int WalkMethods(int n)
        {
            if (n == 1)
            {
                return 3;
            }
            else if (n == 2)
            {
                return 7;
            }
            else
            {
                return 2 * WalkMethods(n - 1) + WalkMethods(n - 2);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 欧几里得算法又称辗转相除法，是指用于计算两个非负整数a，b的最大公约数
 */
namespace _11_EuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 455;
            int a = 670;
            if (a<b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            //保证a>b
            int ret = gcd(a, b);
            Console.WriteLine(ret);
            Console.ReadKey();
        }

        private static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 第二类斯特林数（把n个不同的数划分为m个集合的方案数，要求不能为空集，共有多少种）
 */
namespace _50_RecursionSencondStirling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int m = 1; m < 10; m++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int n = m + j;
                    long ret = SencondStirling(n, m);
                    Console.WriteLine($"{n}~{m}~{ret}");
                }
            }
            Console.ReadKey();
        }

        private static long SencondStirling(int n, int m)
        {
            if (m==0)
            {
                return 0;
            }
            else if (m == 1)
            {
                return 1;
            }
            else if (m==n)
            {
                return 1;
            }
            else
            {
                return SencondStirling(n - 1, m - 1) + m * SencondStirling(n - 1, m);
            }
        }
    }
}

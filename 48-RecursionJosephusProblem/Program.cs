using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 约瑟夫环问题，N个人围成一个圈，从第一个开始报数，第M个被杀掉，最后剩下一个，其余人都被杀掉，计算最后存活的人
 */
namespace _48_RecursionJosephusProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 20; i++)
            {
                for (int j  = 1; j < 20; j++)
                {
                    int n = i;
                    int m = j;

                    int retR = JosephusCircleR(n, m);
                    int retLoop = JosephusCircleLoop(n, m);
                    Console.WriteLine($"n={n},m={m},Recursion={retR}, Loop={retLoop} Live.");
                }
            }

            
            Console.ReadKey();
        }

        //递归
        private static int JosephusCircleR(int n, int m)
        {
            return JosephusCircle(n, m) + 1;
        }
        private static int JosephusCircle(int n, int m ,int p=0)
        {
            if (n==1)
            {
                return p;
            }
            else
            {
                return (JosephusCircle(n - 1, m, p) + m) % n;
            }
        }

        //非递归
        private static int JosephusCircleLoop(int n, int m )
        {
            int p = 0;
            for (int i = 2; i <= n; i++)
            {
                p = (p + m) % i;
            }
            return p + 1;
        }
    }
}

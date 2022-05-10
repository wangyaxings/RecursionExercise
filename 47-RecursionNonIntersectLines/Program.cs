using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 圆周上有N个点，连接任意多条（可能是0条）不相交的弦（共用端点也算相交）共有多少中方案？
 */
namespace _47_RecursionNonIntersectLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}~{NonIntersectLines(i)}"); ;
            }
            Console.ReadKey();
        }

        private static int NonIntersectLines(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else if (num == 2)
            {
                return 2;
            }
            else if (num==3)
            {
                return 4;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i <= num-2; i++)
                {
                    sum = sum + NonIntersectLines(i) * NonIntersectLines(num - i - 2);
                }
                return NonIntersectLines(num-1) + sum;
            }
        }
    }
}

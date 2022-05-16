using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * N皇后问题，在一个NxN棋盘上放置N个皇后，每行一个并使其不同相互共计（同行，列，对角线上都会自动攻击）
 */
namespace _53_RecursionN_Queen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new int[100].ToList<int>();
            int n = 8;
            NQueen(n, list);
            Console.WriteLine($"{n}皇后问题共有{count}个解。");
            Console.ReadKey();
        }
        private static int count = 0;
        private static void NQueen(int n, List<int> list, int index = 1)
        {
            
            if (index>n)
            {
                count = count + 1;
                Print(count, list,n);                           
            }
            else
            {
                for (int i = 1; i <=n; i++)
                {
                    list[index] = i;
                    if (CanPlace(index,list))
                    {
                        NQueen(n, list, index + 1);
                    }
                }
            }
        }

        private static bool CanPlace(int index,List<int> list)
        {
            if (index==1)
            {
                return true;
            }
            for (int i = 1; i <index; i++)
            {
                if (list[i]==list[index] || (Math.Abs(list[i] - list[index]) == Math.Abs(i - index)))
                {
                    return false;
                }
            }
            return true;
        }

        private static void Print(int count, List<int> list ,int n)
        {
            Console.WriteLine($"第{count}次放置方法为：");
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"({i},{list[i]})");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *棋盘格数，NxM方格的棋盘求出棋盘中包含有多少个正方形，多少个长方形（不包括正方形）
 */
namespace _51_RecursionChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 10; n++)
            {
                for (int m = 1; m < 10; m++)
                {
                    Tuple<int, int> ret = RectangleSquare(n, m);
                    Console.WriteLine($"{n}x{m}: s={ret.Item1}~r={ret.Item2}");
                }
            }
            Console.ReadKey();
        }

        private static Tuple<int, int> RectangleSquare(int n, int m)
        {
            return Tuple.Create(SquareSum(n,m), RectangleSum(n,m));
        }

        private static int RectangleSum(int n, int m)
        {
            return RectangleIncludeSquareSum(n, m) - SquareSum(n, m);
        }

        private static int RectangleIncludeSquareSum(int n, int m)
        {
            int sumN=(1+n)*n/2;
            int sum = 0;
            for (int j = 1; j <= m; j++)
            {
                sum = sum + sumN*j;
            }
            return sum;
        }

        private static int SquareSum(int n, int m,int len=1)
        {
            int sum = 0;            
            int min = Math.Min(n, m);
            if (len == min)
            {
                return (n - min + 1) * (m - min + 1);
            }
            else
            {
                sum = (n - len + 1) * (m - len + 1);
                return sum + SquareSum(n,m,len+1);
            }
        }
    }
}

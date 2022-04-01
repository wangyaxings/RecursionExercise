using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 汉诺塔（Tower of Hanoi），又称河内塔，是一个源于印度古老传说的益智玩具。
 * 大梵天创造世界的时候做了三根金刚石柱子，在一根柱子上从下往上按照大小顺序摞着64片黄金圆盘。
 * 大梵天命令婆罗门把圆盘从下面开始按大小顺序重新摆放在另一根柱子上。并且规定，在小圆盘上不能放大圆盘，
 * 在三根柱子之间一次只能移动一个圆盘。
 */
namespace RecursionHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //黄金圆盘个数
            int layer = 10;
            long steps = Hanoi(10);
            Console.WriteLine(steps);
            Console.ReadKey();
        }

        static long Hanoi(int layer)
        {
            if (layer == 1)
            {
                return 1;
            }
            else
            {
                //f(n)=2^(n-1) + f(n-1)
                return Hanoi(layer - 1)+(long)Math.Pow(2 , layer-1);
            }
            
        }
    }
}

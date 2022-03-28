using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 杨辉三角是一个无限对称的数字金字塔，从顶部的单个1开始，下面一行中的每个数字都是上面两个数字的和。
 * 最外两条边上是1
 */
namespace _04_YangHuiTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 10;
            int col = 5;
            
            int number = YangHuiTriangle(row,col);
            Console.WriteLine(number);
            Console.ReadLine();
        }
        static int YangHuiTriangle(int row,int col)
        {
            if (col == 1 || row == col)
            {
                return 1;
            }
            else
            {
                return YangHuiTriangle(row-1,col-1)+YangHuiTriangle(row-1,col);
            }
            
        }
    }
}

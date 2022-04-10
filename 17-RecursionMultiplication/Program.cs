using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 乘法计算，不使用*乘法运算符
 */
namespace _17_RecursionMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 5;
            int z = Multiply(x, y);
            Console.WriteLine($"{x}*{y}={z}");              
            Console.ReadKey();
        }

        //乘法运算实质是y个x相加（或者x个y相加）
        private static int Multiply(int x, int y,int start=1)
        {
            if (start == y)
            {
                return x;
            }
            else
            {
                return x + Multiply(x, y, start + 1);
            }
        }
    }
}

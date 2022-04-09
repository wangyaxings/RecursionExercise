using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 幂指数计算 2^4 = 2*2*2*2
 */
namespace _16_RecursionExpoent
{
    internal class Program 
    {
        private static void Main(string[] args)
        {
            int baseNum = 2;
            int index = 8;
            int ret = ExpoentCalc(baseNum, index);
            int retRecursion = ExpoentCalc(baseNum, index,0);
            Console.WriteLine("{0}^{1}={2}",baseNum,index,ret);
            Console.WriteLine("{0}^{1}={2}", baseNum, index, retRecursion);
            Console.ReadKey();
        }

        /*
         * Recursion版本
         */
        private static int ExpoentCalc(int baseNum, int index, int start=0)
        {
            if (start == index)
            {
                return baseNum;
            }
            else
            {
                return baseNum * ExpoentCalc(baseNum, index, start + 1);
            }
        }
        /*
         * 循环版本
         */
        private static int ExpoentCalc(int baseNum, int index)
        {
            int x = 1;
            for (int i = 0; i < index; i++)
            {
                x = x * baseNum;
            }
            return x;
        }
    }
}

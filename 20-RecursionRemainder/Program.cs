using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 计算余数，但不使用%
 */
namespace _20_RecursionRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 27;
            int y = 3;
            int remainder = Remainder(x,y);
            Console.WriteLine($"{x}%{y} = {remainder} ");
            Console.ReadKey();
        }

        private static int Remainder(int v1, int v2)
        {
            if (v1 < v2)
            {
                return v1;
            }
            else
            {
                //除法可以理解为减法
                return Remainder(v1-v2, v2);
            }
        }
    }
}

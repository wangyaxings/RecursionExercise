using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 一只猴子吃n个桃子，每天吃现有桃子的一半多一个，第10天还有一个，求n
 */
namespace _52_RecursionMonkeyPeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{MonkeyPeach(1)}");
            Console.ReadKey();
        }

        private static int MonkeyPeach(int day)
        {            
            if (day==10)
            {
                return 1;
            }
            else
            {
                return (MonkeyPeach(day + 1) + 1)*2;
            }
        }
    }
}

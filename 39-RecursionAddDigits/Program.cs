using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 给定一个非负整数num，反复将各个位上的数字相加，直到结果为个位数，返回这个结果
 */
namespace _39_RecursionAddDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 0; i < 1000; i++)
            {
                num = i;
                int ret = AddDigits(num);
                Console.WriteLine($"{num}~{ret}");
            }
            
            Console.ReadKey();
        }
        //计算非负整数各个位之和        
        private static int AddAllDigits(int num)
        {
            int sum = 0;
            if (num<10)
            {
                return num;
            }
            else
            {
                sum = sum + num%10 + AddAllDigits(num/10);
            }
            return sum;
        }
        //直到结果为个位数
        private static int AddDigits(int num)
        {
            if (num<10)
            {
                return num;
            }
            else
            {
                return AddDigits(AddAllDigits(num));
            }
        }
    }
}

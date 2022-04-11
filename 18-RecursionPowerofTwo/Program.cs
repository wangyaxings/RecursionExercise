using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 判断一个数是否是2的整数次幂
 */

namespace _18_RecursionPowerofTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Random random = new Random();
            while (flag)
            {                
                int num = random.Next(0,1000);
                flag = !PowerOfTwo(num);
                Console.WriteLine($"{num} is {!flag} the power of 2");                
            }
            
            Console.ReadKey();
        }

        private static bool PowerOfTwo(int v)
        {
            if (v==2)
            {
                return true;
            }
            if (v%2==1)
            {
                return false;
            }
            else
            {
                return PowerOfTwo(v/2);
            }
        }
    }
}

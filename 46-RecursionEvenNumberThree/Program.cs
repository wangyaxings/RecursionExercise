using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_RecursionEvenNumberThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1~{9}");
            for (int i = 2; i < 10; i++)
            {                
                Console.WriteLine($"{i}~{f(i)}"); 
            }

            Console.ReadKey();
        }
        
        //这里n从2开始
        private static int f(int n)
        {
            return n == 1 ? 8 : (g(n - 1) + 9 * f(n - 1)) % 12345;
        }
        private static int g(int n)
        {
            return n == 1 ? 1 : (f(n - 1) + 9 * g(n - 1)) % 12345;
        }


        //穷举法
        private static void EventNumberThreeExhaustion()
        {
            for (int i = 1; i < 7; i++)
            {
                int count = 0;
                for (int j = (int)Math.Pow(10, i - 1); j < Math.Pow(10, i); j++)
                {
                    if (remainder(j) % 2 == 0)
                    {
                        count++;
                        //Console.WriteLine(j);
                    }
                }
                if (i == 1)
                {
                    count++;
                }
                Console.WriteLine($"{(i == 1 ? 0 : Math.Pow(10, i - 1))}-{Math.Pow(10, i) - 1}~{count}");
            }
        }

        private static int remainder(int i)
        {
            if (i<10)
            {
                return i == 3 ? 1 : 0;
            }
            else
            {
                return i%10==3? 1 + remainder(i / 10): remainder(i / 10);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Fizz Buzz是一个游戏，规则为：i=1,i++,如果i为3的倍数，则输出Fizz，5的倍数则输出Buzz，3和5的倍数输出"FizzBuzz"，否则报数i
 */
namespace _22_RecursionFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //for循环的遍历
            for (int i = 1; i < 100; i++)
            {
                FizzBuzz04(i);
            }
            Console.WriteLine("==================");
            //从1-endFizzBuzz
            int end = 23;
            FizzBuzz(end);
            Console.ReadKey();
        }

        //递归写法(从1到num)
        private static void FizzBuzz(int num)
        {            
            //num>0且为整数
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
            if (num > 1)
            {
                FizzBuzz(num - 1);
            }            
        }
        private static void FizzBuzz01(int num)
        {
            //num>0且为整数
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num%5==0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
        
        //更加直白的写法，直接就逐个条件判断
        private static void FizzBuzz02(int num)
        {
            //如果这个条件往后放置
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                return;
            }
            if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
                return;
            }
            if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return;
            }
            //形式上的大括号
            {
                Console.WriteLine(num);
                return;
            }
        }

        private static void FizzBuzz03(int num)
        {
            if (num % 3 == 0 && num % 5 != 0)
            {
                Console.WriteLine("Fizz");
                return;
            }
            if (num % 5 == 0 && num % 3 != 0)
            {
                Console.WriteLine("Buzz");
                return;
            }
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                return;
            }            
            //形式上的大括号
            {
                Console.WriteLine(num);
                return;
            }
        }
        private static void FizzBuzz04(int num)
        {
            Console.WriteLine(num % 3 == 0 && num % 5 == 0 ? "FizzBuzz" : num % 3 == 0 ? "Fizz" : (num % 5 == 0 ? "Buzz" : num.ToString()));
        }
    }
}

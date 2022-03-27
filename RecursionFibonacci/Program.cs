using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 斐波那契数列 ：1、1、2、3、5、8、13、21、34
 */
namespace RecursionFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(9));
            Console.ReadKey();
        }
        static int Fibonacci(int n)
        {
            //判断n的合法性（略）
            if (n < 3)
            {
                return 1;
            }
            else 
            {
                int x = Fibonacci(n - 1);
                int y = Fibonacci(n - 2);
                return x + y;
                //return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            
        }
    }
}

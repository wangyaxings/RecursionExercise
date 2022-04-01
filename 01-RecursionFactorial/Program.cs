using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 01-计算 x到y的乘积
 */
namespace RecursionFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecursionFactorial(1,10));
            Console.ReadKey();
        }
        static int RecursionFactorial(int start,int end)
        {
            if (start == end)
            {
                return start;
            }
            else
            {
                return start*RecursionFactorial(start+1,end);
            }
        }
    }
}

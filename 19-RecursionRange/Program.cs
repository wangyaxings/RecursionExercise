using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 实现类似于python中range的函数，range(0,5)→0,1,2,3,4（左闭右开）
 */
namespace _19_RecursionRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> retList = Range(2, 10);
            foreach (var item in retList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static List<int> Range(int v1, int v2)
        {
            if (v1>=v2-1)
            {
                return new List<int>() { v1 };
            }
            else
            {
                var tmpList = Range(v1 + 1, v2);
                tmpList.Insert(0, v1);
                return tmpList;
            }
        }

        //for循环实现range
        private static List<int> RangeFor(int v1, int v2)
        {
            List<int> retList = new List<int>();
            for (int i = v1; i < v2; i++)
            {
                retList.Add(i);
            }
            return retList;
        }
    }
}

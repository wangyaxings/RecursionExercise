using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 判断一个字符串中是否存在重复的字符
 */
namespace _13_RecursionSameInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "adgjkloiytre";
            bool flag = SameInString(x,0,x.Length-1);
            
            Console.WriteLine(flag);
            Console.ReadKey();
        }

        //private static bool SameInString(string x, int end, int start=0)
        private static bool SameInString(string x, int start, int end)
        {
            //异常处理需要考虑start应该小于end（略）
            if (start == end)
            {
                return false;
            }
            else
            {
                for (int i = start+1; i < end; i++)
                {
                    if (x[start] == x[i])
                    {
                        //此时就可以结束了
                        return true;
                    }
                }

                //SameInString(x, start + 1, end);
                return SameInString(x, start + 1, end); 
            }
        }
    }
}

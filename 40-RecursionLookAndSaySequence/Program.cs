using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * leetcod-38 外观数列
 * 给定一个正整数n，输出外观数列的第n项。
 * 外观数列是一个整数序列，从数字1开始，序列中的每一项都是对前一项的描述。（1<=n<=30）
 */
namespace _40_RecursionLookAndSaySequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                string ret = CountAndSay(i);
                Console.WriteLine($"{i}~{ret}");
            }
            Console.ReadKey();
        }

        private static string CountAndSay(int n)
        {
            //对n的取值范围进行检查（略）
            if (n == 1)
            {
                return Say(n.ToString());
            }
            else
            {
                return Say(CountAndSay(n - 1));
            }
        }

        /// <summary>
        /// 输入一个数字字符串，对其进行描述
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static string Say(string n)
        {
            List<char> tmpList = new List<char>();
            List<int> countList = new List<int>();

            for (int i = 0; i < n.Count(); i++)
            {
                if (tmpList.Count != 0 && tmpList.Last() == n[i])
                {
                    countList[tmpList.Count - 1] = countList[tmpList.Count - 1] + 1;
                }
                else
                {
                    tmpList.Add(n[i]);
                    countList.Add(1);
                }
            }
            string ret = string.Empty;
            for (int i = 0; i < tmpList.Count; i++)
            {
                ret = ret + countList[i] + tmpList[i];
            }

            return ret;
        }
    }
}

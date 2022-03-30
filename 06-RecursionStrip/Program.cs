using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 删除字符串两端的空格，功能类似python语法中的strip
 */
namespace _06_RecursionStrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testStr = "    assert n > 0 and type(n) is int  ";
            string retStr = Strip(testStr);
            Console.WriteLine(retStr);
            Console.ReadKey();
        }

        private static string Strip(string testStr)
        {
            if (!(testStr.StartsWith(" ") || testStr.EndsWith(" ")))
            {
                return testStr;
            }
            else
            {
                if (testStr.StartsWith(" "))
                {
                    testStr = testStr.Substring(1, testStr.Length - 1);                    
                }
                if (testStr.EndsWith(" "))
                {
                    testStr = testStr.Substring(0, testStr.Length - 1);                    
                }
                return Strip(testStr);
            }            
        }
    }
}

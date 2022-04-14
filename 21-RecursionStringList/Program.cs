using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 给定一个string，将其每个字符转化为list
 */
namespace _21_RecursionStringList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "This is a test.";
            List<string> yList = StringList(x);
            for (int i = 0; i < yList.Count; i++)
            {
                Console.WriteLine(yList[i]);
            }
            Console.ReadKey();
        }

        private static List<string> StringList(string x)
        {
            if (x.Length == 1)
            {
                return new List<string>() { x };
            }
            else
            {
                var retList = StringList(x.Substring(1, x.Length - 1));
                retList.Insert(0, x.Substring(0,1));
                return retList;
            }
        }
    }
}

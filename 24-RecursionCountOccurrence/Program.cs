using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 计算数组中出现概率[2,3,4,4,5,6,5,4] 4出现3次
 */
namespace _24_RecursionCountOccurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 3, 4, 5, 7, 5, 6, };
            
            string listStr = "{";
            foreach (var item in list)
            {
                listStr = listStr + item + ",";
            }
            listStr = listStr + "}";
            
            
            foreach (var item in list)
            {
                int count = CountOccurrence(list, item);
                Console.WriteLine($"{listStr}中{item}出现了{count}次");
            }
            
            Console.ReadKey();
        }

        private static int CountOccurrence(List<int> list, int target,int start=0)
        {
            if (start == list.Count - 1)
            {
                return target == list[start] ? 1 : 0;
            }
            else
            {
                return (target == list[start] ? 1 : 0) + CountOccurrence(list, target, start + 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;

/*
 * 数组求和
 */
namespace _07_RecursionArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<List<int>> list = new List<List<int>>() 
            {
                new List<int>(){1,2,2,3,5 },
                new List<int>(){3,6,8,9,75,44,12 },
                new List<int>(){1, 24, 56, 48, 134, 961, 38 },
                new List<int>(){7, 95, 8, 464, 51, 8, 51, 15 },
            };
            foreach (var item in list)
            {
                Console.WriteLine(ListSum(item, 0, item.Count - 1));
            }
            Console.ReadKey();
        }

        static int ListSum(List<int> list,int start,int end)
        {            
            if (start==end)
            {
                return list[end];
            }
            else
            {
                return list[start] + ListSum(list, start + 1, end);
            }            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 将一个list进行反转Reverse，即[1,2,3]→[3,2,1]
 */

namespace _10_RecursionListReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> list = new List<string>() { "a","b","c","d" };
            IList<string> retList = ListReverse(list,0,list.Count()-1);
            foreach (var item in retList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static IList<string> Swap(IList<string> listA,IList<string> listB) 
        {
            return listB.Concat(listA).ToList();
        }

        //list本身存在reverse函数
        private static IList<string> ListReverse(IList<string> list,int start,int end)
        {
            //终止条件，只剩最后两个
            if (start == end -1)
            {
                var swapRetList = Swap(new List<string> { list[start] }, new List<string> { list[end] });
                return swapRetList;
            }
            else
            {
                var retList = ListReverse(list, start + 1, end);
                var swapRetList = Swap(new List<string> { list[start] }, retList);
                return swapRetList;
            }
        }
    }
}
/*
 * list.reverse()的函数实现其实使用的是for循环，十分简单
private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source)
{
    Buffer<TSource> buffer = new Buffer<TSource>(source);
    for (int i = buffer.count - 1; i >= 0; i--)
    {
        yield return buffer.items[i];
    }
}
*/
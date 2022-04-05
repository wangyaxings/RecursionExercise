using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 将n个元素按一定的顺序排列出来，所有的排列情况构成了n个元素的全排列
 */
namespace _12_RecursionAllPermutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //假设所有字符不同
            List<string> inList = new List<string>() { "a","b","c","d","e","f"};
            List<List<string>> retList = AllPermutation(inList, 0, inList.Count()-1);
            PrintList2D(retList);
        }
        private static List<List<string>> AllPermutation(List<string> inList, int start, int end)
        {
            if (start==end)
            {
                var ret = new List<List<string>>() { new List<string>() { inList.Last() } };
                return ret;
            }
            else
            {
                List<List<string>> allPermutationList = AllPermutation(inList,start+1,end);
                List<List<string>> retList = new List<List<string>>();
                for (int i = 0; i < allPermutationList.Count; i++)
                {
                    var ret = InsertList(allPermutationList[i], inList[start]);
                    retList.AddRange(ret);
                }
                return retList;
            }
        }

        private static List<List<string>> InsertList(List<string> itemList,string item)
        {
            List<List<string>> retList = new List<List<string>>();
            for (int i = 0; i < itemList.Count+1; i++)
            {
                List<string> tmpList = new List<string>();
                tmpList.AddRange(itemList);
                tmpList.Insert(i, item);
                retList.Add(tmpList);
            }
            //得到一个将a插入到[b,c,d,e,f]各个位置的所有情况的数组
            return retList;
        }
        private static void PrintList2D(List<List<string>> inList2D)
        {
            Console.WriteLine("共有"+inList2D.Count+"个");
            foreach (var item in inList2D)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("["+item[i]+", ");
                    }
                    else if (i == item.Count-1)
                    {
                        Console.WriteLine(item[i] + "]");                        
                    }
                    else
                    {
                        Console.Write(item[i] + ", ");
                    }
                }
            }
        }
    }
}

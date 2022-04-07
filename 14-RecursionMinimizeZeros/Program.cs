using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 相邻0仅保留已给，如[0,0,1,2,2,3,0,0,0,1,2]→[0,1,2,2,3,0,1,2]
 */
namespace _14_RecursionMinimizeZeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 0, 0, 1, 2, 2, 3, 0, 0, 0, 1, 2 };

            List<int> retList = MinimizeZeros(list,0,list.Count()-1);
            foreach (var item in retList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static List<int> MinimizeZeros(List<int> list, int start, int end)
        {
            //也可以在形参中使用ref对该数组进行原地修改
            List<int> tmpList = list.GetRange(0,end);
            if (start==end-1)
            {
                return tmpList;
            }
            else
            {
                if (tmpList[start]==0 && tmpList[start+1] == 0)
                {
                    tmpList.RemoveAt(start + 1);
                    end --;
                    start --;
                }
                return MinimizeZeros(tmpList, start+1,end);
            }
        }
    }
}

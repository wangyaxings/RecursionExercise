using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 二分查找
 */

namespace _05_RecursionBinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IList<int> list = new List<int>() { 1,3,4,5,7,14,33,44,56,78,99,103,144};
            IList<int> list = new List<int>() { 1, 3};
            for (int i = 0; i < list.Count; i++)
            {
                int index = BinarySearch(list, list[i], 0, list.Count-1);
                //检查搜索结果
                Console.WriteLine(list[i]+":"+index.ToString()+"结果为："+(index==i).ToString());           
            }
           
            Console.ReadKey();
            
        }

        private static int BinarySearch(IList<int> list,int findValue,int left,int right)
        {
            int mid = (left + right) / 2;
            //if (right-left==1)
            if (right-left<2)
            {
                if (list[left] == findValue)
                {
                    return left;
                }
                else if (list[right] == findValue)
                {
                    return right;
                }
                else
                {
                    //未找到
                    return -1;
                }
            }
            else
            {
                if (list[mid] == findValue) //终止条件-2，因为right
                {
                    return mid;
                }
                else if (list[mid]<findValue)
                {
                    left = mid;
                }                
                else
                {
                    right = mid;
                }
                return BinarySearch(list,findValue,left,right);
            }
            
        }
    }
}

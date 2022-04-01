using System;
using System.Collections.Generic;
using System.Linq;

/*
 * 求list数组中最大值,虽然自带max
 */
namespace RecursionListMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>() { 123,54,84,555,1,5,88,100,99};
            int max = ListMax(list,0,list[0]);
            Console.WriteLine(max);
            Console.WriteLine(list.Max() == max);            
            Console.ReadKey();
        }

        private static int ListMax(IList<int> list,int beginIndex,int tmpMax)
        {
            if (beginIndex==list.Count-1)
            {
                return tmpMax > list.Last() ? tmpMax : list.Last();
            }
            else
            {
                int tmp = ListMax(list, beginIndex + 1, tmpMax);
                return list[beginIndex] > tmp ? list[beginIndex] : tmp;                
            }
        }
    }
}

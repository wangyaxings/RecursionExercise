using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 */
namespace _31_RecursionMergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 8, 4, 5, 7, 1, 3, 6, 2 };
            List<int> list2 = new List<int>() { 8, 4, 5, 7, 1, 3, 6, 2 };
            MergeSort(ref list, ref list2, 0,list.Count());
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void MergeSort(ref List<int> left, ref List<int> right, int begin, int end)
        {
            if (end - begin <= 1)
                return;

            int middle = (end + begin) / 2;
            MergeSort(ref right,ref left, begin, middle);
            MergeSort(ref right, ref left, middle, end);
            Merge(ref right, ref left, begin, middle, end);
        }


        private static void Merge(ref List<int> left,ref List<int> right, int begin, int middle, int end) 
        {
            int i = begin;
            int j = middle;

            for (int k = begin; k < end; k++)
            {
                if (i < middle && (j >= end || right[i] <= right[j]))
                {
                    left[k] = right[i];
                    i++;
                }
                else
                {
                    left[k] = right[j];
                    j++;
                }
            }
        }
    }
}

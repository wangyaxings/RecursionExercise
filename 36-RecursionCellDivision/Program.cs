using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 细胞分裂中，一个细胞每一个小时分裂一次，一次分裂一个子细胞，第三个小时后消亡，n小时后有多少细胞？
 */
namespace _36_RecursionCellDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int sum = CellDivision(i);
                Console.WriteLine($"After {i}h,{sum} cells left");
            }
            
            Console.ReadKey();
        }
        //这里计算的是hours之后的细胞个数
        private static int CellDivision(int hours)
        {
            if (hours == 0)
            {
                return 1;
            }
            else if (hours == 1)
            {
                return 2;
            }
            else if (hours == 2)
            {
                return 4;
            }
            else
            {
                return CellDivision(hours - 1) + CellDivision(hours - 2) + CellDivision(hours - 3);
            }
        }
    }
}

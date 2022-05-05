using System;
/*
 * 等比数列 f(n) = 2*f(n-1), f(1) = 1
 */
namespace _42_RecursionGeometricSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                int ret = GeometricSeries(i);
                Console.WriteLine($"{i} ~ {ret}");
            }

            Console.ReadKey();            
        }

        private static int GeometricSeries(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return 2*GeometricSeries(number-1);
            }
        }
    }
}

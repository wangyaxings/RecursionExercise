using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 分解质因数，1和2都是质数（针对合数的处理）
 */
namespace _37_RecursionPrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            for (int i = 0; i < 1000; i++)
            {                
                List<int> retList = PrimeFactorizate(i);
                string msg = i.ToString() + " = 1";
                foreach (var item in retList)
                {
                    msg = msg + " * " + item.ToString();
                }
                Console.WriteLine(msg);
            }
            
            Console.ReadKey();
        }

        //分解质因数
        private static List<int> PrimeFactorizate(int interger)
        {
            List<int> retList = new List<int>();
            if (IsPrimeNumber(interger))
            {
                return new List<int>() { interger };
            }
            else
            {
                for (int i = 2; i < interger; i++)
                {
                    if (interger % i == 0)
                    {
                        if (IsPrimeNumber(i))
                        {
                            retList.Add(i);
                            retList.AddRange(PrimeFactorizate(interger / i));
                            break;
                        }
                    }
                }
            }
            
            return retList;
        }

        //判断一个数是否是质数
        private static bool IsPrimeNumber(int number)
        {
            if (number==1 || number == 2)
            {
                return true;
            }
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

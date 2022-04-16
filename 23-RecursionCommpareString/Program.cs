using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 判断两个string是否相同，如Tom和Tommy为false，Bob和Bob为True
 */
namespace _23_RecursionCommpareString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strA = "ABC";
            string strB = "ABH";//"BBC","ABCD"
            var flag = CompareString(strA, strB);
            Console.WriteLine($"{strA}=={strB} is {flag}");
            Console.ReadKey();
        }

        private static bool CompareString(string strA, string strB,int index=0)
        {
            if (strA.Length != strB.Length)
            {
                return false;
            }
            else if (strA.Length-1==index)// 同strB.Length-1==index
            {
                return strA[index]==strB[index];
            }
            else
            {                
                return strA[index]==strB[index] && CompareString(strA, strB,index+1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 回文判断，ABCBA
 */
namespace _15_RecursionPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "马趁香微路远，纱笼月淡烟斜。渡波清彻映妍华，倒绿枝寒凤挂。挂凤寒枝绿倒，华妍映彻清波。渡斜烟淡月笼纱。远路微香趁马";
            word = word.Replace("，", "").Replace("。", "");
            word = "ABCCBAD";
            bool flag = IsPalindrome(word,0,word.Count()-1);
            Console.WriteLine(flag);
            Console.ReadKey();
        }

        private static bool IsPalindrome(string word,int start,int end)
        {
            if (end - start <= 2)
            {
                return word[start] == word[end];
            }
            else
            {                
                return (word[start] == word[end]) && IsPalindrome(word, start + 1, end - 1);
            }            
        }
    }
}

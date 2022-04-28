using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 爬楼梯，每次只能爬1个或2个台阶，总共n个台阶，共有多少种方法
 */
namespace _35_RecursionClimbStairs
{
    public class Node
    {
        public int data;
        public List<Node> children = new List<Node>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {            
            for (int i = 1; i < 11; i++)
            {
                Node node = new Node();
                node.data = 0;
                int sum = ClimbStairs(node, i);                
                Console.WriteLine($"{i} -- {sum}");    
            }
            
            Console.ReadKey();
        }
        //注意0层的时候为0
        private static int ClimbStairs(Node node, int sum)
        {
            int count = 0;
            if (sum == 0)
            {
                return 1;
            }
            else if (sum == -1)
            {
                return 0;
            }
            else
            {
                Node left = new Node();
                left.data = 1;
                Node right = new Node();
                right.data = 2;
                node.children.Add(left);
                node.children.Add(right);
                foreach (var item in node.children)
                {
                    count = count + ClimbStairs(item, sum - item.data);
                }
                return count;
            }
        }
            
        //这个是在获得递推公式为f(n)=f(n-1)+f(n-2)时
        private static int ClimbStairs(int layers)
        {
            if (layers == 1)
            {
                return 1;
            }
            else if (layers == 2)
            {
                return 2;
            }
            else
            {
                return ClimbStairs(layers - 1) + ClimbStairs(layers - 2);
            }
        }
        
    }
}

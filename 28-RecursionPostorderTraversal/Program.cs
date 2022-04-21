using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 二叉树后序遍历
 */
namespace _28_RecursionPostorderTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = CreateBinaryTree(3);
            var ret = PostorderTraversal(node);
            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static List<int> PostorderTraversal(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                return new List<int>() { node.dataValue };
            }
            else
            {
                List<int> ret_list = new List<int>();                
                ret_list.AddRange(PostorderTraversal(node.left)); 
                ret_list.AddRange(PostorderTraversal(node.right));
                ret_list.Add(node.dataValue);

                return ret_list;
            }
        }


        //满二叉树
        private static int seed = 0;
        static private TreeNode CreateBinaryTree(int level, int start = 1)
        {
            seed++;
            Random random = new Random(seed);
            int x = random.Next(1, 100);

            TreeNode node = new TreeNode(x, start);
            if (start == level)
            {
                return node;
            }
            else
            {
                node.left = CreateBinaryTree(level, start + 1);
                node.right = CreateBinaryTree(level, start + 1);
                return node;
            }
        }
    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int levelNo;
        public int dataValue;
        public TreeNode(int data, int level)
        {
            dataValue = data;
            levelNo = level;
        }
    }
}
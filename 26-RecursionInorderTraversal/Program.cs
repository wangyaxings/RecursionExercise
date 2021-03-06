using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 二叉树中序遍历
 */
namespace _26_RecursionInorderTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = CreateBinaryTree(3);
            var ret = InorderTraversal(node);
            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static List<int> InorderTraversal(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                return new List<int>() { node.dataValue };
            }
            else
            {
                List<int> resultList = new List<int>();
                resultList.AddRange(InorderTraversal(node.left));
                resultList.Add(node.dataValue);
                resultList.AddRange(InorderTraversal(node.right));
                return resultList;
            }
        }

        //中序遍历

        //满二叉树
        static private TreeNode CreateBinaryTree(int level, int start = 1)
        {
            Random random = new Random(start);
            int x = random.Next(1,100);

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

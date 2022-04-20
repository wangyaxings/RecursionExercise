using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 满二叉树的前序遍历
 */
namespace _27_RecursionPreOrderTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = CreateBinaryTree(3);
            var ret = PreorderTraversal(node);
            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static List<int> PreorderTraversal(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                return new List<int>() { node.dataValue };
            }
            else
            {
                List<int> resultList = new List<int>();
                resultList.Add(node.dataValue);//其相对于下临左右递归的位置关系即说明了前中后序遍历
                resultList.AddRange(PreorderTraversal(node.left));                
                resultList.AddRange(PreorderTraversal(node.right));
                return resultList;
            }
        }

        //中序遍历

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 创建二叉树
 */
namespace _25_RecursionBinaryTreeCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node = CreateBinaryTree(3);
        }
        //满二叉树
        static private TreeNode CreateBinaryTree(int level,int start=1)
        {
            Random random = new Random(start);
            int x = random.Next();

            TreeNode node = new TreeNode(x,start);
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
    
    class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int levelNo;
        public int dataValue;
        public TreeNode(int data,int level)
        {
            dataValue = data;
            levelNo = level;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 计算一个树形结构的最大深度
 */
namespace _34_RecursionMaxNodeDepth
{
    class Node
    {
        public int nodeData;
        public List<Node> children = new List<Node>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node() { nodeData = 11 };
            Node node2D = new Node() { nodeData = 9, children = new List<Node>() { node, node, node } };
            Node node3D = new Node() { nodeData = 10, children = new List<Node>() { node, node2D, node } };
            Node root = new Node() { nodeData = 10, children = new List<Node>() { node, node2D, node, node3D } };

            int maxDepth = MaxNodeDepth(root);
            Console.WriteLine(maxDepth);
            Console.ReadKey();
        }

        //相当于遍历整个树形结构，每进入一层，记录加一，选出最大值
        private static int MaxNodeDepth(Node root)
        {
            if (root.children.Count == 0)
            {
                return 1;
            }
            else
            {
                List<int> depthList = new List<int>();
                foreach (var item in root.children)
                {
                    int depth = 1 + MaxNodeDepth(item);
                    depthList.Add(depth);
                }               
                
                return depthList.Max();
            }
        }
    }
}

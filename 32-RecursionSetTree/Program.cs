using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 根据集合之间的包含关系，生成一个树形关系数据 例如[A:(1,90),B:(2,53),C:(4,20),D:(100,120),]
 * 则有root(A(B(C)),D)
 */
namespace _32_RecursionSetTree
{
    public class Node
    {
        public Tuple<int, int> nodeData;
        public Node parentNode;
        public List<Node> childrenNodeList = new List<Node>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //01-所有区间序列
            List<Tuple<int, int>> tmpNodesList = new List<Tuple<int, int>>()
            {
                new Tuple<int,int>(809, 858),
                new Tuple<int,int>(860, 915),
                new Tuple<int,int>(996, 1404),
                new Tuple<int,int>(2024, 2201),
                new Tuple<int,int>(2347, 2534),
                new Tuple<int,int>(3812, 3848),
                new Tuple<int,int>(4062, 4121),
                new Tuple<int,int>(5180, 5286),
                new Tuple<int,int>(5689, 5760),
                new Tuple<int,int>(5895, 5970),
                new Tuple<int,int>(6186, 6231),
                new Tuple<int,int>(6233, 6427),
                new Tuple<int,int>(550, 6435),
                new Tuple<int,int>(567, 6433),
                new Tuple<int,int>(984, 6195),
                new Tuple<int,int>(1472, 4017),
                new Tuple<int,int>(2269, 2587),
                new Tuple<int,int>(2590, 3709),
                new Tuple<int,int>(2739, 2934),
                new Tuple<int,int>(2936, 3086),
                new Tuple<int,int>(3089, 3292),
                new Tuple<int,int>(3294, 3448),
                new Tuple<int,int>(3533, 3687),
                new Tuple<int,int>(4020, 6185),
                new Tuple<int,int>(4133, 5508),
                new Tuple<int,int>(5080, 5312),
                new Tuple<int,int>(5611, 6171)
            };
            //02-排序
            List<Tuple<int, int>> sorted_tmp_nodes_list = Sort(tmpNodesList);
            //03-树形结构生成
            Node node = PlantNodesToTree(sorted_tmp_nodes_list);
        }

        private static Node PlantNodesToTree(List<Tuple<int, int>> sortedTmpNodeDataList)
        {
            //建立根节点
            Node root = new Node();
            root.nodeData = RangeNodes(sortedTmpNodeDataList);
            //将所有节点添加到根节点上
            for (int i = 0; i < sortedTmpNodeDataList.Count; i++)
            {
                Node tmp_node = new Node();
                tmp_node.nodeData = sortedTmpNodeDataList[i];

                AddChildrenNodes(tmp_node, ref root);
            }
            return root;
        }

        //真正的递归函数
        private static void AddChildrenNodes(Node node, ref Node parentNode)
        {
            if (parentNode.childrenNodeList.Count == 0)
            {
                node.parentNode = parentNode;
                parentNode.childrenNodeList.Add(node);
            }
            else
            {
                bool flag = false;
                for (int i = 0; i < parentNode.childrenNodeList.Count; i++)
                {
                    var nodeItem = parentNode.childrenNodeList[i];
                    if (IsChildNode(node, nodeItem))
                    {
                        AddChildrenNodes(node, ref nodeItem);
                        flag = true;
                    }
                }
                if (!flag)
                {
                    node.parentNode = parentNode;
                    parentNode.childrenNodeList.Add(node);
                }
            }
        }

        #region 辅助函数
        //设置root节点范围
        private static Tuple<int, int> RangeNodes(List<Tuple<int, int>> tmpNodesList)
        {
            return new Tuple<int, int>(tmpNodesList[0].Item1, tmpNodesList[0].Item2 + 1);
        }

        //对输入的元组序列进行排序
        private static List<Tuple<int, int>> Sort(List<Tuple<int, int>> tmpNodesList)
        {
            List<Tuple<int, int>> retList = new List<Tuple<int, int>>();
            List<int> startList = new List<int>();
            foreach (var item in tmpNodesList)
            {
                startList.Add(item.Item1);
            }
            startList.Sort();
            foreach (var item in startList)
            {
                foreach (var nodeItem in tmpNodesList)
                {
                    if (item == (nodeItem.Item1))
                    {
                        retList.Add(nodeItem);
                    }
                }
            }
            return retList;
        }

        //判断nodeA是否是nodeB的子节点
        private static bool IsChildNode(Node nodeA, Node nodeB)
        {
            return nodeB.nodeData.Item1 <= nodeA.nodeData.Item1 && nodeB.nodeData.Item2 >= nodeA.nodeData.Item2;
        } 
        #endregion
    }
}

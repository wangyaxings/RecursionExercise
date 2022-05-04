using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * leetcode-1600.王位继承顺序
 */
namespace _41_RecursionThroneInheritance
{
    public class ThroneNode
    {
        public List<ThroneNode> children = new List<ThroneNode>();
        public string name;//当前节点的名字
        public bool lifeState = true;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ThroneInheritance t = new ThroneInheritance("king"); // 继承顺序：king
            t.Birth("king", "andy"); // 继承顺序：king > andy
            t.Birth("king", "bob"); // 继承顺序：king > andy > bob
            t.Birth("king", "catherine"); // 继承顺序：king > andy > bob > catherine
            t.Birth("andy", "matthew"); // 继承顺序：king > andy > matthew > bob > catherine
            t.Birth("bob", "alex"); // 继承顺序：king > andy > matthew > bob > alex > catherine
            t.Birth("bob", "asha"); // 继承顺序：king > andy > matthew > bob > alex > asha > catherine

            IList<string> thoroneInheritanceSequence = t.GetInheritanceOrder();
            Print(thoroneInheritanceSequence);// 返回 ["king", "andy", "matthew", "bob", "alex", "asha", "catherine"]
            t.Death("bob"); // 继承顺序：king > andy > matthew > bob（已经去世）> alex > asha > catherine
            thoroneInheritanceSequence.Clear();
            thoroneInheritanceSequence = t.GetInheritanceOrder();
            Print(thoroneInheritanceSequence);// 返回 ["king", "andy", "matthew", "alex", "asha", "catherine"]

        }

        private static void Print(IList<string> thoroneInheritanceSequence)
        {
            foreach (var item in thoroneInheritanceSequence)
            {
                Console.Write(item + ">");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
    public class ThroneInheritance
    {
        private ThroneNode root = null;
        //0-建立根节点
        public ThroneInheritance(string kingName)
        {
            root = new ThroneNode();
            root.name = kingName;            
        }

        //1-给该节点树添枝加叶
        public void Birth(string parentName, string childName)
        {
            //遍历root节点，查找名称为parentName的节点，并将childName添加到其子节点中
            Traversal(parentName, childName, root);
        }
        public void Traversal(string parentName, string childName, ThroneNode node)
        {
            if (node.name == parentName)
            {
                ThroneNode childNode = new ThroneNode();
                childNode.name = childName;
                node.children.Add(childNode);
                return;
            }

            if (node.children.Count == 0)
            {
                return;
            }
            else
            {
                foreach (var item in node.children)
                {
                    if (item.name == parentName)
                    {
                        ThroneNode childNode = new ThroneNode();
                        childNode.name = childName;
                        item.children.Add(childNode);
                        return;
                    }
                    else
                    {
                        Traversal(parentName, childName, item);
                    }
                }
            }

        }

        //2-该节点的可用性置为不可用
        public void Death(string name)
        {
            SetDeathNote(name, root);
        }

        //2
        public void SetDeathNote(string name, ThroneNode node)
        {
            if (node.name == name)
            {
                node.lifeState = false;
            }

            if (node.children.Count == 0)
            {                
                return;
            }
            else
            {
                foreach (var item in node.children)
                {
                    if (item.name == name)
                    {
                        item.lifeState = false;
                        return;
                    }
                    else
                    {
                        SetDeathNote(name, item);
                    }
                }
            }
        }

        //3-前序遍历该树获取所有有效继承
        public IList<string> GetInheritanceOrder()
        {
            return PreorderTraversal(root);
        }
        //3
        private IList<string> PreorderTraversal(ThroneNode node)
        {
            List<string> retList = new List<string>();
            if (node.children.Count == 0)
            {
                if (node.lifeState)
                {
                    retList.Add(node.name);
                }
                return retList;
            }
            else
            {
                if (node.lifeState)
                {
                    retList.Add(node.name);
                }
                foreach (var item in node.children)
                {
                    var tmp = PreorderTraversal(item);
                    if (tmp.Count != 0)
                    {
                        retList.AddRange(tmp);
                    }
                }
            }
            return retList;
        }
    }
}

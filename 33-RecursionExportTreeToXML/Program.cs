using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
* 将树形结构中的数据保存到XML文件中
*/
namespace _33_RecursionExportTreeToXML
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
            Node node = new Node() { nodeData = 11};
            Node node2D = new Node() { nodeData = 9, children = new List<Node>() { node, node, node } };            
            Node root = new Node() {nodeData=10,children=new List<Node>() { node,node2D,node} };

            bool ret = ExportTreeToXML(root);
            Console.WriteLine(ret);
            Console.ReadKey();
        }

        private static bool ExportTreeToXML(Node node)
        {
            try
            {
                XDocument xdoc = new XDocument();
                XElement root = new XElement("root");
                XElement tmpNode = new XElement("nodeData");
                tmpNode.SetAttributeValue("value", node.nodeData);
                
                AddChildrenSimple(node, tmpNode);
                
                root.Add(tmpNode);
                xdoc.Add(root);
                xdoc.Save("TreeData.xml");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void AddChildren(Node node, XElement xmlNode)
        {
            node.children.ForEach(child =>
            {
                XElement tmpNode = new XElement("nodeData");
                tmpNode.SetAttributeValue("value", child.nodeData);
                AddChildren(child, tmpNode);
                xmlNode.Add(tmpNode);
            });
        }

        private static void AddChildrenSimple(Node node, XElement xmlNode)
        {            
            if (node.children.Count == 0)
            {
                return;
            }
            else
            {
                for (int i = 0; i < node.children.Count; i++)
                {
                    XElement tmpNode = new XElement("nodeData");
                    tmpNode.SetAttributeValue("value",node.children[i].nodeData);
                    
                    AddChildrenSimple(node.children[i], tmpNode);

                    xmlNode.Add(tmpNode);
                }
            }
        }        
    }
}

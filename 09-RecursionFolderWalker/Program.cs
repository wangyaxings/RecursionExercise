using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 遍历文件夹下所有文件
 */
namespace _09_RecursionFolderWalker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //遍历路径
            string path = @"D:\";
            
            IList<string> files = new List<string>();
                        FolderWalker(path, ref files);
            
            //打印结果
            Print(files);
            
            Console.ReadKey();
        }

        private static void Print(IList<string> files)
        {
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }

        private static void FolderWalker(string path, ref IList<string> files)
        {            
            //对一些需要特殊访问权限的文件夹可能会报错
            List<string> dirs = Directory.GetDirectories(path).ToList();
            //文件夹下没有文件夹时
            if (dirs.Count == 0)
            {
                files = files.Concat(Directory.GetFiles(path).ToList()).ToList();
                //return files;
            }
            else
            {
                foreach (var item in dirs)
                {
                    FolderWalker(item, ref files);
                }
                
                //return files;
            }
        }
    }
}

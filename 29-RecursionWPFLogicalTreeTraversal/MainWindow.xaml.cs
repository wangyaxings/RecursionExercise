using System.Windows;
using System.Windows.Controls;

namespace _29_RecursionWPFLogicalTreeTraversal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.logicTree.Items.Add(GetLogicalTree(this));
        }
        public TreeViewItem GetLogicalTree(DependencyObject dependencyObject)
        {
            if (dependencyObject == null)
            {
                return null;
            }
            else
            {
                TreeViewItem treeViewItem = new TreeViewItem() { Header= dependencyObject.GetType().FullName, IsExpanded=true};
                foreach (var child in LogicalTreeHelper.GetChildren(dependencyObject))
                {
                    var node = GetLogicalTree(child as DependencyObject);
                    if (node != null)
                    {
                        treeViewItem.Items.Add(node);
                    }                    
                }
                return treeViewItem;
            }            
        }
    }
}

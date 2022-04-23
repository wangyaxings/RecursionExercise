using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
/*
 * 遍历WPF视觉树
 */
namespace _30_RecursionWPFVisualTreeTraversal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.visualTree.Items.Add(GetVisualTree(this));
        }

        private TreeViewItem GetVisualTree(DependencyObject dependencyObject)
        {
            if (dependencyObject == null)
            {
                return null;
            }
            else
            {
                TreeViewItem visualTreeItem = new TreeViewItem() { Header=dependencyObject.GetType().FullName,IsExpanded=true};
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(dependencyObject); i++)
                {
                    var child = VisualTreeHelper.GetChild(dependencyObject, i);
                    var item = GetVisualTree(child);
                    if (item != null)
                    {
                        visualTreeItem.Items.Add(item);
                    }                    
                }
                return visualTreeItem;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.visualTree.Items.Add(GetVisualTree(this));
        }
    }
}

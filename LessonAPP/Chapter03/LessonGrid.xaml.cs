using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter03
{
    /// <summary>
    /// Interaction logic for LessonGrid.xaml
    /// </summary>
    public partial class LessonGrid : Window
    {
        public LessonGrid ()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            LessonGridSplitter win1 = new LessonGridSplitter();
            win1.Owner = this; // 设置当前窗口为新窗口的父窗口 MainWindow : Window
            win1.Show();
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            LessonGridSplitter win1 = new LessonGridSplitter();
            win1.Owner = this; // 设置当前窗口为新窗口的父窗口 MainWindow : Window
            win1.Show();
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            LessonGridSplitter win1 = new LessonGridSplitter();
            win1.Owner = this; // 设置当前窗口为新窗口的父窗口 MainWindow : Window
            win1.Show();
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            LessonGridSplitter win1 = new LessonGridSplitter();
            win1.Owner = this; // 设置当前窗口为新窗口的父窗口 MainWindow : Window
            win1.Show();
        }
    }
}
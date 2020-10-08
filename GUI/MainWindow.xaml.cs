using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ongaku
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region 最小化窗口
        public void MinimizeWindowEvent(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
        #endregion

        #region 关闭窗口
        public void CloseWindowEvent(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }
        #endregion

        #region 打开菜单
        private void HeaderMenuEvent(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            button.ContextMenu.IsOpen = true;
        }
        #endregion

        #region 菜单操作

        #region 打开文件



        #endregion

        #region 帮助链接
        private void OpenHelpEvent(object sender,RoutedEventArgs e)//帮助链接
        {
            System.Diagnostics.Process.Start("https://help.cafu-chino.top");
        }
        #endregion

        # region 关于窗口
        private void OpenAboutWindowEvent(object sender, RoutedEventArgs e)//关于窗口
        {
            AboutWindow window = new AboutWindow();
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Owner=this;
            window.ShowDialog();
        }
        #endregion

        #endregion

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ImportMediaFile(object sender, RoutedEventArgs e)
        {

        }
    }
}

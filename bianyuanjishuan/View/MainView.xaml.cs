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

namespace bianyuanjishuan.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            Home_page page1 = new Home_page();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
            this.MaxHeight = SystemParameters.PrimaryScreenHeight;

        }

        public void main_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void main_min(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            
        }  

        private void main_max(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ?
                WindowState.Normal : WindowState.Maximized;
        }

        public void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void home_page(object sender, RoutedEventArgs e)
        {
            Home_page page1 = new Home_page();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void first_page(object sender, RoutedEventArgs e)
        {
            FirstPageView page1 = new FirstPageView();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void TP(object sender, RoutedEventArgs e)
        {
            tuopu page1 = new tuopu();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Sys_mange(object sender, RoutedEventArgs e)
        {
            UserControl1 page1 = new UserControl1();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }
        public void Uesr_manage(object sender, RoutedEventArgs e)
        {
            UesrTest page1 = new UesrTest();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        public void show_user(object sender, RoutedEventArgs e)
        {
            
        }

        private void userinfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using bianyuanjishuan.View;
namespace bianyuanjishuan
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            if(new Login().ShowDialog() == true)
            {
                new MainView().ShowDialog();
            }
            Application.Current.Shutdown();
        }
    }
}

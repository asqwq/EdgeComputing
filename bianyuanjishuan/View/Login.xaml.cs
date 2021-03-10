using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace bianyuanjishuan.View
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            
        }
        String username = "";
        String password = "";
        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {

            this.user_name.Text = username;
            this.user_name.Text = "";

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void User_login(object sender, RoutedEventArgs e)
        {
            username = this.user_name.Text;
            password = this.user_psw.Password;
            if (username == "" || password == "")
            {
                MessageBox.Show("账号或密码不能为空");
            }
            else
            {
                string connString = "server=localhost; database=byjs; uid=root; pwd=123456";
                MySqlConnection conn = new MySqlConnection(connString);
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from users where user_name= '" + username + "' and user_psw = '" + password + "'", conn);
                    cmd.CommandTimeout = 12000;
                    MySqlDataReader mdr = cmd.ExecuteReader();
                    if (mdr.HasRows == false)
                    {
                        MessageBox.Show("账号或密码错误");
                    }
                    if (mdr.HasRows == true)
                    {
                        this.window.DialogResult = true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }
        
        
    }
}

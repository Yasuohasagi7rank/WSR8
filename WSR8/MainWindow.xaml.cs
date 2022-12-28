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
using WSR8.Pages;

namespace WSR8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Regist regist = new Regist();
            regist.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var user = App.Conxent.User.FirstOrDefault(x => x.UserLogin == TBox_Login.Text && x.UserPassword == PBox_Password.Password);
            if (user != null)
            {
                App.users = user;
                Main main = new Main();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет", "Ошибка");
            }
        }
    }  
}

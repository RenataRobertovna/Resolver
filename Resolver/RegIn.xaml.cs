using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Resolver
{
    /// <summary>
    /// Логика взаимодействия для RegIn.xaml
    /// </summary>
    public partial class RegIn : Window
    {
        private const string host = "mysql11.hostland.ru";
        private const string database = "host1323541_suptest10";
        private const string port = "3306";
        private const string username = "host1323541_itstep";
        private const string pass = "269f43dc";
        private const string ConnString = "Server=" + host + ";Database=" + database + 
                            ";port=" + port + ";User Id=" + username + ";password=" + pass;
    
        public RegIn()
        {
            InitializeComponent();
        }

        //обработка события кнопки отмена
        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            var res = MessageBox.Show("Вы уверены, что хотите закрыть окно авторизации?", "Подтвердите действие", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void input_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        //обработка событий кнопки регистрации
        private void button_Regin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

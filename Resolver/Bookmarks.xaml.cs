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
    /// Логика взаимодействия для Bookmarks.xaml
    /// </summary>
    public partial class Bookmarks : Window
    {
        public Bookmarks()
        {
            InitializeComponent();
        }

        private void Vip_Page_Click(object sender, RoutedEventArgs e)
        {
            Vip vip = new Vip(); //открытие главного окна
            vip.Show();

            this.Close(); //закрытие этого окна
        }

        private void Home_Page_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(); //открытие главного окна
            mainWindow.Show();

            this.Close(); //закрытие этого окна
        }

        private void Questions_Page_Click(object sender, RoutedEventArgs e)
        {
            Questions questions = new Questions(); //открытие главного окна
            questions.Show();

            this.Close(); //закрытие этого окна
        }

        private void Bookmarks_Page_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
    /// Логика взаимодействия для Questions.xaml
    /// </summary>
    public partial class Questions : Window
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void Questions_page_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vip_page_Click(object sender, RoutedEventArgs e)
        {
            Vip vip = new Vip(); //открытие главного окна
            vip.Show();

            this.Close(); //закрытие этого окна
        }

        private void Bookmarks_page_Click(object sender, RoutedEventArgs e)
        {
            Bookmarks bookmarks = new Bookmarks(); //открытие главного окна
            bookmarks.Show();

            this.Close(); //закрытие этого окна
        }

        private void Home_page_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(); //открытие главного окна
            mainWindow.Show();

            this.Close(); //закрытие этого окна
        }

        private void Ask_a_Question_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
    /// Логика взаимодействия для Vip.xaml
    /// </summary>
    public partial class Vip : Window
    {
        public Vip()
        {
            InitializeComponent();
        }

        private void buttonPay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(); //открытие главного окна
            mainWindow.Show();

            this.Close(); //закрытие этого окна
        }

        private void VipPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BookmarksPage_Click(object sender, RoutedEventArgs e)
        {
            Bookmarks bookmarks = new Bookmarks(); //открытие главного окна
            bookmarks.Show();

            this.Close(); //закрытие этого окна
        }

        private void QuestionsPage_Click(object sender, RoutedEventArgs e)
        {
            Questions questions = new Questions(); //открытие главного окна
            questions.Show();

            this.Close(); //закрытие этого окна
        }
    }
}

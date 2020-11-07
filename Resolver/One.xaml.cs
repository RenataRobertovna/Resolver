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
    /// Логика взаимодействия для One.xaml
    /// </summary>
    public partial class One : Window
    {
        public One()
        {
            InitializeComponent();
        }

        private void Math1_Click(object sender, RoutedEventArgs e)
        {
            Math_book math_book = new Math_book();
            math_book.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(); //открытие главного окна
            mainWindow.Show();

            this.Close();
        }
    }
}

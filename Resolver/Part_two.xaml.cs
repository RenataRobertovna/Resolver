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
    /// Логика взаимодействия для Part_two.xaml
    /// </summary>
    public partial class Part_two : Window
    {
        public Part_two()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(); //открытие главного окна
            mainWindow.Show();

            this.Close();
        }

        private void buttonPage_9_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}

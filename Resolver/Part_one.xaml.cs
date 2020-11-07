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
    /// Логика взаимодействия для Part_one.xaml
    /// </summary>
    public partial class Part_one : Window
    {
        public Part_one()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Math_book math_Book = new Math_book();
            math_Book.Show();

            this.Close();
        }
    }
}

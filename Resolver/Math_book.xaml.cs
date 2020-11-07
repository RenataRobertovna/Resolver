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
    /// Логика взаимодействия для Math_book.xaml
    /// </summary>
    public partial class Math_book : Window
    {
        public Math_book()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            One one = new One();
            one.Show();
            this.Close();
        }

        private void part1_Click(object sender, RoutedEventArgs e)
        {
            Part_one part_One = new Part_one();
            part_One.Show();
            this.Close();
        }

        private void part2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

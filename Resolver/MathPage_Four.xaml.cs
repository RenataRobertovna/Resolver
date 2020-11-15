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
    /// Логика взаимодействия для MathPage_Four.xaml
    /// </summary>
    public partial class MathPage_Four : Window
    {
        public MathPage_Four()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            Part_one part_One = new Part_one();
            part_One.Show();

            this.Close();
        }
    }
}

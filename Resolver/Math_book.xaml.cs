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
            Part_two part_Two = new Part_two();
            part_Two.Show();
            this.Close();
        }

        private void button_Task_Click(object sender, RoutedEventArgs e)
        {
            PartTwo_Task partTwo_Task = new PartTwo_Task();
            partTwo_Task.Show();
            this.Close();
        }

        private void button_task_Click_1(object sender, RoutedEventArgs e)
        {
            PartTwo_task2 partTwo_Task2 = new PartTwo_task2();
            partTwo_Task2.Show();
            this.Close();
        }
    }
}

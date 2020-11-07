using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Resolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Открытие окна закладки
        private void Bookmarks_Click(object sender, RoutedEventArgs e)
        {
            Bookmarks bookmarks = new Bookmarks();
            bookmarks.Show();
            this.Close();
        }

        //Открытие окна покупки премиум 
        private void Vip_Click(object sender, RoutedEventArgs e)
        {
            Vip vip = new Vip();
            vip.Show();
            this.Close();
        }

        //Открытия окна вопросы
        private void Questions_Click(object sender, RoutedEventArgs e)
        {
            Questions questions = new Questions();
            questions.Show();
            this.Close();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            One one = new One();
            one.Show();
            this.Close();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

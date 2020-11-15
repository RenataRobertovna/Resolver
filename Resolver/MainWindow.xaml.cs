using System;
using System.Collections.Generic;
using System.IO;
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
        string path = "Log.txt";
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_Closing;
            this.Closed += MainWindow_Closed;

        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Log("Loaded");
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Log("Closing");
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Log("Closed");
        }
        private void Log(string eventName)
        {
            using (StreamWriter logger = new StreamWriter(path, true))
            {
                logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + eventName);
            }
        }

            //Открытие окна закладки
        private void Bookmarks_Click(object sender, RoutedEventArgs e)
        {
            Bookmarks bookmarks = new Bookmarks();
            bookmarks.Show();
            this.Close();
        }

        //Открытие окна покупки премиум 
        /*private void Vip_Click(object sender, RoutedEventArgs e)
        {
            Vip vip = new Vip();
            vip.Show();
            this.Close();
        }*/

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
            Two two = new Two();
            two.Show();
            this.Close();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Three three = new Three();
            three.Show();
            this.Close();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Four four = new Four();
            four.Show();
            this.Close();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Five five = new Five();
            five.Show();
            this.Close();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Six six = new Six();
            six.Show();
            this.Close();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Seven seven = new Seven();
            seven.Show();
            this.Close();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Eight eight = new Eight();
            eight.Show();
            this.Close();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Nine nine = new Nine();
            nine.Show();
            this.Close();
        }
    }
}

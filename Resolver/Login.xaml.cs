﻿using System;
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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonSingIn_Click(object sender, RoutedEventArgs e)
        {
            SingIn singIn = new SingIn();
            singIn.Show();
            this.Close();
        }

        private void ButtonRegIn_Click(object sender, RoutedEventArgs e)
        {
            RegIn regIn = new RegIn();
            regIn.Show();
            this.Close();
        }
    }
}

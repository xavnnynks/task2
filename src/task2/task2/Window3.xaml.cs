﻿using System;
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
using System.Windows.Shapes;

namespace task2
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

      

        private void jail_TextChanged(object sender, TextChangedEventArgs e)
        {
            enter.Content = "Неверный пароль";
            if (jail.Text == "sdfff445qqwt7n#111")
            {
                enter.Content = "Вы видите секретное сообщение";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 pW = new Window2();
            pW.Show();
            this.Close();
        }
    }
}

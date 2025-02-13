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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PractikaSalon.Pages
{
    /// <summary>
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Page
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void btndobavzakaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DobavZakaz());
        }

        private void btnklient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Klient());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Sotrudnik());
        }
    }
}

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

namespace PractikaSalon.Pages
{
    /// <summary>
    /// Логика взаимодействия для Sotrudnik.xaml
    /// </summary>
    public partial class Sotrudnik : Page
    {
        public Sotrudnik()
        {
            InitializeComponent();
        }

        private void btaddsotrudnik_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DobavSotrudnik());
        }

        private void btadklient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Klient());
        }

        private void btaddzakaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Zakaz());
        }
    }
}
